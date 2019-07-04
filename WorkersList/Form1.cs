using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WorkersList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //funkcja filtrująca widok danych
        private void filter(int x)
        {
            for (int u = 0; u < dataGridView1.RowCount - 1; u++)
            {

                if (dataGridView1.Rows[u].Cells[x].Value.ToString().Contains(textBox1.Text))
                {
                    dataGridView1.Rows[u].Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    dataGridView1.Rows[u].Visible = false;
                    currencyManager1.ResumeBinding();

                }
            }
        }
        //odwołanie do klasy zestawu danych stworzonego na potrzeby zadania
        DataSetWL ds = new DataSetWL();
        String dbLoc = "XMLDatabase.xml";
        

        private void Form1_Load(object sender, EventArgs e)
        {

            //odpowiednie działania gdy plik Xml nie istnieje
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(dbLoc);
                
            }
            catch (XmlException)
            {
                ds.WriteXml(dbLoc, XmlWriteMode.WriteSchema);
            }
            catch (FileNotFoundException)
            {
                ds.WriteXml(dbLoc, XmlWriteMode.WriteSchema);
            }
            //wczytanie Xml jako źródła danych
            ds.ReadXml(dbLoc);
            dataGridView1.DataSource = ds.Tables[0];

            try
            {
                dataGridView1.Columns[6].Visible = false;
            }
            catch (ArgumentOutOfRangeException) { }
            comboBox1.Items.Add("");
            comboBox1.Items.Add("NIP");
            comboBox1.Items.Add("Nazwisko");
            comboBox1.Items.Add("Stanowisko");

        }

        //zapisanie zmian do Xml prze zamknięciu aplikacji
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                ds.WriteXml(dbLoc);    
        }

        
        //obsługa przycisku usunięcia wierszy
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                    MessageBox.Show("Usunięto zaznaczone wiersze");
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Wystąpił błąd przy usuwaniu wiersza");
                }
            }
            
        }
        //zresetowanie ustawień filtrów przy wybraniu innej wartości okna
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int u = 0; u < dataGridView1.RowCount-1; u++)
            {
                dataGridView1.Rows[u].Visible = true;
                
            }
        }
        //wywołanie filtrów
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("NIP"))
            {
                filter(5);     
            }
            if (comboBox1.Text.Equals("Nazwisko"))
            {
                filter(1);
            }
            if (comboBox1.Text.Equals("Stanowisko"))
            {
                filter(4);
            }

        }
        //zresetowanie błędu przy zakończeniu edycji pola
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
            
        }
        //weryfikowanie poprawności wpisu pola
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                List<Int64> check = new List<Int64>();
                string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;


                // Sprawdzenie czy pole jest puste
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Nie zostawiaj pustego pola";
                    e.Cancel = true;
                }
                else if (headerText.Equals("NIP") && e.FormattedValue.ToString().Length != 10)
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "NIP musi mieć 10 cyfr";
                    e.Cancel = true;
                }
                else if (e.FormattedValue.ToString().All(char.IsDigit) == false&&(headerText.Equals("NIP")|| headerText.Equals("Wiek")|| headerText.Equals("Wynagrodzenie")))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Pole przyjmuję tylko liczby całkowite";
                    e.Cancel = true;
                }
                else if (headerText.Equals("Wiek") && (Int32.Parse(e.FormattedValue.ToString()) < 1 || Int32.Parse(e.FormattedValue.ToString()) > 100))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Wiek musi znajdować się w przedziale 1-100";
                    e.Cancel = true;
                }
                else if (headerText.Equals("Wynagrodzenie") && (Int32.Parse(e.FormattedValue.ToString()) < 1 || Int32.Parse(e.FormattedValue.ToString()) > 1000000000))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Wynagrodzenie musi być dodatnie";
                    e.Cancel = true;
                }
                else if (headerText.Equals("NIP") && e.FormattedValue.ToString().Length == 10 && e.FormattedValue.ToString().All(char.IsDigit) == true)
                {
                    for (int u = 0; u < dataGridView1.RowCount - 2; u++)
                    {
                        check.Add(Int64.Parse(dataGridView1.Rows[u].Cells[5].Value.ToString()));

                    }
                    if (check.Contains(Int64.Parse(e.FormattedValue.ToString())))
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Isnieje juz rekord o podanym NIPie";
                        e.Cancel = true;
                    }
                }
                
                

            }
            catch (ConstraintException)
            {
                MessageBox.Show("Isnieje juz rekord o podanym NIPie");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Haushaltbuch
{
    public partial class Neu : Form
    {
        float saldo;
        string connectionString;
        SqlConnection cnn;

        public Neu()
        {
            InitializeComponent();
            //Montag als erst tag in der Woche
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            //Heute anzeigen
            monthCalendar1.ShowToday = true;
            //wird nur ein Tag gewaehlt
            monthCalendar1.MaxSelectionCount = 1;

            datenbankVerbindung();
        }

        private void datenbankVerbindung()
        {
            connectionString = @"Data Source=Haushaltsbuch;Initial Catalog=Konto ;User ID= ;Password= ";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection open");
            
            //close connection.
            //cnn.Close();
        }

        private void GetSaldo()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = string.Empty;

            sql ="SELECT saldo FROM Konto ORDER BY id DESC;";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            Output = dataReader.GetValue(0).ToString();
            saldo = Convert.ToSingle(Output);
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonEin_CheckedChanged(object sender, EventArgs e)
        {
            //Kategorien variert nach EinKommen/ Ausgabe.
            if (radioButtonEin.Checked == true)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Gehalt");
                comboBox1.Items.Add("Andere");
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Lebensmittel");
                comboBox1.Items.Add("Wohnkosten");
                comboBox1.Items.Add("Bildung und Ausbildung");
                comboBox1.Items.Add("Sport");
                comboBox1.Items.Add("Reisen");
                comboBox1.Items.Add("Vergnügen");
                comboBox1.Items.Add("Fortbewegung");
                comboBox1.Items.Add("Andere");
                comboBox1.SelectedIndex = 0;
                
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string einAus;
            float betrag;
            string datum;
            string kategorie;

            //Einkommen
            if (radioButtonEin.Checked == true)
            {
                einAus = "ein";
                betrag = Convert.ToSingle(textBoxBetrag.Text);
                datum = monthCalendar1.SelectionRange.Start.ToShortDateString();
                kategorie = comboBox1.Text;
                saldo = saldo + betrag;

            }
            else
            {
                einAus = "aus";
                betrag = Convert.ToSingle(textBoxBetrag.Text);
                datum = monthCalendar1.SelectionRange.Start.ToShortDateString();
                kategorie = comboBox1.Text;
                saldo = saldo - betrag;
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "Insert into Konto (EinAus,Betrag, Datum, Kategorie, Saldo) value($einAus,$betrag,$datum,$kategorie,$saldo)" ;
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }
    }
}

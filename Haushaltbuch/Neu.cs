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
using System.Globalization;

namespace Haushaltbuch
{
    public partial class Neu : Form
    {
        Form1 form = new Form1();
        float saldo;


        public Neu()
        {
            InitializeComponent();
            //Montag als erst tag in der Woche
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            //Heute anzeigen
            monthCalendar1.ShowToday = true;
            //wird nur ein Tag gewaehlt
            monthCalendar1.MaxSelectionCount = 1;
            //Datenbank verbinden
            //form.DatenbankVerbinden();
           // Saldo();
        }
        private void Saldo()
        {
            //saldo ermitteln
            saldo = form.GetSaldo();
            string tempsaldo = saldo.ToString("#0.00", CultureInfo.InvariantCulture);
            saldo = Convert.ToSingle(tempsaldo);
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
            string tempbetrag;
            float betrag;
            string datum;
            string kategorie;


            betrag = Convert.ToSingle(textBoxBetrag.Text);
            tempbetrag = betrag.ToString("#0.00", CultureInfo.InvariantCulture);
            betrag = Convert.ToSingle(tempbetrag);
            datum = monthCalendar1.SelectionRange.Start.ToShortDateString();
            kategorie = comboBox1.Text;

            //Einkommen
            if (radioButtonEin.Checked == true)
            {
                einAus = "E";
                saldo = saldo + betrag;

            }
            //Ausgabe
            else
            {
                einAus = "A";
                saldo = saldo - betrag;
            }

//saldo.ToString("#,00",CultureInfo.InvariantCulture)
            form.UpdateDaten(einAus, betrag.ToString(), datum, kategorie,"5,00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToLongDateString());
        }
    }
}

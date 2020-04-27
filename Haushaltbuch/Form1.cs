using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haushaltbuch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            DatenbankVerbinden();

           // Statistik();
        }

        public void Statistik()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-23QVBVH\MSSQLSERVER01;Initial Catalog=Haushaltsbuch;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, output = string.Empty;
            float gesamtbetrag=0;
            sql = "Select betrag Where EA='E'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    output =dataReader[0].ToString();
                    gesamtbetrag += Convert.ToSingle(output);
                }
            }
            progressBarEin.Maximum = Convert.ToInt32(gesamtbetrag);
            progressBarEin.Value = progressBarEin.Maximum;
            
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        public void DatenbankVerbinden()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-23QVBVH\MSSQLSERVER01;Initial Catalog=Haushaltsbuch;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            //Am Anfang, wenn es gar kein Daten in Datenbank gibt, wird es Saldo 0 hinzugefuegt
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string heute = DateTime.Today.ToString("dd/MM");
            
            String sql = $"If Not Exists(Select id from Buch where id='1') Begin Insert into Buch (EA,Betrag,Datum,Kategorie,Saldo) values('E','0,00', {heute},'Andere','0,00') End"; 

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }
        


        public float GetSaldo()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-23QVBVH\MSSQLSERVER01;Initial Catalog=Haushaltsbuch;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, output = string.Empty;

            sql = "Select Top 1 Saldo From Buch Order By id DESC";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            
                while (dataReader.Read())
                {
                    output = dataReader[0].ToString();
                }
            
            
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            float saldo = Convert.ToSingle(output);
            return saldo;
        }

        public void UpdateDaten(string ea, string betrag, string datum, string kategorie, string saldo)
        {
            string connectionString;
            SqlConnection cnn;
            
            connectionString = @"Data Source=DESKTOP-23QVBVH\MSSQLSERVER01;Initial Catalog=Haushaltsbuch;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = $"Begin " +
                $"Insert into Buch (EA,Betrag,Datum,Kategorie,Saldo) " +
                $"values('{ea}','{betrag}','{datum}','{kategorie}','{saldo}')" +
                $"End";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            Neu neueBeitrag = new Neu();
            neueBeitrag.Show();
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            Liste liste = new Liste();
            liste.Show();
        }
        
    }
}

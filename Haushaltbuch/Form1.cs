using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

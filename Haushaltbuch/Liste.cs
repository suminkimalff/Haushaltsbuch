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
    public partial class Liste : Form
    {
        Form1 form = new Form1();
        public Liste()
        {
            InitializeComponent();
            
        }
        

        private void Liste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "haushaltsbuchDataSet1.Buch". Sie können sie bei Bedarf verschieben oder entfernen.
            this.buchTableAdapter.Fill(this.haushaltsbuchDataSet1.Buch);

        }
    }
}

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
        public Liste()
        {
            InitializeComponent();
        }

        private void kontoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kontoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.haushaltsbuchDataSet);

        }

        private void Liste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "haushaltsbuchDataSet.Konto". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kontoTableAdapter.Fill(this.haushaltsbuchDataSet.Konto);

        }
    }
}

namespace Haushaltbuch
{
    partial class Neu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonEin = new System.Windows.Forms.RadioButton();
            this.radioButtonAus = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.labelBetrag = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBetrag = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radioButtonEin
            // 
            this.radioButtonEin.AutoSize = true;
            this.radioButtonEin.Location = new System.Drawing.Point(36, 12);
            this.radioButtonEin.Name = "radioButtonEin";
            this.radioButtonEin.Size = new System.Drawing.Size(80, 17);
            this.radioButtonEin.TabIndex = 0;
            this.radioButtonEin.TabStop = true;
            this.radioButtonEin.Text = "Einkommen";
            this.radioButtonEin.UseVisualStyleBackColor = true;
            this.radioButtonEin.CheckedChanged += new System.EventHandler(this.radioButtonEin_CheckedChanged);
            // 
            // radioButtonAus
            // 
            this.radioButtonAus.AutoSize = true;
            this.radioButtonAus.Location = new System.Drawing.Point(154, 12);
            this.radioButtonAus.Name = "radioButtonAus";
            this.radioButtonAus.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAus.TabIndex = 1;
            this.radioButtonAus.TabStop = true;
            this.radioButtonAus.Text = "Ausgabe";
            this.radioButtonAus.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(36, 295);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(156, 295);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 3;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // labelBetrag
            // 
            this.labelBetrag.AutoSize = true;
            this.labelBetrag.Location = new System.Drawing.Point(9, 43);
            this.labelBetrag.Name = "labelBetrag";
            this.labelBetrag.Size = new System.Drawing.Size(41, 13);
            this.labelBetrag.TabIndex = 4;
            this.labelBetrag.Text = "Betrag:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(9, 73);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(41, 13);
            this.labelDatum.TabIndex = 5;
            this.labelDatum.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategorie:";
            // 
            // textBoxBetrag
            // 
            this.textBoxBetrag.Location = new System.Drawing.Point(76, 43);
            this.textBoxBetrag.Name = "textBoxBetrag";
            this.textBoxBetrag.Size = new System.Drawing.Size(178, 20);
            this.textBoxBetrag.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(76, 73);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Neu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 338);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxBetrag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelBetrag);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.radioButtonAus);
            this.Controls.Add(this.radioButtonEin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Neu";
            this.Text = "Neu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonEin;
        private System.Windows.Forms.RadioButton radioButtonAus;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Label labelBetrag;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBetrag;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
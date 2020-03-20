namespace Haushaltbuch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNeu = new System.Windows.Forms.Button();
            this.buttonListe = new System.Windows.Forms.Button();
            this.buttonStat = new System.Windows.Forms.Button();
            this.progressBarEin = new System.Windows.Forms.ProgressBar();
            this.progressBarAus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonNeu
            // 
            this.buttonNeu.Location = new System.Drawing.Point(12, 12);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(75, 23);
            this.buttonNeu.TabIndex = 0;
            this.buttonNeu.Text = "Neu";
            this.buttonNeu.UseVisualStyleBackColor = true;
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // buttonListe
            // 
            this.buttonListe.Location = new System.Drawing.Point(121, 12);
            this.buttonListe.Name = "buttonListe";
            this.buttonListe.Size = new System.Drawing.Size(75, 23);
            this.buttonListe.TabIndex = 1;
            this.buttonListe.Text = "Liste";
            this.buttonListe.UseVisualStyleBackColor = true;
            this.buttonListe.Click += new System.EventHandler(this.buttonListe_Click);
            // 
            // buttonStat
            // 
            this.buttonStat.Location = new System.Drawing.Point(224, 12);
            this.buttonStat.Name = "buttonStat";
            this.buttonStat.Size = new System.Drawing.Size(75, 23);
            this.buttonStat.TabIndex = 2;
            this.buttonStat.Text = "Statistik";
            this.buttonStat.UseVisualStyleBackColor = true;
            // 
            // progressBarEin
            // 
            this.progressBarEin.Location = new System.Drawing.Point(12, 273);
            this.progressBarEin.Name = "progressBarEin";
            this.progressBarEin.Size = new System.Drawing.Size(100, 23);
            this.progressBarEin.TabIndex = 3;
            // 
            // progressBarAus
            // 
            this.progressBarAus.Location = new System.Drawing.Point(161, 273);
            this.progressBarAus.Name = "progressBarAus";
            this.progressBarAus.Size = new System.Drawing.Size(100, 23);
            this.progressBarAus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarAus);
            this.Controls.Add(this.progressBarEin);
            this.Controls.Add(this.buttonStat);
            this.Controls.Add(this.buttonListe);
            this.Controls.Add(this.buttonNeu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNeu;
        private System.Windows.Forms.Button buttonListe;
        private System.Windows.Forms.Button buttonStat;
        private System.Windows.Forms.ProgressBar progressBarEin;
        private System.Windows.Forms.ProgressBar progressBarAus;
    }
}


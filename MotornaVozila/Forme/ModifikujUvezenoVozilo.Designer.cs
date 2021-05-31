
namespace MotornaVozila.Forme
{
    partial class ModifikujUvezenoVozilo
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
            this.btnModifikujProdatoVozilo = new System.Windows.Forms.Button();
            this.btnModifikujVoziloKojeNijeProdato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifikujProdatoVozilo
            // 
            this.btnModifikujProdatoVozilo.Location = new System.Drawing.Point(357, 58);
            this.btnModifikujProdatoVozilo.Name = "btnModifikujProdatoVozilo";
            this.btnModifikujProdatoVozilo.Size = new System.Drawing.Size(175, 86);
            this.btnModifikujProdatoVozilo.TabIndex = 0;
            this.btnModifikujProdatoVozilo.Text = "Modifikuj vozilo koje je prodato";
            this.btnModifikujProdatoVozilo.UseVisualStyleBackColor = true;
            this.btnModifikujProdatoVozilo.Click += new System.EventHandler(this.btnModifikujProdatoVozilo_Click);
            // 
            // btnModifikujVoziloKojeNijeProdato
            // 
            this.btnModifikujVoziloKojeNijeProdato.Location = new System.Drawing.Point(357, 204);
            this.btnModifikujVoziloKojeNijeProdato.Name = "btnModifikujVoziloKojeNijeProdato";
            this.btnModifikujVoziloKojeNijeProdato.Size = new System.Drawing.Size(175, 97);
            this.btnModifikujVoziloKojeNijeProdato.TabIndex = 1;
            this.btnModifikujVoziloKojeNijeProdato.Text = "Modifikuj vozilo koje nije prodato";
            this.btnModifikujVoziloKojeNijeProdato.UseVisualStyleBackColor = true;
            this.btnModifikujVoziloKojeNijeProdato.Click += new System.EventHandler(this.btnModifikujVoziloKojeNijeProdato_Click);
            // 
            // ModifikujUvezenoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 515);
            this.Controls.Add(this.btnModifikujVoziloKojeNijeProdato);
            this.Controls.Add(this.btnModifikujProdatoVozilo);
            this.Name = "ModifikujUvezenoVozilo";
            this.Text = "ModifkujUvezenoVozilo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifikujProdatoVozilo;
        private System.Windows.Forms.Button btnModifikujVoziloKojeNijeProdato;
    }
}
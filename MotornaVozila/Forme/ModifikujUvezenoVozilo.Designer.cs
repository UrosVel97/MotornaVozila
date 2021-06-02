
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifikujProdatoVozilo
            // 
            this.btnModifikujProdatoVozilo.Location = new System.Drawing.Point(159, 200);
            this.btnModifikujProdatoVozilo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifikujProdatoVozilo.Name = "btnModifikujProdatoVozilo";
            this.btnModifikujProdatoVozilo.Size = new System.Drawing.Size(131, 70);
            this.btnModifikujProdatoVozilo.TabIndex = 0;
            this.btnModifikujProdatoVozilo.Text = "Modifikuj vozilo koje je prodato";
            this.btnModifikujProdatoVozilo.UseVisualStyleBackColor = true;
            this.btnModifikujProdatoVozilo.Click += new System.EventHandler(this.btnModifikujProdatoVozilo_Click);
            // 
            // btnModifikujVoziloKojeNijeProdato
            // 
            this.btnModifikujVoziloKojeNijeProdato.Location = new System.Drawing.Point(159, 80);
            this.btnModifikujVoziloKojeNijeProdato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifikujVoziloKojeNijeProdato.Name = "btnModifikujVoziloKojeNijeProdato";
            this.btnModifikujVoziloKojeNijeProdato.Size = new System.Drawing.Size(131, 70);
            this.btnModifikujVoziloKojeNijeProdato.TabIndex = 1;
            this.btnModifikujVoziloKojeNijeProdato.Text = "Modifikuj vozilo koje nije prodato";
            this.btnModifikujVoziloKojeNijeProdato.UseVisualStyleBackColor = true;
            this.btnModifikujVoziloKojeNijeProdato.Click += new System.EventHandler(this.btnModifikujVoziloKojeNijeProdato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(70, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izaberite koje vozilo zelite da modifikujete";
            // 
            // ModifikujUvezenoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifikujVoziloKojeNijeProdato);
            this.Controls.Add(this.btnModifikujProdatoVozilo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifikujUvezenoVozilo";
            this.Text = "ModifkujUvezenoVozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifikujProdatoVozilo;
        private System.Windows.Forms.Button btnModifikujVoziloKojeNijeProdato;
        private System.Windows.Forms.Label label2;
    }
}
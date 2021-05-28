
namespace MotornaVozila.Forme
{
    partial class DodajUvezenoVozilo
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
            this.btnDodajVoziloKojeNijeProdato = new System.Windows.Forms.Button();
            this.btnDodajVoziloKojeJeProdato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajVoziloKojeNijeProdato
            // 
            this.btnDodajVoziloKojeNijeProdato.Location = new System.Drawing.Point(129, 47);
            this.btnDodajVoziloKojeNijeProdato.Name = "btnDodajVoziloKojeNijeProdato";
            this.btnDodajVoziloKojeNijeProdato.Size = new System.Drawing.Size(195, 112);
            this.btnDodajVoziloKojeNijeProdato.TabIndex = 0;
            this.btnDodajVoziloKojeNijeProdato.Text = "Dodaj vozilo koje nije prodato";
            this.btnDodajVoziloKojeNijeProdato.UseVisualStyleBackColor = true;
            this.btnDodajVoziloKojeNijeProdato.Click += new System.EventHandler(this.btnDodajVoziloKojeNijeProdato_Click);
            // 
            // btnDodajVoziloKojeJeProdato
            // 
            this.btnDodajVoziloKojeJeProdato.Location = new System.Drawing.Point(129, 166);
            this.btnDodajVoziloKojeJeProdato.Name = "btnDodajVoziloKojeJeProdato";
            this.btnDodajVoziloKojeJeProdato.Size = new System.Drawing.Size(195, 112);
            this.btnDodajVoziloKojeJeProdato.TabIndex = 1;
            this.btnDodajVoziloKojeJeProdato.Text = "Dodaj vozilo koje je prodato";
            this.btnDodajVoziloKojeJeProdato.UseVisualStyleBackColor = true;
            this.btnDodajVoziloKojeJeProdato.Click += new System.EventHandler(this.btnDodajVoziloKojeJeProdato_Click);
            // 
            // DodajUvezenoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 338);
            this.Controls.Add(this.btnDodajVoziloKojeJeProdato);
            this.Controls.Add(this.btnDodajVoziloKojeNijeProdato);
            this.Name = "DodajUvezenoVozilo";
            this.Text = "DodajUvezenoVozilo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVoziloKojeNijeProdato;
        private System.Windows.Forms.Button btnDodajVoziloKojeJeProdato;
    }
}
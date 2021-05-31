
namespace MotornaVozila.Forme
{
    partial class ObrisiUvezenoVozilo
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
            this.btnObrisiVoziloKojeJeProdato = new System.Windows.Forms.Button();
            this.btnObrisiVoziloKojeNijeProdato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObrisiVoziloKojeJeProdato
            // 
            this.btnObrisiVoziloKojeJeProdato.Location = new System.Drawing.Point(304, 74);
            this.btnObrisiVoziloKojeJeProdato.Name = "btnObrisiVoziloKojeJeProdato";
            this.btnObrisiVoziloKojeJeProdato.Size = new System.Drawing.Size(154, 72);
            this.btnObrisiVoziloKojeJeProdato.TabIndex = 0;
            this.btnObrisiVoziloKojeJeProdato.Text = "Obrisi vozilo koje je prodato";
            this.btnObrisiVoziloKojeJeProdato.UseVisualStyleBackColor = true;
            this.btnObrisiVoziloKojeJeProdato.Click += new System.EventHandler(this.btnObrisiVoziloKojeJeProdato_Click);
            // 
            // btnObrisiVoziloKojeNijeProdato
            // 
            this.btnObrisiVoziloKojeNijeProdato.Location = new System.Drawing.Point(304, 197);
            this.btnObrisiVoziloKojeNijeProdato.Name = "btnObrisiVoziloKojeNijeProdato";
            this.btnObrisiVoziloKojeNijeProdato.Size = new System.Drawing.Size(154, 72);
            this.btnObrisiVoziloKojeNijeProdato.TabIndex = 1;
            this.btnObrisiVoziloKojeNijeProdato.Text = "Obrisi vozilo koje nije prodato";
            this.btnObrisiVoziloKojeNijeProdato.UseVisualStyleBackColor = true;
            this.btnObrisiVoziloKojeNijeProdato.Click += new System.EventHandler(this.btnObrisiVoziloKojeNijeProdato_Click);
            // 
            // ObrisiUvezenoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiVoziloKojeNijeProdato);
            this.Controls.Add(this.btnObrisiVoziloKojeJeProdato);
            this.Name = "ObrisiUvezenoVozilo";
            this.Text = "ObrisiUvezenoVozilo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiVoziloKojeJeProdato;
        private System.Windows.Forms.Button btnObrisiVoziloKojeNijeProdato;
    }
}
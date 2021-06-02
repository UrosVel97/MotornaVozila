
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObrisiVoziloKojeJeProdato
            // 
            this.btnObrisiVoziloKojeJeProdato.Location = new System.Drawing.Point(172, 180);
            this.btnObrisiVoziloKojeJeProdato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisiVoziloKojeJeProdato.Name = "btnObrisiVoziloKojeJeProdato";
            this.btnObrisiVoziloKojeJeProdato.Size = new System.Drawing.Size(116, 60);
            this.btnObrisiVoziloKojeJeProdato.TabIndex = 0;
            this.btnObrisiVoziloKojeJeProdato.Text = "Obrisi vozilo koje je prodato";
            this.btnObrisiVoziloKojeJeProdato.UseVisualStyleBackColor = true;
            this.btnObrisiVoziloKojeJeProdato.Click += new System.EventHandler(this.btnObrisiVoziloKojeJeProdato_Click);
            // 
            // btnObrisiVoziloKojeNijeProdato
            // 
            this.btnObrisiVoziloKojeNijeProdato.Location = new System.Drawing.Point(172, 100);
            this.btnObrisiVoziloKojeNijeProdato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisiVoziloKojeNijeProdato.Name = "btnObrisiVoziloKojeNijeProdato";
            this.btnObrisiVoziloKojeNijeProdato.Size = new System.Drawing.Size(116, 60);
            this.btnObrisiVoziloKojeNijeProdato.TabIndex = 1;
            this.btnObrisiVoziloKojeNijeProdato.Text = "Obrisi vozilo koje nije prodato";
            this.btnObrisiVoziloKojeNijeProdato.UseVisualStyleBackColor = true;
            this.btnObrisiVoziloKojeNijeProdato.Click += new System.EventHandler(this.btnObrisiVoziloKojeNijeProdato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 22);
            this.label1.TabIndex = 96;
            this.label1.Text = "Izaberite vozilo koje zelite da obrisete";
            // 
            // ObrisiUvezenoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiVoziloKojeNijeProdato);
            this.Controls.Add(this.btnObrisiVoziloKojeJeProdato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ObrisiUvezenoVozilo";
            this.Text = "ObrisiUvezenoVozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiVoziloKojeJeProdato;
        private System.Windows.Forms.Button btnObrisiVoziloKojeNijeProdato;
        private System.Windows.Forms.Label label1;
    }
}
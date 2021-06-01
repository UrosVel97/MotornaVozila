
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajVoziloKojeNijeProdato
            // 
            this.btnDodajVoziloKojeNijeProdato.Location = new System.Drawing.Point(130, 100);
            this.btnDodajVoziloKojeNijeProdato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajVoziloKojeNijeProdato.Name = "btnDodajVoziloKojeNijeProdato";
            this.btnDodajVoziloKojeNijeProdato.Size = new System.Drawing.Size(146, 70);
            this.btnDodajVoziloKojeNijeProdato.TabIndex = 0;
            this.btnDodajVoziloKojeNijeProdato.Text = "Dodaj vozilo koje nije prodato";
            this.btnDodajVoziloKojeNijeProdato.UseVisualStyleBackColor = true;
            this.btnDodajVoziloKojeNijeProdato.Click += new System.EventHandler(this.btnDodajVoziloKojeNijeProdato_Click);
            // 
            // btnDodajVoziloKojeJeProdato
            // 
            this.btnDodajVoziloKojeJeProdato.Location = new System.Drawing.Point(130, 200);
            this.btnDodajVoziloKojeJeProdato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajVoziloKojeJeProdato.Name = "btnDodajVoziloKojeJeProdato";
            this.btnDodajVoziloKojeJeProdato.Size = new System.Drawing.Size(146, 70);
            this.btnDodajVoziloKojeJeProdato.TabIndex = 1;
            this.btnDodajVoziloKojeJeProdato.Text = "Dodaj vozilo koje je prodato";
            this.btnDodajVoziloKojeJeProdato.UseVisualStyleBackColor = true;
            this.btnDodajVoziloKojeJeProdato.Click += new System.EventHandler(this.btnDodajVoziloKojeJeProdato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izaberite kakvo vozilo zelite da dodate";
            // 
            // DodajUvezenoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajVoziloKojeJeProdato);
            this.Controls.Add(this.btnDodajVoziloKojeNijeProdato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajUvezenoVozilo";
            this.Text = "DodajUvezenoVozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVoziloKojeNijeProdato;
        private System.Windows.Forms.Button btnDodajVoziloKojeJeProdato;
        private System.Windows.Forms.Label label2;
    }
}
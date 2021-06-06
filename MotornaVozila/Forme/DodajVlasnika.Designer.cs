
namespace MotornaVozila.Forme
{
    partial class DodajVlasnika
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
            this.btnDodajRegistrovanogKupca = new System.Windows.Forms.Button();
            this.btnDodajNeregistrovanogKupca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajRegistrovanogKupca
            // 
            this.btnDodajRegistrovanogKupca.Location = new System.Drawing.Point(120, 90);
            this.btnDodajRegistrovanogKupca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajRegistrovanogKupca.Name = "btnDodajRegistrovanogKupca";
            this.btnDodajRegistrovanogKupca.Size = new System.Drawing.Size(160, 80);
            this.btnDodajRegistrovanogKupca.TabIndex = 0;
            this.btnDodajRegistrovanogKupca.Text = "Dodaj registrovanog kupca";
            this.btnDodajRegistrovanogKupca.UseVisualStyleBackColor = true;
            this.btnDodajRegistrovanogKupca.Click += new System.EventHandler(this.btnDodajRegistrovanogKupca_Click);
            // 
            // btnDodajNeregistrovanogKupca
            // 
            this.btnDodajNeregistrovanogKupca.Location = new System.Drawing.Point(120, 210);
            this.btnDodajNeregistrovanogKupca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajNeregistrovanogKupca.Name = "btnDodajNeregistrovanogKupca";
            this.btnDodajNeregistrovanogKupca.Size = new System.Drawing.Size(160, 80);
            this.btnDodajNeregistrovanogKupca.TabIndex = 1;
            this.btnDodajNeregistrovanogKupca.Text = "Dodaj neregistrovanog kupca";
            this.btnDodajNeregistrovanogKupca.UseVisualStyleBackColor = true;
            this.btnDodajNeregistrovanogKupca.Click += new System.EventHandler(this.btnDodajNeregistrovanogKupca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(56, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Izaberite kakvog vlasnika zelite da dodate";
            // 
            // DodajVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajNeregistrovanogKupca);
            this.Controls.Add(this.btnDodajRegistrovanogKupca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajVlasnika";
            this.Text = "DodajVlasnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajRegistrovanogKupca;
        private System.Windows.Forms.Button btnDodajNeregistrovanogKupca;
        private System.Windows.Forms.Label label2;
    }
}
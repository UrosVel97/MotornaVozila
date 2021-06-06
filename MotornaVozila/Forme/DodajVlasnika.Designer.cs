
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
            this.SuspendLayout();
            // 
            // btnDodajRegistrovanogKupca
            // 
            this.btnDodajRegistrovanogKupca.Location = new System.Drawing.Point(178, 57);
            this.btnDodajRegistrovanogKupca.Name = "btnDodajRegistrovanogKupca";
            this.btnDodajRegistrovanogKupca.Size = new System.Drawing.Size(227, 109);
            this.btnDodajRegistrovanogKupca.TabIndex = 0;
            this.btnDodajRegistrovanogKupca.Text = "Dodaj registrovanog kupca";
            this.btnDodajRegistrovanogKupca.UseVisualStyleBackColor = true;
            this.btnDodajRegistrovanogKupca.Click += new System.EventHandler(this.btnDodajRegistrovanogKupca_Click);
            // 
            // btnDodajNeregistrovanogKupca
            // 
            this.btnDodajNeregistrovanogKupca.Location = new System.Drawing.Point(178, 211);
            this.btnDodajNeregistrovanogKupca.Name = "btnDodajNeregistrovanogKupca";
            this.btnDodajNeregistrovanogKupca.Size = new System.Drawing.Size(227, 109);
            this.btnDodajNeregistrovanogKupca.TabIndex = 1;
            this.btnDodajNeregistrovanogKupca.Text = "Dodaj neregistrovanog kupca";
            this.btnDodajNeregistrovanogKupca.UseVisualStyleBackColor = true;
            this.btnDodajNeregistrovanogKupca.Click += new System.EventHandler(this.btnDodajNeregistrovanogKupca_Click);
            // 
            // DodajVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 441);
            this.Controls.Add(this.btnDodajNeregistrovanogKupca);
            this.Controls.Add(this.btnDodajRegistrovanogKupca);
            this.Name = "DodajVlasnika";
            this.Text = "DodajVlasnika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajRegistrovanogKupca;
        private System.Windows.Forms.Button btnDodajNeregistrovanogKupca;
    }
}
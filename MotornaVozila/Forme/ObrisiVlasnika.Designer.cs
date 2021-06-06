
namespace MotornaVozila.Forme
{
    partial class ObrisiVlasnika
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
            this.btnObrisiRegisrovanog = new System.Windows.Forms.Button();
            this.btnObrisiNeregistrovanog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObrisiRegisrovanog
            // 
            this.btnObrisiRegisrovanog.Location = new System.Drawing.Point(235, 43);
            this.btnObrisiRegisrovanog.Name = "btnObrisiRegisrovanog";
            this.btnObrisiRegisrovanog.Size = new System.Drawing.Size(232, 134);
            this.btnObrisiRegisrovanog.TabIndex = 0;
            this.btnObrisiRegisrovanog.Text = "Obrisi registrovanog kupca";
            this.btnObrisiRegisrovanog.UseVisualStyleBackColor = true;
            this.btnObrisiRegisrovanog.Click += new System.EventHandler(this.btnObrisiRegisrovanog_Click);
            // 
            // btnObrisiNeregistrovanog
            // 
            this.btnObrisiNeregistrovanog.Location = new System.Drawing.Point(235, 196);
            this.btnObrisiNeregistrovanog.Name = "btnObrisiNeregistrovanog";
            this.btnObrisiNeregistrovanog.Size = new System.Drawing.Size(232, 140);
            this.btnObrisiNeregistrovanog.TabIndex = 1;
            this.btnObrisiNeregistrovanog.Text = "Obrisi neregistrovanog kupca";
            this.btnObrisiNeregistrovanog.UseVisualStyleBackColor = true;
            this.btnObrisiNeregistrovanog.Click += new System.EventHandler(this.btnObrisiNeregistrovanog_Click);
            // 
            // ObrisiVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiNeregistrovanog);
            this.Controls.Add(this.btnObrisiRegisrovanog);
            this.Name = "ObrisiVlasnika";
            this.Text = "ObrisiVlasnika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiRegisrovanog;
        private System.Windows.Forms.Button btnObrisiNeregistrovanog;
    }
}
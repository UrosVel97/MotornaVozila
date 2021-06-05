
namespace MotornaVozila.Forme
{
    partial class ModifikujVlasnika
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifikujRegistrovanogKupca = new System.Windows.Forms.Button();
            this.btnModifikujNeregistrovanogKupca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Izaberite vlasnika koga zelite da modifikujete";
            // 
            // btnModifikujRegistrovanogKupca
            // 
            this.btnModifikujRegistrovanogKupca.Location = new System.Drawing.Point(163, 214);
            this.btnModifikujRegistrovanogKupca.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifikujRegistrovanogKupca.Name = "btnModifikujRegistrovanogKupca";
            this.btnModifikujRegistrovanogKupca.Size = new System.Drawing.Size(155, 75);
            this.btnModifikujRegistrovanogKupca.TabIndex = 27;
            this.btnModifikujRegistrovanogKupca.Text = "Modifikuj registrovanog kupca";
            this.btnModifikujRegistrovanogKupca.UseVisualStyleBackColor = true;
            this.btnModifikujRegistrovanogKupca.Click += new System.EventHandler(this.btnModifikujRegistrovanogKupca_Click);
            // 
            // btnModifikujNeregistrovanogKupca
            // 
            this.btnModifikujNeregistrovanogKupca.Location = new System.Drawing.Point(163, 94);
            this.btnModifikujNeregistrovanogKupca.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifikujNeregistrovanogKupca.Name = "btnModifikujNeregistrovanogKupca";
            this.btnModifikujNeregistrovanogKupca.Size = new System.Drawing.Size(155, 75);
            this.btnModifikujNeregistrovanogKupca.TabIndex = 26;
            this.btnModifikujNeregistrovanogKupca.Text = "Modifikuj neregistrovanog kupca";
            this.btnModifikujNeregistrovanogKupca.UseVisualStyleBackColor = true;
            this.btnModifikujNeregistrovanogKupca.Click += new System.EventHandler(this.btnModifikujNeregistrovanogKupca_Click);
            // 
            // ModifikujVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModifikujRegistrovanogKupca);
            this.Controls.Add(this.btnModifikujNeregistrovanogKupca);
            this.Name = "ModifikujVlasnika";
            this.Text = "ModifikujVlasnika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifikujRegistrovanogKupca;
        private System.Windows.Forms.Button btnModifikujNeregistrovanogKupca;
    }
}
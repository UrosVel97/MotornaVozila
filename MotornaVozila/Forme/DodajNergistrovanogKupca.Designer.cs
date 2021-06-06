
namespace MotornaVozila.Forme
{
    partial class DodajNergistrovanogKupca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajBroj = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(147, 79);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(222, 22);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(147, 136);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(222, 22);
            this.txtPrezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(147, 278);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 84);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 84);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brojevi telefona";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(147, 223);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(222, 22);
            this.txtBroj.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 55);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodaj broj (Opciono)";
            // 
            // btnDodajBroj
            // 
            this.btnDodajBroj.Location = new System.Drawing.Point(418, 223);
            this.btnDodajBroj.Name = "btnDodajBroj";
            this.btnDodajBroj.Size = new System.Drawing.Size(135, 37);
            this.btnDodajBroj.TabIndex = 8;
            this.btnDodajBroj.Text = "Dodaj broj";
            this.btnDodajBroj.UseVisualStyleBackColor = true;
            this.btnDodajBroj.Click += new System.EventHandler(this.btnDodajBroj_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(253, 419);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(212, 111);
            this.btnSnimi.TabIndex = 9;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(667, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sva input polja moraju da imaju vrednost, osim onih polja gde pise \'Opciono\'";
            // 
            // DodajNergistrovanogKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnDodajBroj);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "DodajNergistrovanogKupca";
            this.Text = "DodajNergistrovanogKupca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajBroj;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label5;
    }
}

namespace MotornaVozila.Forme
{
    partial class DodajPravnoLice
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDodajBroj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(134, 70);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(163, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(134, 110);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(163, 20);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPib
            // 
            this.txtPib.Location = new System.Drawing.Point(134, 150);
            this.txtPib.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPib.Name = "txtPib";
            this.txtPib.Size = new System.Drawing.Size(163, 20);
            this.txtPib.TabIndex = 7;
            this.txtPib.TextChanged += new System.EventHandler(this.txtPib_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "PIB";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(134, 190);
            this.txtBroj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(163, 20);
            this.txtBroj.TabIndex = 9;
            this.txtBroj.TextChanged += new System.EventHandler(this.txtBroj_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 63);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj telefona (Opciono)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(134, 230);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 82);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnDodajBroj
            // 
            this.btnDodajBroj.Location = new System.Drawing.Point(312, 182);
            this.btnDodajBroj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajBroj.Name = "btnDodajBroj";
            this.btnDodajBroj.Size = new System.Drawing.Size(80, 34);
            this.btnDodajBroj.TabIndex = 11;
            this.btnDodajBroj.Text = "Dodaj broj";
            this.btnDodajBroj.UseVisualStyleBackColor = true;
            this.btnDodajBroj.Click += new System.EventHandler(this.btnDodajBroj_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(667, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sva input polja moraju imati vrednost, osim onih polja kod kojih stoji rec \'Opcio" +
    "no\'";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(265, 339);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(127, 60);
            this.btnSnimi.TabIndex = 13;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // DodajPravnoLice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 434);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajBroj);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajPravnoLice";
            this.Text = "DodajPravnoLice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDodajBroj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSnimi;
    }
}
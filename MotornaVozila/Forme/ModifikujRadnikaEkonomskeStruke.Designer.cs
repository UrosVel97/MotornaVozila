
namespace MotornaVozila.Forme
{
    partial class ModifikujRadnikaEkonomskeStruke
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
            this.columnDatumZaposlenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dtDatumIstekaUgovora = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtStrucnaSprema = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnDatumZaposlenja
            // 
            this.columnDatumZaposlenja.Text = "Datum zaposlenja";
            this.columnDatumZaposlenja.Width = 321;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 158;
            // 
            // columnJmbg
            // 
            this.columnJmbg.Text = "JMBG";
            this.columnJmbg.Width = 126;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnJmbg,
            this.columnIme,
            this.columnPrezime,
            this.columnDatumZaposlenja});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 69);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(805, 188);
            this.listView2.TabIndex = 96;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "Izaberite radnika iz liste koga zelite da modifikujete";
            // 
            // dtDatumIstekaUgovora
            // 
            this.dtDatumIstekaUgovora.Location = new System.Drawing.Point(416, 561);
            this.dtDatumIstekaUgovora.Name = "dtDatumIstekaUgovora";
            this.dtDatumIstekaUgovora.Size = new System.Drawing.Size(200, 22);
            this.dtDatumIstekaUgovora.TabIndex = 89;
            this.dtDatumIstekaUgovora.ValueChanged += new System.EventHandler(this.dtDatumIstekaUgovora_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 18);
            this.label11.TabIndex = 88;
            this.label11.Text = "Datum isteka ugovora";
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(459, 512);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(201, 22);
            this.txtPlata.TabIndex = 87;
            this.txtPlata.TextChanged += new System.EventHandler(this.txtPlata_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 18);
            this.label10.TabIndex = 86;
            this.label10.Text = "Plata";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 81);
            this.label9.TabIndex = 85;
            this.label9.Text = "Da li je radnik zaposlen za stalno ili zaposlen po ugovoru?";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(192, 538);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(169, 22);
            this.radioButton3.TabIndex = 84;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Zaposlen po ugovoru";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(192, 512);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(154, 22);
            this.radioButton2.TabIndex = 83;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Zaposlen za stalno";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(205, 397);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(201, 22);
            this.txtPrezime.TabIndex = 82;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(205, 343);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(201, 22);
            this.txtIme.TabIndex = 80;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Ime";
            // 
            // txtJmbg
            // 
            this.txtJmbg.Location = new System.Drawing.Point(205, 295);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.ReadOnly = true;
            this.txtJmbg.Size = new System.Drawing.Size(201, 22);
            this.txtJmbg.TabIndex = 78;
            this.txtJmbg.TextChanged += new System.EventHandler(this.txtJmbg_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "JMBG";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(256, 665);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(257, 77);
            this.btnSnimi.TabIndex = 76;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtStrucnaSprema
            // 
            this.txtStrucnaSprema.Location = new System.Drawing.Point(205, 444);
            this.txtStrucnaSprema.Name = "txtStrucnaSprema";
            this.txtStrucnaSprema.Size = new System.Drawing.Size(201, 22);
            this.txtStrucnaSprema.TabIndex = 97;
            this.txtStrucnaSprema.TextChanged += new System.EventHandler(this.txtStrucnaSprema_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "Strucna sprema";
            // 
            // ModifikujRadnikaEkonomskeStruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 752);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStrucnaSprema);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDatumIstekaUgovora);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPlata);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJmbg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSnimi);
            this.Name = "ModifikujRadnikaEkonomskeStruke";
            this.Text = "ModifikujRadnikaEkonomskeStruke";
            this.Load += new System.EventHandler(this.ModifikujRadnikaEkonomskeStruke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnDatumZaposlenja;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnJmbg;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDatumIstekaUgovora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtStrucnaSprema;
        private System.Windows.Forms.Label label5;
    }
}
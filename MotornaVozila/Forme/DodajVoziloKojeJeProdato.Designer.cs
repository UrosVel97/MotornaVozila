
namespace MotornaVozila.Forme
{
    partial class DodajVoziloKojeJeProdato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajVoziloKojeJeProdato));
            this.btnDodajBoju = new System.Windows.Forms.Button();
            this.columnIdKupovine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumKupovine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.txtUnesiBoju = new System.Windows.Forms.TextBox();
            this.listBoxBoje = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtDatumUvoza = new System.Windows.Forms.DateTimePicker();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtTipProstora = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNosivost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrojPutnika = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkTeretno = new System.Windows.Forms.CheckBox();
            this.checkPutnicko = new System.Windows.Forms.CheckBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKubikaza = new System.Windows.Forms.TextBox();
            this.labelKubikaza = new System.Windows.Forms.Label();
            this.txtTipGoriva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojMotora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajBoju
            // 
            this.btnDodajBoju.Location = new System.Drawing.Point(318, 569);
            this.btnDodajBoju.Name = "btnDodajBoju";
            this.btnDodajBoju.Size = new System.Drawing.Size(101, 33);
            this.btnDodajBoju.TabIndex = 62;
            this.btnDodajBoju.Text = "Dodaj boju";
            this.btnDodajBoju.UseVisualStyleBackColor = true;
            this.btnDodajBoju.Click += new System.EventHandler(this.btnDodajBoju_Click);
            // 
            // columnIdKupovine
            // 
            this.columnIdKupovine.Text = "Id";
            this.columnIdKupovine.Width = 84;
            // 
            // columnDatumKupovine
            // 
            this.columnDatumKupovine.Text = "Datum kupovine";
            this.columnDatumKupovine.Width = 317;
            // 
            // columnJmbg
            // 
            this.columnJmbg.Text = "JMBG";
            this.columnJmbg.Width = 108;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 119;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-4, 574);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Unesite boju vozila";
            // 
            // txtUnesiBoju
            // 
            this.txtUnesiBoju.Location = new System.Drawing.Point(129, 574);
            this.txtUnesiBoju.Name = "txtUnesiBoju";
            this.txtUnesiBoju.Size = new System.Drawing.Size(169, 22);
            this.txtUnesiBoju.TabIndex = 60;
            // 
            // listBoxBoje
            // 
            this.listBoxBoje.FormattingEnabled = true;
            this.listBoxBoje.ItemHeight = 16;
            this.listBoxBoje.Location = new System.Drawing.Point(127, 624);
            this.listBoxBoje.Name = "listBoxBoje";
            this.listBoxBoje.Size = new System.Drawing.Size(171, 84);
            this.listBoxBoje.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "Datum uvoza";
            // 
            // dtDatumUvoza
            // 
            this.dtDatumUvoza.Location = new System.Drawing.Point(127, 327);
            this.dtDatumUvoza.Name = "dtDatumUvoza";
            this.dtDatumUvoza.Size = new System.Drawing.Size(161, 22);
            this.dtDatumUvoza.TabIndex = 57;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnJmbg,
            this.columnIme,
            this.columnPrezime});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(445, 356);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(411, 188);
            this.listView2.TabIndex = 56;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 179;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(821, 95);
            this.label10.TabIndex = 54;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdKupovine,
            this.columnDatumKupovine});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(445, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 188);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(315, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 84);
            this.label9.TabIndex = 52;
            this.label9.Text = "Izaberite kupovinu kojoj je vozilo pridruzeno";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(544, 624);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(202, 86);
            this.btnSnimi.TabIndex = 51;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtTipProstora
            // 
            this.txtTipProstora.Location = new System.Drawing.Point(127, 504);
            this.txtTipProstora.Name = "txtTipProstora";
            this.txtTipProstora.Size = new System.Drawing.Size(124, 22);
            this.txtTipProstora.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(315, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 91);
            this.label11.TabIndex = 55;
            this.label11.Text = "Izaberite radnika tehnicke struke koji je izvrsio prijem vozila";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tip prostora";
            // 
            // txtNosivost
            // 
            this.txtNosivost.Location = new System.Drawing.Point(127, 476);
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.Size = new System.Drawing.Size(124, 22);
            this.txtNosivost.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nosivost";
            // 
            // txtBrojPutnika
            // 
            this.txtBrojPutnika.Location = new System.Drawing.Point(127, 448);
            this.txtBrojPutnika.Name = "txtBrojPutnika";
            this.txtBrojPutnika.Size = new System.Drawing.Size(124, 22);
            this.txtBrojPutnika.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Broj putnika";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 95);
            this.label5.TabIndex = 44;
            this.label5.Text = "Da li je vozilo putnicko ili teretno ili oba?";
            // 
            // checkTeretno
            // 
            this.checkTeretno.AutoSize = true;
            this.checkTeretno.Location = new System.Drawing.Point(127, 402);
            this.checkTeretno.Name = "checkTeretno";
            this.checkTeretno.Size = new System.Drawing.Size(120, 21);
            this.checkTeretno.TabIndex = 43;
            this.checkTeretno.Text = "Teretno vozilo";
            this.checkTeretno.UseVisualStyleBackColor = true;
            this.checkTeretno.CheckedChanged += new System.EventHandler(this.checkTeretno_CheckedChanged);
            // 
            // checkPutnicko
            // 
            this.checkPutnicko.AutoSize = true;
            this.checkPutnicko.Location = new System.Drawing.Point(127, 375);
            this.checkPutnicko.Name = "checkPutnicko";
            this.checkPutnicko.Size = new System.Drawing.Size(124, 21);
            this.checkPutnicko.TabIndex = 42;
            this.checkPutnicko.Text = "Putnicko vozilo";
            this.checkPutnicko.UseVisualStyleBackColor = true;
            this.checkPutnicko.CheckedChanged += new System.EventHandler(this.checkPutnicko_CheckedChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(127, 294);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(124, 22);
            this.txtModel.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Model";
            // 
            // txtKubikaza
            // 
            this.txtKubikaza.Location = new System.Drawing.Point(129, 258);
            this.txtKubikaza.Name = "txtKubikaza";
            this.txtKubikaza.Size = new System.Drawing.Size(124, 22);
            this.txtKubikaza.TabIndex = 39;
            // 
            // labelKubikaza
            // 
            this.labelKubikaza.AutoSize = true;
            this.labelKubikaza.Location = new System.Drawing.Point(9, 258);
            this.labelKubikaza.Name = "labelKubikaza";
            this.labelKubikaza.Size = new System.Drawing.Size(66, 17);
            this.labelKubikaza.TabIndex = 38;
            this.labelKubikaza.Text = "Kubikaza";
            // 
            // txtTipGoriva
            // 
            this.txtTipGoriva.Location = new System.Drawing.Point(127, 211);
            this.txtTipGoriva.Name = "txtTipGoriva";
            this.txtTipGoriva.Size = new System.Drawing.Size(124, 22);
            this.txtTipGoriva.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tip goriva";
            // 
            // txtBrojMotora
            // 
            this.txtBrojMotora.Location = new System.Drawing.Point(127, 170);
            this.txtBrojMotora.Name = "txtBrojMotora";
            this.txtBrojMotora.Size = new System.Drawing.Size(124, 22);
            this.txtBrojMotora.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Broj motora";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(127, 126);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(124, 22);
            this.txtBrojSasije.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Broj sasije";
            // 
            // DodajVoziloKojeJeProdato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 728);
            this.Controls.Add(this.btnDodajBoju);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUnesiBoju);
            this.Controls.Add(this.listBoxBoje);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtDatumUvoza);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtTipProstora);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBrojPutnika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkTeretno);
            this.Controls.Add(this.checkPutnicko);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKubikaza);
            this.Controls.Add(this.labelKubikaza);
            this.Controls.Add(this.txtTipGoriva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojMotora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojSasije);
            this.Controls.Add(this.label1);
            this.Name = "DodajVoziloKojeJeProdato";
            this.Text = "DodajVoziloKojeJeProdato";
            this.Load += new System.EventHandler(this.DodajVoziloKojeJeProdato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajBoju;
        private System.Windows.Forms.ColumnHeader columnIdKupovine;
        private System.Windows.Forms.ColumnHeader columnDatumKupovine;
        private System.Windows.Forms.ColumnHeader columnJmbg;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUnesiBoju;
        private System.Windows.Forms.ListBox listBoxBoje;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtDatumUvoza;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtTipProstora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNosivost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrojPutnika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkTeretno;
        private System.Windows.Forms.CheckBox checkPutnicko;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKubikaza;
        private System.Windows.Forms.Label labelKubikaza;
        private System.Windows.Forms.TextBox txtTipGoriva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojMotora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label label1;
    }
}
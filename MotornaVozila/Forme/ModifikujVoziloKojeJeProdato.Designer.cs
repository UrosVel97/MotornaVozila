
namespace MotornaVozila.Forme
{
    partial class ModifikujVoziloKojeJeProdato
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
            this.columnTipGoriva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrojMotora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrojSasije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxBojeVozila = new System.Windows.Forms.ListBox();
            this.btnDodajBoju = new System.Windows.Forms.Button();
            this.txtBojaVozila = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBrojPutnika = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojMotora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipGoriva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKubikaza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNosivost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipProstora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.checkBoxTeretno = new System.Windows.Forms.CheckBox();
            this.checkBoxPutnicko = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // columnTipGoriva
            // 
            this.columnTipGoriva.Text = "Tip goriva";
            this.columnTipGoriva.Width = 321;
            // 
            // columnBrojMotora
            // 
            this.columnBrojMotora.Text = "Broj motora";
            this.columnBrojMotora.Width = 158;
            // 
            // columnBrojSasije
            // 
            this.columnBrojSasije.Text = "Broj sasije";
            this.columnBrojSasije.Width = 126;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBrojSasije,
            this.columnBrojMotora,
            this.columnModel,
            this.columnTipGoriva});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(26, 66);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1131, 188);
            this.listView2.TabIndex = 96;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnModel
            // 
            this.columnModel.Text = "Model";
            this.columnModel.Width = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "Izaberite vozilo koje zelite da modifikujete";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(528, 496);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 48);
            this.label13.TabIndex = 94;
            this.label13.Text = "Lista boja vozila";
            // 
            // listBoxBojeVozila
            // 
            this.listBoxBojeVozila.FormattingEnabled = true;
            this.listBoxBojeVozila.ItemHeight = 16;
            this.listBoxBojeVozila.Location = new System.Drawing.Point(702, 496);
            this.listBoxBojeVozila.Name = "listBoxBojeVozila";
            this.listBoxBojeVozila.Size = new System.Drawing.Size(224, 84);
            this.listBoxBojeVozila.TabIndex = 93;
            // 
            // btnDodajBoju
            // 
            this.btnDodajBoju.Location = new System.Drawing.Point(993, 429);
            this.btnDodajBoju.Name = "btnDodajBoju";
            this.btnDodajBoju.Size = new System.Drawing.Size(133, 36);
            this.btnDodajBoju.TabIndex = 92;
            this.btnDodajBoju.Text = "Dodaj boju";
            this.btnDodajBoju.UseVisualStyleBackColor = true;
            this.btnDodajBoju.Click += new System.EventHandler(this.btnDodajBoju_Click);
            // 
            // txtBojaVozila
            // 
            this.txtBojaVozila.Location = new System.Drawing.Point(702, 436);
            this.txtBojaVozila.Name = "txtBojaVozila";
            this.txtBojaVozila.Size = new System.Drawing.Size(224, 22);
            this.txtBojaVozila.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(528, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 90;
            this.label12.Text = "Boja vozila";
            // 
            // txtBrojPutnika
            // 
            this.txtBrojPutnika.Location = new System.Drawing.Point(970, 381);
            this.txtBrojPutnika.Name = "txtBrojPutnika";
            this.txtBrojPutnika.Size = new System.Drawing.Size(201, 22);
            this.txtBrojPutnika.TabIndex = 87;
            this.txtBrojPutnika.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(866, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 86;
            this.label10.Text = "Broj putnika";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(528, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 71);
            this.label9.TabIndex = 85;
            this.label9.Text = "Da li je vozilo putnicko ili teretno?";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(219, 394);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(201, 22);
            this.txtModel.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Model";
            // 
            // txtBrojMotora
            // 
            this.txtBrojMotora.Location = new System.Drawing.Point(219, 340);
            this.txtBrojMotora.Name = "txtBrojMotora";
            this.txtBrojMotora.ReadOnly = true;
            this.txtBrojMotora.Size = new System.Drawing.Size(201, 22);
            this.txtBrojMotora.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Broj motora";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(219, 292);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.ReadOnly = true;
            this.txtBrojSasije.Size = new System.Drawing.Size(201, 22);
            this.txtBrojSasije.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Broj sasije";
            // 
            // txtTipGoriva
            // 
            this.txtTipGoriva.Location = new System.Drawing.Point(219, 443);
            this.txtTipGoriva.Name = "txtTipGoriva";
            this.txtTipGoriva.Size = new System.Drawing.Size(201, 22);
            this.txtTipGoriva.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "Tip goriva";
            // 
            // txtKubikaza
            // 
            this.txtKubikaza.Location = new System.Drawing.Point(219, 491);
            this.txtKubikaza.Name = "txtKubikaza";
            this.txtKubikaza.Size = new System.Drawing.Size(201, 22);
            this.txtKubikaza.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 99;
            this.label6.Text = "Kubikaza";
            // 
            // txtNosivost
            // 
            this.txtNosivost.Location = new System.Drawing.Point(970, 304);
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.Size = new System.Drawing.Size(201, 22);
            this.txtNosivost.TabIndex = 102;
            this.txtNosivost.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(866, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 101;
            this.label7.Text = "Nosivost";
            this.label7.Visible = false;
            // 
            // txtTipProstora
            // 
            this.txtTipProstora.Location = new System.Drawing.Point(970, 342);
            this.txtTipProstora.Name = "txtTipProstora";
            this.txtTipProstora.Size = new System.Drawing.Size(201, 22);
            this.txtTipProstora.TabIndex = 104;
            this.txtTipProstora.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(866, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 103;
            this.label8.Text = "Tip prostora";
            this.label8.Visible = false;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(481, 593);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(188, 56);
            this.btnSnimi.TabIndex = 105;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // checkBoxTeretno
            // 
            this.checkBoxTeretno.AutoSize = true;
            this.checkBoxTeretno.Location = new System.Drawing.Point(692, 306);
            this.checkBoxTeretno.Name = "checkBoxTeretno";
            this.checkBoxTeretno.Size = new System.Drawing.Size(120, 21);
            this.checkBoxTeretno.TabIndex = 106;
            this.checkBoxTeretno.Text = "Teretno vozilo";
            this.checkBoxTeretno.UseVisualStyleBackColor = true;
            this.checkBoxTeretno.CheckedChanged += new System.EventHandler(this.checkBoxTeretno_CheckedChanged);
            // 
            // checkBoxPutnicko
            // 
            this.checkBoxPutnicko.AutoSize = true;
            this.checkBoxPutnicko.Location = new System.Drawing.Point(692, 342);
            this.checkBoxPutnicko.Name = "checkBoxPutnicko";
            this.checkBoxPutnicko.Size = new System.Drawing.Size(124, 21);
            this.checkBoxPutnicko.TabIndex = 107;
            this.checkBoxPutnicko.Text = "Putnicko vozilo";
            this.checkBoxPutnicko.UseVisualStyleBackColor = true;
            this.checkBoxPutnicko.CheckedChanged += new System.EventHandler(this.checkBoxPutnicko_CheckedChanged);
            // 
            // ModifikujVoziloKojeJeProdato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 677);
            this.Controls.Add(this.checkBoxPutnicko);
            this.Controls.Add(this.checkBoxTeretno);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtTipProstora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKubikaza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipGoriva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBoxBojeVozila);
            this.Controls.Add(this.btnDodajBoju);
            this.Controls.Add(this.txtBojaVozila);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBrojPutnika);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojMotora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojSasije);
            this.Controls.Add(this.label2);
            this.Name = "ModifikujVoziloKojeJeProdato";
            this.Text = "ModifikujVoziloKojeJeProdato";
            this.Load += new System.EventHandler(this.ModifikujVoziloKojeJeProdato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnTipGoriva;
        private System.Windows.Forms.ColumnHeader columnBrojMotora;
        private System.Windows.Forms.ColumnHeader columnBrojSasije;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxBojeVozila;
        private System.Windows.Forms.Button btnDodajBoju;
        private System.Windows.Forms.TextBox txtBojaVozila;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBrojPutnika;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojMotora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipGoriva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKubikaza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNosivost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipProstora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.CheckBox checkBoxTeretno;
        private System.Windows.Forms.CheckBox checkBoxPutnicko;
    }
}
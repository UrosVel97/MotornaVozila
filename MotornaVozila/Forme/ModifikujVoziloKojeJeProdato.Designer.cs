
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
            this.listView2.Location = new System.Drawing.Point(20, 54);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(849, 154);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Izaberite vozilo koje zelite da modifikujete";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(374, 371);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 39);
            this.label13.TabIndex = 94;
            this.label13.Text = "Lista boja vozila";
            // 
            // listBoxBojeVozila
            // 
            this.listBoxBojeVozila.FormattingEnabled = true;
            this.listBoxBojeVozila.Location = new System.Drawing.Point(473, 371);
            this.listBoxBojeVozila.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBojeVozila.Name = "listBoxBojeVozila";
            this.listBoxBojeVozila.Size = new System.Drawing.Size(169, 69);
            this.listBoxBojeVozila.TabIndex = 93;
            // 
            // btnDodajBoju
            // 
            this.btnDodajBoju.Location = new System.Drawing.Point(660, 330);
            this.btnDodajBoju.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajBoju.Name = "btnDodajBoju";
            this.btnDodajBoju.Size = new System.Drawing.Size(100, 29);
            this.btnDodajBoju.TabIndex = 92;
            this.btnDodajBoju.Text = "Dodaj boju";
            this.btnDodajBoju.UseVisualStyleBackColor = true;
            this.btnDodajBoju.Click += new System.EventHandler(this.btnDodajBoju_Click);
            // 
            // txtBojaVozila
            // 
            this.txtBojaVozila.Location = new System.Drawing.Point(473, 335);
            this.txtBojaVozila.Margin = new System.Windows.Forms.Padding(2);
            this.txtBojaVozila.Name = "txtBojaVozila";
            this.txtBojaVozila.Size = new System.Drawing.Size(169, 20);
            this.txtBojaVozila.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(374, 335);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 90;
            this.label12.Text = "Boja vozila";
            // 
            // txtBrojPutnika
            // 
            this.txtBrojPutnika.Location = new System.Drawing.Point(717, 290);
            this.txtBrojPutnika.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojPutnika.Name = "txtBrojPutnika";
            this.txtBrojPutnika.Size = new System.Drawing.Size(152, 20);
            this.txtBrojPutnika.TabIndex = 87;
            this.txtBrojPutnika.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(631, 290);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 86;
            this.label10.Text = "Broj putnika";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 58);
            this.label9.TabIndex = 85;
            this.label9.Text = "Da li je vozilo putnicko ili teretno?";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(130, 310);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(152, 20);
            this.txtModel.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 81;
            this.label4.Text = "Model";
            // 
            // txtBrojMotora
            // 
            this.txtBrojMotora.Location = new System.Drawing.Point(130, 270);
            this.txtBrojMotora.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojMotora.Name = "txtBrojMotora";
            this.txtBrojMotora.ReadOnly = true;
            this.txtBrojMotora.Size = new System.Drawing.Size(152, 20);
            this.txtBrojMotora.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "Broj motora";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(130, 230);
            this.txtBrojSasije.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.ReadOnly = true;
            this.txtBrojSasije.Size = new System.Drawing.Size(152, 20);
            this.txtBrojSasije.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Broj sasije";
            // 
            // txtTipGoriva
            // 
            this.txtTipGoriva.Location = new System.Drawing.Point(130, 350);
            this.txtTipGoriva.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipGoriva.Name = "txtTipGoriva";
            this.txtTipGoriva.Size = new System.Drawing.Size(152, 20);
            this.txtTipGoriva.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 97;
            this.label5.Text = "Tip goriva";
            // 
            // txtKubikaza
            // 
            this.txtKubikaza.Location = new System.Drawing.Point(130, 390);
            this.txtKubikaza.Margin = new System.Windows.Forms.Padding(2);
            this.txtKubikaza.Name = "txtKubikaza";
            this.txtKubikaza.Size = new System.Drawing.Size(152, 20);
            this.txtKubikaza.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Kubikaza";
            // 
            // txtNosivost
            // 
            this.txtNosivost.Location = new System.Drawing.Point(717, 230);
            this.txtNosivost.Margin = new System.Windows.Forms.Padding(2);
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.Size = new System.Drawing.Size(152, 20);
            this.txtNosivost.TabIndex = 102;
            this.txtNosivost.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(631, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 101;
            this.label7.Text = "Nosivost";
            this.label7.Visible = false;
            // 
            // txtTipProstora
            // 
            this.txtTipProstora.Location = new System.Drawing.Point(717, 260);
            this.txtTipProstora.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipProstora.Name = "txtTipProstora";
            this.txtTipProstora.Size = new System.Drawing.Size(152, 20);
            this.txtTipProstora.TabIndex = 104;
            this.txtTipProstora.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(631, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 103;
            this.label8.Text = "Tip prostora";
            this.label8.Visible = false;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(339, 454);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(141, 46);
            this.btnSnimi.TabIndex = 105;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // checkBoxTeretno
            // 
            this.checkBoxTeretno.AutoSize = true;
            this.checkBoxTeretno.Location = new System.Drawing.Point(494, 231);
            this.checkBoxTeretno.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTeretno.Name = "checkBoxTeretno";
            this.checkBoxTeretno.Size = new System.Drawing.Size(93, 17);
            this.checkBoxTeretno.TabIndex = 106;
            this.checkBoxTeretno.Text = "Teretno vozilo";
            this.checkBoxTeretno.UseVisualStyleBackColor = true;
            this.checkBoxTeretno.CheckedChanged += new System.EventHandler(this.checkBoxTeretno_CheckedChanged);
            // 
            // checkBoxPutnicko
            // 
            this.checkBoxPutnicko.AutoSize = true;
            this.checkBoxPutnicko.Location = new System.Drawing.Point(494, 265);
            this.checkBoxPutnicko.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPutnicko.Name = "checkBoxPutnicko";
            this.checkBoxPutnicko.Size = new System.Drawing.Size(98, 17);
            this.checkBoxPutnicko.TabIndex = 107;
            this.checkBoxPutnicko.Text = "Putnicko vozilo";
            this.checkBoxPutnicko.UseVisualStyleBackColor = true;
            this.checkBoxPutnicko.CheckedChanged += new System.EventHandler(this.checkBoxPutnicko_CheckedChanged);
            // 
            // ModifikujVoziloKojeJeProdato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 520);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
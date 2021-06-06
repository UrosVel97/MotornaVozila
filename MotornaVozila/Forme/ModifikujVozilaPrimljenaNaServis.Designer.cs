
namespace MotornaVozila.Forme
{
    partial class ModifikujVozilaPrimljenaNaServis
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
            this.columnGodinaProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRegistarskiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnDatumPrijema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelVozila = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegistarskiBroj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumPrijema = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtOpisProblema = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnGodinaProizvodnje
            // 
            this.columnGodinaProizvodnje.Text = "Godina proizvodnje";
            this.columnGodinaProizvodnje.Width = 134;
            // 
            // columnModel
            // 
            this.columnModel.Text = "Model vozila";
            this.columnModel.Width = 107;
            // 
            // columnRegistarskiBroj
            // 
            this.columnRegistarskiBroj.Text = "Registarski broj";
            this.columnRegistarskiBroj.Width = 119;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRegistarskiBroj,
            this.columnModel,
            this.columnGodinaProizvodnje,
            this.columnDatumPrijema,
            this.columnProblem});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(10, 50);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(692, 123);
            this.listView2.TabIndex = 85;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnDatumPrijema
            // 
            this.columnDatumPrijema.Text = "Datum prijema";
            this.columnDatumPrijema.Width = 129;
            // 
            // columnProblem
            // 
            this.columnProblem.Text = "Opis problema";
            this.columnProblem.Width = 154;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 27);
            this.label1.TabIndex = 84;
            this.label1.Text = "Izaberite vozilo primljeno na servis koje zelite da modifikujete";
            // 
            // txtModelVozila
            // 
            this.txtModelVozila.Location = new System.Drawing.Point(125, 240);
            this.txtModelVozila.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelVozila.Name = "txtModelVozila";
            this.txtModelVozila.Size = new System.Drawing.Size(187, 20);
            this.txtModelVozila.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Model vozila";
            // 
            // txtRegistarskiBroj
            // 
            this.txtRegistarskiBroj.Location = new System.Drawing.Point(125, 200);
            this.txtRegistarskiBroj.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistarskiBroj.Name = "txtRegistarskiBroj";
            this.txtRegistarskiBroj.ReadOnly = true;
            this.txtRegistarskiBroj.Size = new System.Drawing.Size(187, 20);
            this.txtRegistarskiBroj.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Registarski broj";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(321, 400);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(116, 43);
            this.btnSnimi.TabIndex = 79;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Godina proizvodnje";
            // 
            // dateTimePickerDatumPrijema
            // 
            this.dateTimePickerDatumPrijema.Location = new System.Drawing.Point(125, 320);
            this.dateTimePickerDatumPrijema.Name = "dateTimePickerDatumPrijema";
            this.dateTimePickerDatumPrijema.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerDatumPrijema.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Datum prijema";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(125, 280);
            this.txtGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(2);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(187, 20);
            this.txtGodinaProizvodnje.TabIndex = 89;
            // 
            // txtOpisProblema
            // 
            this.txtOpisProblema.Location = new System.Drawing.Point(125, 360);
            this.txtOpisProblema.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpisProblema.Name = "txtOpisProblema";
            this.txtOpisProblema.Size = new System.Drawing.Size(187, 20);
            this.txtOpisProblema.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Opis problema";
            // 
            // ModifikujVozilaPrimljenaNaServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 469);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOpisProblema);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDatumPrijema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelVozila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegistarskiBroj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSnimi);
            this.Name = "ModifikujVozilaPrimljenaNaServis";
            this.Text = "ModifikujVozilaPrimljenaNaServis";
            this.Load += new System.EventHandler(this.ModifikujVozilaPrimljenaNaServis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnGodinaProizvodnje;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.ColumnHeader columnRegistarskiBroj;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelVozila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegistarskiBroj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ColumnHeader columnDatumPrijema;
        private System.Windows.Forms.ColumnHeader columnProblem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPrijema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtOpisProblema;
        private System.Windows.Forms.Label label6;
    }
}
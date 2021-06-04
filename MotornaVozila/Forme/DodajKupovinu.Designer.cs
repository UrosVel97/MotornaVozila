
namespace MotornaVozila.Forme
{
    partial class DodajKupovinu
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
            this.dtDatumKupovine = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnIdSalona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kog datuma je izvrsena kupovina";
            // 
            // dtDatumKupovine
            // 
            this.dtDatumKupovine.Location = new System.Drawing.Point(140, 29);
            this.dtDatumKupovine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtDatumKupovine.Name = "dtDatumKupovine";
            this.dtDatumKupovine.Size = new System.Drawing.Size(182, 20);
            this.dtDatumKupovine.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnIme,
            this.columnPrezime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(140, 103);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 134);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 75;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 131;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 122;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite kupca koji je izvrsio kupovinu";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izaberite salon u kome je izvrsena kupovina";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdSalona,
            this.columnGrad,
            this.columnAdresa});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(140, 271);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(371, 134);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnIdSalona
            // 
            this.columnIdSalona.Text = "Id";
            this.columnIdSalona.Width = 101;
            // 
            // columnGrad
            // 
            this.columnGrad.Text = "Grad";
            this.columnGrad.Width = 125;
            // 
            // columnAdresa
            // 
            this.columnAdresa.Text = "Adresa";
            this.columnAdresa.Width = 138;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(221, 431);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(116, 50);
            this.btnSnimi.TabIndex = 6;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // DodajKupovinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 493);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtDatumKupovine);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajKupovinu";
            this.Text = "DodajKupovinu";
            this.Load += new System.EventHandler(this.DodajKupovinu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDatumKupovine;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnIdSalona;
        private System.Windows.Forms.ColumnHeader columnGrad;
        private System.Windows.Forms.ColumnHeader columnAdresa;
        private System.Windows.Forms.Button btnSnimi;
    }
}
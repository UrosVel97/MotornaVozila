
namespace MotornaVozila.Forme
{
    partial class ObrisiKupovinu
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnDatum});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(165, 30);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(415, 134);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 124;
            // 
            // columnDatum
            // 
            this.columnDatum.Text = "Datum kupovine";
            this.columnDatum.Width = 267;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izaberite kupovinu koju zelite da izbrisete";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(210, 192);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(117, 51);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // ObrisiKupovinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 286);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ObrisiKupovinu";
            this.Text = "ObrisiKupovinu";
            this.Load += new System.EventHandler(this.ObrisiKupovinu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
    }
}
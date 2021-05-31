
namespace MotornaVozila.Forme
{
    partial class ObrisiVoziloKojeJeProdato
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnBrojSasije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrojMotora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipGoriva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(337, 348);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(188, 56);
            this.btnObrisi.TabIndex = 132;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBrojSasije,
            this.columnBrojMotora,
            this.columnModel,
            this.columnTipGoriva});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(23, 82);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(878, 188);
            this.listView2.TabIndex = 123;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnBrojSasije
            // 
            this.columnBrojSasije.Text = "Broj sasije";
            this.columnBrojSasije.Width = 126;
            // 
            // columnBrojMotora
            // 
            this.columnBrojMotora.Text = "Broj motora";
            this.columnBrojMotora.Width = 158;
            // 
            // columnModel
            // 
            this.columnModel.Text = "Model";
            this.columnModel.Width = 197;
            // 
            // columnTipGoriva
            // 
            this.columnTipGoriva.Text = "Tip goriva";
            this.columnTipGoriva.Width = 321;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 122;
            this.label1.Text = "Izaberite vozilo koje zelite da obrisete";
            // 
            // ObrisiVoziloKojeJeProdato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 498);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Name = "ObrisiVoziloKojeJeProdato";
            this.Text = "ObrisiVoziloKojeJeProdato";
            this.Load += new System.EventHandler(this.ObrisiVoziloKojeJeProdato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnBrojSasije;
        private System.Windows.Forms.ColumnHeader columnBrojMotora;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.ColumnHeader columnTipGoriva;
        private System.Windows.Forms.Label label1;
    }
}
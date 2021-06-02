
namespace MotornaVozila.Forme
{
    partial class ObrisiVoziloKojeNijeProdato
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
            this.btnObrisi.Location = new System.Drawing.Point(261, 249);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(141, 46);
            this.btnObrisi.TabIndex = 135;
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
            this.listView2.Location = new System.Drawing.Point(20, 62);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(621, 154);
            this.listView2.TabIndex = 134;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnBrojSasije
            // 
            this.columnBrojSasije.Text = "Broj sasije";
            this.columnBrojSasije.Width = 109;
            // 
            // columnBrojMotora
            // 
            this.columnBrojMotora.Text = "Broj motora";
            this.columnBrojMotora.Width = 148;
            // 
            // columnModel
            // 
            this.columnModel.Text = "Model";
            this.columnModel.Width = 153;
            // 
            // columnTipGoriva
            // 
            this.columnTipGoriva.Text = "Tip goriva";
            this.columnTipGoriva.Width = 196;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 22);
            this.label1.TabIndex = 133;
            this.label1.Text = "Izaberite vozilo koje zelite da obrisete";
            // 
            // ObrisiVoziloKojeNijeProdato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 338);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ObrisiVoziloKojeNijeProdato";
            this.Text = "ObrisiVoziloKojeNijeProdato";
            this.Load += new System.EventHandler(this.ObrisiVoziloKojeNijeProdato_Load);
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
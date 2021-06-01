
namespace MotornaVozila.Forme
{
    partial class ObrisiSalon
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnGrad,
            this.columnAdresa});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 125);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite salon koji zelite da obrisete";
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 89;
            // 
            // columnGrad
            // 
            this.columnGrad.Text = "Grad";
            this.columnGrad.Width = 146;
            // 
            // columnAdresa
            // 
            this.columnAdresa.Text = "Adresa";
            this.columnAdresa.Width = 233;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(186, 244);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(132, 76);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // ObrisiSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 342);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "ObrisiSalon";
            this.Text = "ObrisiSalon";
            this.Load += new System.EventHandler(this.ObrisiSalon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnGrad;
        private System.Windows.Forms.ColumnHeader columnAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
    }
}
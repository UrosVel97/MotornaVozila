
namespace MotornaVozila.Forme
{
    partial class ModifikujVlasnika
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
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTelefoni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 190;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 126;
            // 
            // columnId
            // 
            this.columnId.Text = "Id kupca";
            this.columnId.Width = 119;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnIme,
            this.columnPrezime});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(11, 49);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(499, 123);
            this.listView2.TabIndex = 73;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 38);
            this.label1.TabIndex = 72;
            this.label1.Text = "Izaberite neregistrovanog kupca koga zelite da modifikujete";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(102, 232);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(155, 20);
            this.txtPrezime.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(102, 192);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(155, 20);
            this.txtIme.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ime";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(212, 364);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(117, 45);
            this.btnSnimi.TabIndex = 61;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 46);
            this.label2.TabIndex = 77;
            this.label2.Text = "Brojevi telefona";
            // 
            // listBoxTelefoni
            // 
            this.listBoxTelefoni.FormattingEnabled = true;
            this.listBoxTelefoni.Location = new System.Drawing.Point(102, 272);
            this.listBoxTelefoni.Name = "listBoxTelefoni";
            this.listBoxTelefoni.Size = new System.Drawing.Size(155, 69);
            this.listBoxTelefoni.TabIndex = 78;
            // 
            // ModifikujVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 434);
            this.Controls.Add(this.listBoxTelefoni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSnimi);
            this.Name = "ModifikujVlasnika";
            this.Text = "ModifikujNeregistrovanogKupca";
            this.Load += new System.EventHandler(this.ModifikujNeregistrovanogKupca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTelefoni;
    }
}
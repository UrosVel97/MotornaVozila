
namespace MotornaVozila.Forme
{
    partial class ModifikujKupovinu
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
            this.columnDatumKupovine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnIdKupovina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dtDatumKupovine = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnDatumKupovine
            // 
            this.columnDatumKupovine.Text = "Datum kupovine";
            this.columnDatumKupovine.Width = 490;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdKupovina,
            this.columnDatumKupovine});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(28, 74);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(968, 189);
            this.listView2.TabIndex = 96;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnIdKupovina
            // 
            this.columnIdKupovina.Text = "Id kupovine";
            this.columnIdKupovina.Width = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 26);
            this.label1.TabIndex = 95;
            this.label1.Text = "Izaberite koju kupovinu zelite da modifikujete";
            // 
            // dtDatumKupovine
            // 
            this.dtDatumKupovine.Location = new System.Drawing.Point(28, 335);
            this.dtDatumKupovine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDatumKupovine.Name = "dtDatumKupovine";
            this.dtDatumKupovine.Size = new System.Drawing.Size(200, 22);
            this.dtDatumKupovine.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 18);
            this.label11.TabIndex = 88;
            this.label11.Text = "Datum kupovine";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(371, 386);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(243, 41);
            this.btnSnimi.TabIndex = 76;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // ModifikujKupovinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 466);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDatumKupovine);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSnimi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifikujKupovinu";
            this.Text = "ModifikujKupovinu";
            this.Load += new System.EventHandler(this.ModifikujKupovinu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnDatumKupovine;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDatumKupovine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ColumnHeader columnIdKupovina;
    }
}
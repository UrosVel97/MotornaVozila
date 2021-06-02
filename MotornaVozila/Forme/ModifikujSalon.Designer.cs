namespace MotornaVozila.Forme
{
    partial class ModifikujSalon
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
            this.checkObavlja = new System.Windows.Forms.CheckBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtSefServisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnIdSalona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSefSalona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSefServisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSefSalona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxListaTipRadova = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkObavlja
            // 
            this.checkObavlja.AutoSize = true;
            this.checkObavlja.Location = new System.Drawing.Point(520, 250);
            this.checkObavlja.Margin = new System.Windows.Forms.Padding(2);
            this.checkObavlja.Name = "checkObavlja";
            this.checkObavlja.Size = new System.Drawing.Size(96, 17);
            this.checkObavlja.TabIndex = 133;
            this.checkObavlja.Text = "Obavlja usluge";
            this.checkObavlja.UseVisualStyleBackColor = true;
            this.checkObavlja.CheckedChanged += new System.EventHandler(this.checkBoxTeretno_CheckedChanged);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(339, 421);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(141, 46);
            this.btnSnimi.TabIndex = 132;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtSefServisa
            // 
            this.txtSefServisa.Location = new System.Drawing.Point(130, 360);
            this.txtSefServisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtSefServisa.Name = "txtSefServisa";
            this.txtSefServisa.Size = new System.Drawing.Size(152, 20);
            this.txtSefServisa.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 124;
            this.label5.Text = "Sef servisa";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdSalona,
            this.columnGrad,
            this.columnAdresa,
            this.columnSefSalona,
            this.columnSefServisa});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(22, 60);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(766, 165);
            this.listView2.TabIndex = 123;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnIdSalona
            // 
            this.columnIdSalona.Text = "Id salona";
            this.columnIdSalona.Width = 126;
            // 
            // columnGrad
            // 
            this.columnGrad.Text = "Grad";
            this.columnGrad.Width = 129;
            // 
            // columnAdresa
            // 
            this.columnAdresa.Text = "Adresa";
            this.columnAdresa.Width = 185;
            // 
            // columnSefSalona
            // 
            this.columnSefSalona.Text = "Sef salona";
            this.columnSefSalona.Width = 179;
            // 
            // columnSefServisa
            // 
            this.columnSefServisa.Text = "Sef servisa";
            this.columnSefServisa.Width = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 22);
            this.label1.TabIndex = 122;
            this.label1.Text = "Izaberite salon koji zelite da modifikujete";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(367, 296);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 39);
            this.label13.TabIndex = 121;
            this.label13.Text = "Lista tip radova";
            this.label13.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(367, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 42);
            this.label9.TabIndex = 114;
            this.label9.Text = "Da li salon obavlja serviserske usluge?";
            // 
            // txtSefSalona
            // 
            this.txtSefSalona.Location = new System.Drawing.Point(130, 320);
            this.txtSefSalona.Margin = new System.Windows.Forms.Padding(2);
            this.txtSefSalona.Name = "txtSefSalona";
            this.txtSefSalona.Size = new System.Drawing.Size(152, 20);
            this.txtSefSalona.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 112;
            this.label4.Text = "Sef salona";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(130, 280);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(152, 20);
            this.txtAdresa.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 110;
            this.label3.Text = "Adresa";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(130, 240);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(152, 20);
            this.txtGrad.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "Grad";
            // 
            // checkedListBoxListaTipRadova
            // 
            this.checkedListBoxListaTipRadova.CheckOnClick = true;
            this.checkedListBoxListaTipRadova.FormattingEnabled = true;
            this.checkedListBoxListaTipRadova.Location = new System.Drawing.Point(520, 296);
            this.checkedListBoxListaTipRadova.Name = "checkedListBoxListaTipRadova";
            this.checkedListBoxListaTipRadova.Size = new System.Drawing.Size(186, 94);
            this.checkedListBoxListaTipRadova.TabIndex = 134;
            this.checkedListBoxListaTipRadova.Visible = false;
            // 
            // ModifikujSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 478);
            this.Controls.Add(this.checkedListBoxListaTipRadova);
            this.Controls.Add(this.checkObavlja);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtSefServisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSefSalona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label2);
            this.Name = "ModifikujSalon";
            this.Text = "ModifikujSalon";
            this.Load += new System.EventHandler(this.ModifikujSalon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkObavlja;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtSefServisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnIdSalona;
        private System.Windows.Forms.ColumnHeader columnGrad;
        private System.Windows.Forms.ColumnHeader columnAdresa;
        private System.Windows.Forms.ColumnHeader columnSefSalona;
        private System.Windows.Forms.ColumnHeader columnSefServisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSefSalona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxListaTipRadova;
    }
}
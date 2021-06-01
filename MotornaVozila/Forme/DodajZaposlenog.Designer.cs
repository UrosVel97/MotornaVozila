
namespace MotornaVozila.Forme
{
    partial class DodajZaposlenog
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
            this.btnDodajRadnikeTehnickeStruke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajRadnikaEkonomskeStruke = new System.Windows.Forms.Button();
            this.btnDodajDrugogZaposlenog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajRadnikeTehnickeStruke
            // 
            this.btnDodajRadnikeTehnickeStruke.Location = new System.Drawing.Point(103, 75);
            this.btnDodajRadnikeTehnickeStruke.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajRadnikeTehnickeStruke.Name = "btnDodajRadnikeTehnickeStruke";
            this.btnDodajRadnikeTehnickeStruke.Size = new System.Drawing.Size(127, 55);
            this.btnDodajRadnikeTehnickeStruke.TabIndex = 0;
            this.btnDodajRadnikeTehnickeStruke.Text = "Dodaj radnika tehnicke struke";
            this.btnDodajRadnikeTehnickeStruke.UseVisualStyleBackColor = true;
            this.btnDodajRadnikeTehnickeStruke.Click += new System.EventHandler(this.btnDodajRadnikeTehnickeStruke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izaberite kakvog radnika zelite da dodate";
            // 
            // btnDodajRadnikaEkonomskeStruke
            // 
            this.btnDodajRadnikaEkonomskeStruke.Location = new System.Drawing.Point(103, 150);
            this.btnDodajRadnikaEkonomskeStruke.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajRadnikaEkonomskeStruke.Name = "btnDodajRadnikaEkonomskeStruke";
            this.btnDodajRadnikaEkonomskeStruke.Size = new System.Drawing.Size(127, 55);
            this.btnDodajRadnikaEkonomskeStruke.TabIndex = 3;
            this.btnDodajRadnikaEkonomskeStruke.Text = "Dodaj radnika ekonomske struke";
            this.btnDodajRadnikaEkonomskeStruke.UseVisualStyleBackColor = true;
            this.btnDodajRadnikaEkonomskeStruke.Click += new System.EventHandler(this.btnDodajRadnikaEkonomskeStruke_Click);
            // 
            // btnDodajDrugogZaposlenog
            // 
            this.btnDodajDrugogZaposlenog.Location = new System.Drawing.Point(103, 225);
            this.btnDodajDrugogZaposlenog.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajDrugogZaposlenog.Name = "btnDodajDrugogZaposlenog";
            this.btnDodajDrugogZaposlenog.Size = new System.Drawing.Size(127, 55);
            this.btnDodajDrugogZaposlenog.TabIndex = 4;
            this.btnDodajDrugogZaposlenog.Text = "Dodaj nekog drugog zaposlenog";
            this.btnDodajDrugogZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajDrugogZaposlenog.Click += new System.EventHandler(this.btnDodajDrugogZaposlenog_Click);
            // 
            // DodajZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 326);
            this.Controls.Add(this.btnDodajDrugogZaposlenog);
            this.Controls.Add(this.btnDodajRadnikaEkonomskeStruke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajRadnikeTehnickeStruke);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajZaposlenog";
            this.Text = "DodajZaposlenog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajRadnikeTehnickeStruke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajRadnikaEkonomskeStruke;
        private System.Windows.Forms.Button btnDodajDrugogZaposlenog;
    }
}

namespace MotornaVozila.Forme
{
    partial class ModifikujZaposlenog
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
            this.btnModifikujRadnikaTehnickeStruke = new System.Windows.Forms.Button();
            this.btnModifikujRadnikaEkonomskeStruke = new System.Windows.Forms.Button();
            this.btnModifikujNekogDrugogZaposlenog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifikujRadnikaTehnickeStruke
            // 
            this.btnModifikujRadnikaTehnickeStruke.Location = new System.Drawing.Point(177, 43);
            this.btnModifikujRadnikaTehnickeStruke.Name = "btnModifikujRadnikaTehnickeStruke";
            this.btnModifikujRadnikaTehnickeStruke.Size = new System.Drawing.Size(174, 85);
            this.btnModifikujRadnikaTehnickeStruke.TabIndex = 0;
            this.btnModifikujRadnikaTehnickeStruke.Text = "Modifikuj radnika tehnicke struke";
            this.btnModifikujRadnikaTehnickeStruke.UseVisualStyleBackColor = true;
            this.btnModifikujRadnikaTehnickeStruke.Click += new System.EventHandler(this.btnModifikujRadnikaTehnickeStruke_Click);
            // 
            // btnModifikujRadnikaEkonomskeStruke
            // 
            this.btnModifikujRadnikaEkonomskeStruke.Location = new System.Drawing.Point(177, 139);
            this.btnModifikujRadnikaEkonomskeStruke.Name = "btnModifikujRadnikaEkonomskeStruke";
            this.btnModifikujRadnikaEkonomskeStruke.Size = new System.Drawing.Size(174, 85);
            this.btnModifikujRadnikaEkonomskeStruke.TabIndex = 1;
            this.btnModifikujRadnikaEkonomskeStruke.Text = "Modifikuj radnika ekonomske struke";
            this.btnModifikujRadnikaEkonomskeStruke.UseVisualStyleBackColor = true;
            this.btnModifikujRadnikaEkonomskeStruke.Click += new System.EventHandler(this.btnModifikujRadnikaEkonomskeStruke_Click);
            // 
            // btnModifikujNekogDrugogZaposlenog
            // 
            this.btnModifikujNekogDrugogZaposlenog.Location = new System.Drawing.Point(177, 242);
            this.btnModifikujNekogDrugogZaposlenog.Name = "btnModifikujNekogDrugogZaposlenog";
            this.btnModifikujNekogDrugogZaposlenog.Size = new System.Drawing.Size(174, 85);
            this.btnModifikujNekogDrugogZaposlenog.TabIndex = 2;
            this.btnModifikujNekogDrugogZaposlenog.Text = "Modifikuj nekog drugog zaposlenog";
            this.btnModifikujNekogDrugogZaposlenog.UseVisualStyleBackColor = true;
            this.btnModifikujNekogDrugogZaposlenog.Click += new System.EventHandler(this.btnModifikujNekogDrugogZaposlenog_Click);
            // 
            // ModifikujZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 410);
            this.Controls.Add(this.btnModifikujNekogDrugogZaposlenog);
            this.Controls.Add(this.btnModifikujRadnikaEkonomskeStruke);
            this.Controls.Add(this.btnModifikujRadnikaTehnickeStruke);
            this.Name = "ModifikujZaposlenog";
            this.Text = "ModifikujZaposlenog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifikujRadnikaTehnickeStruke;
        private System.Windows.Forms.Button btnModifikujRadnikaEkonomskeStruke;
        private System.Windows.Forms.Button btnModifikujNekogDrugogZaposlenog;
    }
}

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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifikujRadnikaTehnickeStruke
            // 
            this.btnModifikujRadnikaTehnickeStruke.Location = new System.Drawing.Point(137, 65);
            this.btnModifikujRadnikaTehnickeStruke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifikujRadnikaTehnickeStruke.Name = "btnModifikujRadnikaTehnickeStruke";
            this.btnModifikujRadnikaTehnickeStruke.Size = new System.Drawing.Size(130, 60);
            this.btnModifikujRadnikaTehnickeStruke.TabIndex = 0;
            this.btnModifikujRadnikaTehnickeStruke.Text = "Modifikuj radnika tehnicke struke";
            this.btnModifikujRadnikaTehnickeStruke.UseVisualStyleBackColor = true;
            this.btnModifikujRadnikaTehnickeStruke.Click += new System.EventHandler(this.btnModifikujRadnikaTehnickeStruke_Click);
            // 
            // btnModifikujRadnikaEkonomskeStruke
            // 
            this.btnModifikujRadnikaEkonomskeStruke.Location = new System.Drawing.Point(137, 140);
            this.btnModifikujRadnikaEkonomskeStruke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifikujRadnikaEkonomskeStruke.Name = "btnModifikujRadnikaEkonomskeStruke";
            this.btnModifikujRadnikaEkonomskeStruke.Size = new System.Drawing.Size(130, 60);
            this.btnModifikujRadnikaEkonomskeStruke.TabIndex = 1;
            this.btnModifikujRadnikaEkonomskeStruke.Text = "Modifikuj radnika ekonomske struke";
            this.btnModifikujRadnikaEkonomskeStruke.UseVisualStyleBackColor = true;
            this.btnModifikujRadnikaEkonomskeStruke.Click += new System.EventHandler(this.btnModifikujRadnikaEkonomskeStruke_Click);
            // 
            // btnModifikujNekogDrugogZaposlenog
            // 
            this.btnModifikujNekogDrugogZaposlenog.Location = new System.Drawing.Point(137, 220);
            this.btnModifikujNekogDrugogZaposlenog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifikujNekogDrugogZaposlenog.Name = "btnModifikujNekogDrugogZaposlenog";
            this.btnModifikujNekogDrugogZaposlenog.Size = new System.Drawing.Size(130, 60);
            this.btnModifikujNekogDrugogZaposlenog.TabIndex = 2;
            this.btnModifikujNekogDrugogZaposlenog.Text = "Modifikuj nekog drugog zaposlenog";
            this.btnModifikujNekogDrugogZaposlenog.UseVisualStyleBackColor = true;
            this.btnModifikujNekogDrugogZaposlenog.Click += new System.EventHandler(this.btnModifikujNekogDrugogZaposlenog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite kakvog radnika zelite da dodate";
            // 
            // ModifikujZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifikujNekogDrugogZaposlenog);
            this.Controls.Add(this.btnModifikujRadnikaEkonomskeStruke);
            this.Controls.Add(this.btnModifikujRadnikaTehnickeStruke);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifikujZaposlenog";
            this.Text = "ModifikujZaposlenog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifikujRadnikaTehnickeStruke;
        private System.Windows.Forms.Button btnModifikujRadnikaEkonomskeStruke;
        private System.Windows.Forms.Button btnModifikujNekogDrugogZaposlenog;
        private System.Windows.Forms.Label label2;
    }
}
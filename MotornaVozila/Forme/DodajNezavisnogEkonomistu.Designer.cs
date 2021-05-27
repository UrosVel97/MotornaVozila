
namespace MotornaVozila.Forme
{
    partial class DodajNezavisnogEkonomistu
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
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(215, 123);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(129, 41);
            this.btnSnimi.TabIndex = 0;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // DodajNezavisnogEkonomistu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSnimi);
            this.Name = "DodajNezavisnogEkonomistu";
            this.Text = "DodajNezavisnogEkonomistu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnimi;
    }
}
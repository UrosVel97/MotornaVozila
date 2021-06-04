
namespace MotornaVozila.Forme
{
    partial class DodajKupca
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
            this.btnDodajPravnoLice = new System.Windows.Forms.Button();
            this.btnDodajFizickoLice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajPravnoLice
            // 
            this.btnDodajPravnoLice.Location = new System.Drawing.Point(232, 59);
            this.btnDodajPravnoLice.Name = "btnDodajPravnoLice";
            this.btnDodajPravnoLice.Size = new System.Drawing.Size(242, 134);
            this.btnDodajPravnoLice.TabIndex = 0;
            this.btnDodajPravnoLice.Text = "Dodaj pravno lice";
            this.btnDodajPravnoLice.UseVisualStyleBackColor = true;
            this.btnDodajPravnoLice.Click += new System.EventHandler(this.btnDodajPravnoLice_Click);
            // 
            // btnDodajFizickoLice
            // 
            this.btnDodajFizickoLice.Location = new System.Drawing.Point(232, 231);
            this.btnDodajFizickoLice.Name = "btnDodajFizickoLice";
            this.btnDodajFizickoLice.Size = new System.Drawing.Size(242, 134);
            this.btnDodajFizickoLice.TabIndex = 1;
            this.btnDodajFizickoLice.Text = "Dodaj fizicko lice";
            this.btnDodajFizickoLice.UseVisualStyleBackColor = true;
            this.btnDodajFizickoLice.Click += new System.EventHandler(this.btnDodajFizickoLice_Click);
            // 
            // DodajKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajFizickoLice);
            this.Controls.Add(this.btnDodajPravnoLice);
            this.Name = "DodajKupca";
            this.Text = "DodajKupca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajPravnoLice;
        private System.Windows.Forms.Button btnDodajFizickoLice;
    }
}
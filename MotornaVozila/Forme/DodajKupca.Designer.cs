
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajPravnoLice
            // 
            this.btnDodajPravnoLice.Location = new System.Drawing.Point(145, 75);
            this.btnDodajPravnoLice.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajPravnoLice.Name = "btnDodajPravnoLice";
            this.btnDodajPravnoLice.Size = new System.Drawing.Size(136, 77);
            this.btnDodajPravnoLice.TabIndex = 0;
            this.btnDodajPravnoLice.Text = "Dodaj pravno lice";
            this.btnDodajPravnoLice.UseVisualStyleBackColor = true;
            this.btnDodajPravnoLice.Click += new System.EventHandler(this.btnDodajPravnoLice_Click);
            // 
            // btnDodajFizickoLice
            // 
            this.btnDodajFizickoLice.Location = new System.Drawing.Point(145, 200);
            this.btnDodajFizickoLice.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajFizickoLice.Name = "btnDodajFizickoLice";
            this.btnDodajFizickoLice.Size = new System.Drawing.Size(136, 80);
            this.btnDodajFizickoLice.TabIndex = 1;
            this.btnDodajFizickoLice.Text = "Dodaj fizicko lice";
            this.btnDodajFizickoLice.UseVisualStyleBackColor = true;
            this.btnDodajFizickoLice.Click += new System.EventHandler(this.btnDodajFizickoLice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(48, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izaberite kakvog kupca zelite da dodate";
            // 
            // DodajKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajFizickoLice);
            this.Controls.Add(this.btnDodajPravnoLice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajKupca";
            this.Text = "DodajKupca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajPravnoLice;
        private System.Windows.Forms.Button btnDodajFizickoLice;
        private System.Windows.Forms.Label label2;
    }
}
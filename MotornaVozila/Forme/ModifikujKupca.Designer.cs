
namespace MotornaVozila.Forme
{
    partial class ModifikujKupca
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
            this.btnModifikujPravnoLice = new System.Windows.Forms.Button();
            this.btnModifikujFizickoLice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifikujPravnoLice
            // 
            this.btnModifikujPravnoLice.Location = new System.Drawing.Point(180, 53);
            this.btnModifikujPravnoLice.Name = "btnModifikujPravnoLice";
            this.btnModifikujPravnoLice.Size = new System.Drawing.Size(233, 122);
            this.btnModifikujPravnoLice.TabIndex = 0;
            this.btnModifikujPravnoLice.Text = "Modifikuj pravno lice";
            this.btnModifikujPravnoLice.UseVisualStyleBackColor = true;
            this.btnModifikujPravnoLice.Click += new System.EventHandler(this.btnModifikujPravnoLice_Click);
            // 
            // btnModifikujFizickoLice
            // 
            this.btnModifikujFizickoLice.Location = new System.Drawing.Point(180, 221);
            this.btnModifikujFizickoLice.Name = "btnModifikujFizickoLice";
            this.btnModifikujFizickoLice.Size = new System.Drawing.Size(233, 124);
            this.btnModifikujFizickoLice.TabIndex = 1;
            this.btnModifikujFizickoLice.Text = "Modifikuj fizicko lice";
            this.btnModifikujFizickoLice.UseVisualStyleBackColor = true;
            this.btnModifikujFizickoLice.Click += new System.EventHandler(this.btnModifikujFizickoLice_Click);
            // 
            // ModifikujKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 424);
            this.Controls.Add(this.btnModifikujFizickoLice);
            this.Controls.Add(this.btnModifikujPravnoLice);
            this.Name = "ModifikujKupca";
            this.Text = "ModifikujKupca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifikujPravnoLice;
        private System.Windows.Forms.Button btnModifikujFizickoLice;
    }
}
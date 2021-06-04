
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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifikujPravnoLice
            // 
            this.btnModifikujPravnoLice.Location = new System.Drawing.Point(139, 81);
            this.btnModifikujPravnoLice.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifikujPravnoLice.Name = "btnModifikujPravnoLice";
            this.btnModifikujPravnoLice.Size = new System.Drawing.Size(155, 75);
            this.btnModifikujPravnoLice.TabIndex = 0;
            this.btnModifikujPravnoLice.Text = "Modifikuj pravno lice";
            this.btnModifikujPravnoLice.UseVisualStyleBackColor = true;
            this.btnModifikujPravnoLice.Click += new System.EventHandler(this.btnModifikujPravnoLice_Click);
            // 
            // btnModifikujFizickoLice
            // 
            this.btnModifikujFizickoLice.Location = new System.Drawing.Point(139, 201);
            this.btnModifikujFizickoLice.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifikujFizickoLice.Name = "btnModifikujFizickoLice";
            this.btnModifikujFizickoLice.Size = new System.Drawing.Size(155, 75);
            this.btnModifikujFizickoLice.TabIndex = 1;
            this.btnModifikujFizickoLice.Text = "Modifikuj fizicko lice";
            this.btnModifikujFizickoLice.UseVisualStyleBackColor = true;
            this.btnModifikujFizickoLice.Click += new System.EventHandler(this.btnModifikujFizickoLice_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Izaberite kupca koga zelite da modifikujete";
            // 
            // ModifikujKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 342);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModifikujFizickoLice);
            this.Controls.Add(this.btnModifikujPravnoLice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifikujKupca";
            this.Text = "ModifikujKupca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifikujPravnoLice;
        private System.Windows.Forms.Button btnModifikujFizickoLice;
        private System.Windows.Forms.Label label4;
    }
}
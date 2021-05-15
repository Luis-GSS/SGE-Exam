
namespace SGE_pa_Excentar
{
    partial class ExamenI
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
            this.nomE = new System.Windows.Forms.Label();
            this.nomA = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nomE
            // 
            this.nomE.AutoSize = true;
            this.nomE.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomE.Location = new System.Drawing.Point(26, 19);
            this.nomE.Name = "nomE";
            this.nomE.Size = new System.Drawing.Size(158, 31);
            this.nomE.TabIndex = 0;
            this.nomE.Text = "Examen de: ";
            // 
            // nomA
            // 
            this.nomA.AutoSize = true;
            this.nomA.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomA.Location = new System.Drawing.Point(313, 51);
            this.nomA.Name = "nomA";
            this.nomA.Size = new System.Drawing.Size(132, 31);
            this.nomA.TabIndex = 1;
            this.nomA.Text = "Nombre:  ";
            this.nomA.Click += new System.EventHandler(this.label1_Click);
            // 
            // box1
            // 
            this.box1.FormattingEnabled = true;
            this.box1.Location = new System.Drawing.Point(261, 160);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(121, 21);
            this.box1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 290);
            this.listBox1.TabIndex = 11;
            // 
            // ExamenI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomA);
            this.Controls.Add(this.nomE);
            this.Name = "ExamenI";
            this.Text = "ExamenI";
            this.Load += new System.EventHandler(this.ExamenI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomE;
        private System.Windows.Forms.Label nomA;
        private System.Windows.Forms.ComboBox box1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
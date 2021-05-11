
namespace SGE_pa_Excentar
{
    partial class FormRegistrar
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
            this.components = new System.ComponentModel.Container();
            this.fNocontrol = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fCarrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fSemestre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fContraseña = new System.Windows.Forms.TextBox();
            this.bRregis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fNocontrol
            // 
            this.fNocontrol.AcceptsReturn = true;
            this.fNocontrol.Location = new System.Drawing.Point(12, 35);
            this.fNocontrol.Name = "fNocontrol";
            this.fNocontrol.Size = new System.Drawing.Size(100, 20);
            this.fNocontrol.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No de control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // fNombre
            // 
            this.fNombre.Location = new System.Drawing.Point(12, 74);
            this.fNombre.Name = "fNombre";
            this.fNombre.Size = new System.Drawing.Size(100, 20);
            this.fNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Carrera";
            // 
            // fCarrera
            // 
            this.fCarrera.Location = new System.Drawing.Point(12, 113);
            this.fCarrera.Name = "fCarrera";
            this.fCarrera.Size = new System.Drawing.Size(100, 20);
            this.fCarrera.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semestre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fSemestre
            // 
            this.fSemestre.Location = new System.Drawing.Point(12, 152);
            this.fSemestre.Name = "fSemestre";
            this.fSemestre.Size = new System.Drawing.Size(100, 20);
            this.fSemestre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña";
            // 
            // fContraseña
            // 
            this.fContraseña.Location = new System.Drawing.Point(12, 191);
            this.fContraseña.Name = "fContraseña";
            this.fContraseña.Size = new System.Drawing.Size(100, 20);
            this.fContraseña.TabIndex = 9;
            this.fContraseña.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // bRregis
            // 
            this.bRregis.Location = new System.Drawing.Point(141, 71);
            this.bRregis.Name = "bRregis";
            this.bRregis.Size = new System.Drawing.Size(138, 101);
            this.bRregis.TabIndex = 11;
            this.bRregis.Text = "Registrar";
            this.bRregis.UseVisualStyleBackColor = true;
            this.bRregis.Click += new System.EventHandler(this.bRregis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 59);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingresa tus datos correctamente en los campos correspondientes";
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(302, 236);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bRregis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fCarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fNocontrol);
            this.Name = "FormRegistrar";
            this.Text = "FormRegistrar";
            this.Load += new System.EventHandler(this.FormRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNocontrol;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fSemestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fContraseña;
        private System.Windows.Forms.Button bRregis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}
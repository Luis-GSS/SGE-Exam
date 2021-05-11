
namespace SGE_pa_Excentar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLogin = new System.Windows.Forms.Button();
            this.bRegiter = new System.Windows.Forms.Button();
            this.fieldContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 62);
            this.label5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(423, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 84);
            this.label4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(185, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 115);
            this.label3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SGE_pa_Excentar.Properties.Resources.fondo1;
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Controls.Add(this.bRegiter);
            this.panel1.Controls.Add(this.fieldContra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fieldControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(118, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 193);
            this.panel1.TabIndex = 6;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(60, 152);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 11;
            this.bLogin.Text = "Acceder";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click_1);
            // 
            // bRegiter
            // 
            this.bRegiter.Location = new System.Drawing.Point(164, 152);
            this.bRegiter.Name = "bRegiter";
            this.bRegiter.Size = new System.Drawing.Size(75, 23);
            this.bRegiter.TabIndex = 10;
            this.bRegiter.Text = "Registrar";
            this.bRegiter.UseVisualStyleBackColor = true;
            this.bRegiter.Click += new System.EventHandler(this.bRegiter_Click_1);
            // 
            // fieldContra
            // 
            this.fieldContra.Location = new System.Drawing.Point(97, 110);
            this.fieldContra.Name = "fieldContra";
            this.fieldContra.PasswordChar = '°';
            this.fieldContra.Size = new System.Drawing.Size(100, 20);
            this.fieldContra.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(94, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresa tu contraseña:";
            // 
            // fieldControl
            // 
            this.fieldControl.Location = new System.Drawing.Point(97, 50);
            this.fieldControl.Name = "fieldControl";
            this.fieldControl.Size = new System.Drawing.Size(100, 20);
            this.fieldControl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(72, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresa tu numero de control: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(541, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bRegiter;
        private System.Windows.Forms.TextBox fieldContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


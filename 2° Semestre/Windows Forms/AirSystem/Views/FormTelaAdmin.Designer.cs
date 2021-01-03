namespace AirSystem.Views
{
    partial class FormTelaAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGerRel = new System.Windows.Forms.Button();
            this.btnGerCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(127, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar Usuarios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(127, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 108);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar Avôes ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(327, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 108);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gerenciar Aviâo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnGerRel
            // 
            this.btnGerRel.BackColor = System.Drawing.Color.Black;
            this.btnGerRel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGerRel.Location = new System.Drawing.Point(522, 207);
            this.btnGerRel.Name = "btnGerRel";
            this.btnGerRel.Size = new System.Drawing.Size(110, 108);
            this.btnGerRel.TabIndex = 3;
            this.btnGerRel.Text = "Gerenciar relatorios";
            this.btnGerRel.UseVisualStyleBackColor = false;
            // 
            // btnGerCom
            // 
            this.btnGerCom.BackColor = System.Drawing.Color.Black;
            this.btnGerCom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGerCom.Location = new System.Drawing.Point(522, 29);
            this.btnGerCom.Name = "btnGerCom";
            this.btnGerCom.Size = new System.Drawing.Size(110, 108);
            this.btnGerCom.TabIndex = 4;
            this.btnGerCom.Text = "Gerenciar Companhia";
            this.btnGerCom.UseVisualStyleBackColor = false;
            // 
            // FormTelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(780, 363);
            this.Controls.Add(this.btnGerCom);
            this.Controls.Add(this.btnGerRel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormTelaAdmin";
            this.Text = "FormTelaAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGerRel;
        private System.Windows.Forms.Button btnGerCom;
    }
}
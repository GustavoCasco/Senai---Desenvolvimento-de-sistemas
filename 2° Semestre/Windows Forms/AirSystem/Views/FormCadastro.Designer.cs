namespace AirSystem.Views
{
    partial class Cadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.pcbAlterar = new System.Windows.Forms.PictureBox();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.cboxAdm = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(53, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEndereco.Location = new System.Drawing.Point(53, 90);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 15);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNascimento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNascimento.Location = new System.Drawing.Point(53, 136);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(73, 15);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(53, 177);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenha.Location = new System.Drawing.Point(53, 221);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 15);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblConfirmaSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(55, 275);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(96, 15);
            this.lblConfirmaSenha.TabIndex = 5;
            this.lblConfirmaSenha.Text = "Confirma Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 21;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(56, 108);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(146, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(56, 195);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(146, 20);
            this.txtUser.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(56, 239);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(146, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(56, 293);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(146, 20);
            this.txtConfSenha.TabIndex = 10;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(56, 154);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(230, 20);
            this.dtNascimento.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(242, 108);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // pcbAlterar
            // 
            this.pcbAlterar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbAlterar.Location = new System.Drawing.Point(552, 49);
            this.pcbAlterar.Name = "pcbAlterar";
            this.pcbAlterar.Size = new System.Drawing.Size(180, 102);
            this.pcbAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAlterar.TabIndex = 13;
            this.pcbAlterar.TabStop = false;
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(552, 168);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(75, 23);
            this.bntAlterar.TabIndex = 14;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            this.bntAlterar.Click += new System.EventHandler(this.bntAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(657, 168);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // cboxAdm
            // 
            this.cboxAdm.AutoSize = true;
            this.cboxAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboxAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.cboxAdm.Location = new System.Drawing.Point(552, 218);
            this.cboxAdm.Name = "cboxAdm";
            this.cboxAdm.Size = new System.Drawing.Size(62, 19);
            this.cboxAdm.TabIndex = 16;
            this.cboxAdm.Text = "É adm";
            this.cboxAdm.UseVisualStyleBackColor = true;
            this.cboxAdm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCadastrar.Location = new System.Drawing.Point(346, 341);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(185, 67);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(146, 20);
            this.txtSobrenome.TabIndex = 18;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSobrenome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSobrenome.Location = new System.Drawing.Point(182, 49);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(72, 15);
            this.lblSobrenome.TabIndex = 19;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumero.Location = new System.Drawing.Point(239, 90);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 15);
            this.lblNumero.TabIndex = 20;
            this.lblNumero.Text = "Numero";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(763, 381);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboxAdm);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.pcbAlterar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.Text = "FormCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.PictureBox pcbAlterar;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.CheckBox cboxAdm;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNumero;
    }
}
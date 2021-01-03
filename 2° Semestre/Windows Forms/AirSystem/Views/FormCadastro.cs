using AirSystem.Models;
using AirSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class Cadastro : Form
    {
        private Usuario usuario = null; 
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pcbAlterar.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!CampoVazio.temCamposVazio(this))
            {

                UsuarioRepository repository = new UsuarioRepository();

            if (this.usuario == null)
            {
                Usuario usuario = new Usuario
                {
                    nome = txtNome.Text,
                    endereco = txtEndereco.Text,
                    numero = txtNumero.Text,
                    nascimento = Convert.ToDateTime(dtNascimento.Text),
                    user = txtUser.Text,
                    senha = txtSenha.Text,
                    confirmacaosenha = txtConfSenha.Text
                };

                repository.adicionar(usuario);
                    if (txtConfSenha.Text == txtSenha.Text)
                    {
                     MessageBox.Show("Cadastro realizado com sucesso!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (cboxAdm.Checked)
                     {
                            this.Hide();
                      new FormTelaAdmin().ShowDialog();
                            this.Close();
                   }
                    else
                    {
                            this.Hide();
                       new FormTelaUser().ShowDialog();
                            this.Close();
                    } 
                     
                    }else
                    {
                        MessageBox.Show("Senhas devem ser iguais", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    this.usuario.nome = txtNome.Text;
                    this.usuario.endereco = txtEndereco.Text;
                    this.usuario.numero = txtNumero.Text;
                    this.usuario.nascimento = Convert.ToDateTime(dtNascimento.Text);
                    this.usuario.user = txtUser.Text;
                    this.usuario.senha = txtSenha.Text;
                    this.usuario.confirmacaosenha = txtConfSenha.Text;

                    repository.AtualizarTodos(usuario);
                }

            } else
            { 
                MessageBox.Show("Todos devem ser preenchidos.","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            pcbAlterar.Image = null;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string pattern = "[A-Z]{1}[a-z]{1,}[0-9]{1,}";

            lblSenha.Visible = !Regex.IsMatch(txtSenha.Text, pattern);
        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha == txtConfSenha)
            {
                MessageBox.Show("As senhas são iguais");
            }
        }
    }
}

using AirSystem.Models;
using AirSystem.Repository;
using AirSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class FormListaUser : Form
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();

        public FormListaUser()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];
            string nome = linha.Cells[1].Value.ToString();
            string endereco = linha.Cells[2].Value.ToString();
            string Usuario = linha.Cells[3].Value.ToString();
            string senha = linha.Cells[4].Value.ToString();
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            Usuario ser = new Usuario
            {
                id = codigo,
                nome = nome,
                endereco = endereco,
                senha = senha,
                user = Usuario,

            };
           
            Listar();
        }

        private void FormListaUser_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = usuarioRepository.buscarTodos();
            atualizaLista();
        }

        private void atualizaLista()
        {
            dgvListaUsuario.DataSource = null;

            List<Usuario> usuarios = usuarioRepository.buscarTodos();

            List<UsuarioViewModel> userFiltro = new List<UsuarioViewModel>();

            foreach (var item in usuarios)
            {
                UsuarioViewModel usuarioFiltro = new UsuarioViewModel
                {
                    id = item.id,
                    nome = item.nome,
                    sobrenome = item.sobrenome
                };

                userFiltro.Add(usuarioFiltro);
            }

            dgvListaUsuario.DataSource = userFiltro;

            Listar();
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = usuarioRepository.buscarTodos().
            FindAll(x => x.nome.ToUpper().Contains(tbxFiltro.Text.ToUpper()));

            Listar();
        }


        private void Contador()
        {         
             lblquantidade.Text = $"{dgvListaUsuario.RowCount} itens de {usuarioRepository.buscarTodos().Count}";   
        }


        private void Listar()
        {
            UsuarioRepository rps = new UsuarioRepository();
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = rps.buscarTodos();
            Contador();
        }

        private void btnDeletar_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];

                    int id = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    usuarioRepository.deletar(id);

                    Listar();
                }
            }
        }
    }
}

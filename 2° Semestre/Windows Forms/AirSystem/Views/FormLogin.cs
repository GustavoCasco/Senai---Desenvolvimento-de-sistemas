using AirSystem.Models;
using AirSystem.Repository;
using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNovouser_Click(object sender, EventArgs e)
        {
            new Cadastro().ShowDialog();
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {


            new FormTelaUser().ShowDialog();
        }

      
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            Application.Exit();
        }
    }
}

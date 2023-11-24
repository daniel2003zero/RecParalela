using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCliente : Form
    {
        private List<Cliente> clientes = new List<Cliente>();

        public frmCliente()
        {
            InitializeComponent();
            dataGridViewCliente.Columns.Add("Nome", "Nome");
            dataGridViewCliente.Columns.Add("Email", "Email");
            dataGridViewCliente.Columns.Add("CPF", "CPF");
            dataGridViewCliente.Columns.Add("DataNascimento", "Data de Nascimento");
            dataGridViewCliente.Columns.Add("Telefone", "Telefone");
            dataGridViewCliente.Columns.Add("Cidade", "Cidade");

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Email = txtEmail.Text;
            string Cpf = txtCpf.Text;
            string DataNascimento = txtDataNascimento.Text;
            string Telefone = txtTelefone.Text;
            string Cidade = txtCidade.Text;

            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite o nome aqui")
            {
                txtNome.Text = "Daniel Alcantara";
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // Evento que ocorre ao carregar o formulário
            // Define o texto inicial no TextBox
            txtNome.Text = "Digite o nome aqui";
            txtEmail.Text = "Digite o e-mail aqui";
            txtCpf.Text = "Digite o CPF aqui";
            txtDataNascimento.Text = "DD/MM/AAAA";
            txtTelefone.Text = "Digite o telefone aqui";
            txtCidade.Text = "Digite a cidade aqui";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Digite o e-mail aqui")
            {
                txtEmail.Text = "d.loureiro@aluno.senai.br";
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (txtCpf.Text == "Digite o CPF aqui")
            {
                txtCpf.Text = "15042825700";
            }
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            if (txtDataNascimento.Text == "DD/MM/AAAA")
            {
                txtDataNascimento.Text = "05/12/2003";
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "Digite o telefone aqui")
            {
                txtTelefone.Text = "(27) 99767-8700";
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            if (txtCidade.Text == "Digite a cidade aqui")
            {
                txtCidade.Text = "Linhares-ES";
            }
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCliente.Rows.Clear();

            // Adicionar cada cliente à DataGridView
            foreach (var cliente in clientes)
            {
                dataGridViewCliente.Rows.Add(
                    cliente.Nome,
                    cliente.Email,
                    cliente.Cpf,
                    cliente.DataNascimento,
                    cliente.Telefone,
                    cliente.Cidade
                );
            }
        }
    }
}

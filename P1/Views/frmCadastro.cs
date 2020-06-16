using EstudoTaskool.Models;
using EstudoTaskool.Repositories;
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

namespace EstudoTaskool
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;

        public frmCadastro()
        {
            InitializeComponent();
        }

        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                nomeTextBox.Text = usuario.nome;
                enderecoTextBox.Text = usuario.endereco;
                nacimentoTextBox.Text = usuario.datanascimento;
                usuarioTextBox.Text = usuario.usuario;
                senhaTextBox.Text = usuario.senha;
                csenhaTextBox.Text = usuario.csenha;
                administardorButton.Text = usuario.administardor;
            }
        }

        private void btnGerarAleatorio_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite um nome para gerar aleatório", "Erro");
                return;
            }
            if (nomeTextBox.Text.Split(' ').Length == 1)
            {
                MessageBox.Show("Não foi possível gerar aleatório.", "Erro");
            }
            else
            {
                string input = nomeTextBox.Text;
                int posEspaco = input.IndexOf(" ", 0);

                string parte1 = input.Substring(0, posEspaco);
                string parte2 = input.Substring(posEspaco + 1, input.Length - (posEspaco + 1));

                string userName = parte1 + "." + parte2 + dtpNascimento.Value.ToString("yy").ToString();
                usuarioTextBox.Text = userName;

            }
        }

        private void Inputs_Leave(object sender, EventArgs e)
        {

        }

        private void Inputs_Enter(object sender, EventArgs e)
        {

        }

        private static int CalculaIdade(DateTime dataNascimento)
        {
            //pega a parte ano das datas e subtrai
            int idade = DateTime.Now.Year - dataNascimento.Year;
            //verifica se i dia é anterior a data atual
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }

            return idade;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //O filtro - somente apresentar os arquivos de imagem
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            //Chamar a janela - entrar somente se confirma a seleção do arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                PictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            //8. Armazena os dados do novo usuário nas propriedades da classe e carrega na lista (para alimentar o datagrid)
            //instanciar a classe UsuarioRepository onde estão criados os métodos de acesso aos dados

            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    //Atribui nas propriedades da classe usuários os valores dos campos do formulário
                    Usuario usuario = new Usuario
                    {
                        nome = nomeTextBox.Text,
                        endereco = enderecoTextBox.Text,
                        senha = "1234",
                        csenha = "1234",
                        usuario = usuarioTextBox.Text
                    };
                    //chama o método adicionar - passando a classe usuario
                    repository.adicionar(usuario);

                    //Todos os campos foram preenchidos - Salva os campos no BD
                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                }
                else
                {
                    //alimenta as propriedades da classe com o conteúdo dos campos do formulário

                    this.usuario.nome = nomeTextBox.Text;
                    this.usuario.endereco = enderecoTextBox.Text;
                    this.usuario.datanascimento = dtpNascimento.Text;
                    this.usuario.senha = "1234";
                    this.usuario.usuario = usuarioTextBox.Text;
                    //Chama o método para editar 
                    //Atalho para criar o método -> Alt Enter para criar o método editar

                    repository.editar(usuario);
                }
                this.Close();

            }
            else
            {   //Texto , Título, Botões, Ícone
                MessageBox.Show("Campos Obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }


        bool isValidEmail;

        private void TeclaPressioada(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string NomeUsuario;
            string Endereco;
            int DataNascimento;
            string Usuario;
            int Senha;
            int Csenha;


            NomeUsuario = nomeTextBox.Text;
            Endereco = enderecoTextBox.Text;
            DataNascimento = dtpNascimento;
            Usuario = usuarioTextBox.Text;
            Senha = .num;
            Csenha = .num;
            //MessegeBox.Show("Nome:" + NomeUsuario);*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void administardorButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using HospitalControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using HospitalModels;

namespace WindowsForms.Forms
{
    public partial class Funcionarios : Form
    {
        CtlFuncionario funcionario = new CtlFuncionario();

        public Funcionarios()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void DgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //CtlFuncionario funcionario = new CtlFuncionario();
            var _funcionarios = funcionario.ListaFuncionarios();
            //DgvFuncionarios.DataSource = _funcionarios;

            if (!string.IsNullOrEmpty(CbIdCargo.Text.Split("-")[0]) && CbIdCargo.Text != "Qualquer cargo")
            {
                var idCargo = int.Parse(CbIdCargo.Text.Split("-")[0]);

                var dados = from func in _funcionarios
                            where func.Cargo.Id == idCargo
                            select new
                            {
                                func.Id,
                                func.Pessoa.Usuario.Login,
                                func.Pessoa.Nome,
                                func.Pessoa.Usuario.Email,
                                func.Salario,
                                Terceirizado = func.Terceirizado.ToString(),
                                CargoId = func.Cargo.Id,
                                Cargo = func.Cargo.Descricao,
                                DataNascimento = func.Pessoa.DataNascimento.Date
                            };

                DgvFuncionarios.DataSource = dados.ToList();
            }
            else
            {
                var dados = from func in _funcionarios
                            select new
                            {
                                func.Id,
                                func.Pessoa.Usuario.Login,
                                func.Pessoa.Nome,
                                func.Pessoa.Usuario.Email,
                                func.Salario,
                                Terceirizado = func.Terceirizado.ToString(),
                                CargoId = func.Cargo.Id,
                                Cargo = func.Cargo.Descricao,
                                DataNascimento = func.Pessoa.DataNascimento.Date
                            };

                DgvFuncionarios.DataSource = dados.ToList();
            }

        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtIdFuncionario.Text) || !int.TryParse(TxtIdFuncionario.Text, out int i))
                {
                    MessageBox.Show("Para deletar um funcionário é preciso que o campo ID Funcionário tenha um valor numérico");
                }
                else
                {
                    //CtlFuncionario funcionario = new CtlFuncionario();
                    int id = int.Parse(TxtIdFuncionario.Text);
                    var response = funcionario.DeletarFuncionario(id);
                    if(response.StatusCode.ToString() == "404")
                    {
                        MessageBox.Show("ID de funcionário inserido não existe no banco de dados");
                    }
                    else
                    {
                        MessageBox.Show($"Funcionário ID: {id} deletado!");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("(404) Not Found."))
                {
                    MessageBox.Show("ID de funcionário não encontrado no banco!");
                }
                
            }

        }

        private async void BtnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtSalario.Text) || string.IsNullOrEmpty(CbTerceirizado.Text) || string.IsNullOrEmpty(CbIdCargo.Text.Split("-")[0]) ||
                    string.IsNullOrEmpty(TxtNome.Text) || string.IsNullOrEmpty(TxtRg.Text) || string.IsNullOrEmpty(TxtCpf.Text) || string.IsNullOrEmpty(CbGenero.Text) ||
                    string.IsNullOrEmpty(TxtLogin.Text) || string.IsNullOrEmpty(TxtSenha.Text) || string.IsNullOrEmpty(TxtEmail.Text))
                {
                    MessageBox.Show("Para criar um funcionário todos os campos obrigatórios devem estar preenchidos:" +
                                        "\n\nCampos obrigatórios:\n" +
                                        "- Salario;\n" +
                                        "- Terceirizado;\n" +
                                        "- ID Cargo;\n" +
                                        "- Nome;\n" +
                                        "- RG;\n" +
                                        "- CPF;\n" +
                                        "- Genero;\n" +
                                        "- Login;\n" +
                                        "- Senha;\n" +
                                        "- Email;");
                }

                else if (!DateTime.TryParse(TxtDataNascimento.Text, out DateTime i))
                {
                    MessageBox.Show("Insira uma data válida. O formato deve ser yyyy-MM-dd!");
                }

                else
                {
                    //CtlFuncionario funcionario = new CtlFuncionario();

                    //MdlCargo mdlCargo = new MdlCargo()
                    //{
                    //    Id = int.Parse(TxtIdCargo.Text),
                    //    Descricao = TxtCargo.Text
                    //};

                    MdlUsuario mdlUsuario = new MdlUsuario()
                    {
                        Login = TxtLogin.Text,
                        Senha = TxtSenha.Text,
                        Email = TxtEmail.Text,
                        Ativo = true,
                        PerfilId = 3
                    };

                    MdlPessoa mdlPessoa = new MdlPessoa()
                    {
                        Nome = TxtNome.Text,
                        Cpf = TxtCpf.Text,
                        Rg = TxtRg.Text,
                        Genero = CbGenero.Text,
                        DataNascimento = DateTime.Parse(TxtDataNascimento.Text),
                        DataCriacao = DateTime.Now,
                        Usuario = mdlUsuario
                    };

                    MdlFuncionario mdlFuncionario = new MdlFuncionario()
                    {
                        Salario = decimal.Parse(TxtSalario.Text),
                        Terceirizado = bool.Parse(CbTerceirizado.Text),
                        CargoId = int.Parse(CbIdCargo.Text.Split("-")[0]),
                        Pessoa = mdlPessoa
                    };

                    var isOK = await funcionario.CriarFuncionarioNoBanco(mdlFuncionario);

                    if (isOK)
                    {
                        MessageBox.Show("Funcionário criado!");
                    }
                }
            }

            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            funcionario.AtualizarFuncionario();
        }

    }
}

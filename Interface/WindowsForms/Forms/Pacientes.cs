using HospitalControllers;
using HospitalModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class Pacientes : Form
    {
        CtlPaciente paciente = new CtlPaciente();

        public Pacientes()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var _pacientes = paciente.ListaPacientes();

            if (!string.IsNullOrEmpty(TxtIdPaciente.Text))
            {
                var idPaciente = int.Parse(TxtIdPaciente.Text);

                var dados = from pac in _pacientes
                            where pac.Id == idPaciente
                            select new
                            {
                                pac.Id,
                                pac.Pessoa.Usuario.Login,
                                pac.Pessoa.Nome,
                                pac.Pessoa.Usuario.Email,
                                pac.NumeroConvenio,
                                DataNascimento = pac.Pessoa.DataNascimento.Date,
                                pac.Pessoa.Genero,
                                pac.Pessoa.Cpf,
                                pac.Pessoa.Rg
                            };

                DgvPacientes.DataSource = dados.ToList();
            }

            else if (!string.IsNullOrEmpty(TxtNumConvenio.Text))
            {
                var numConvenioPac = TxtNumConvenio.Text;

                var dados = from pac in _pacientes
                            where pac.NumeroConvenio == numConvenioPac
                            select new
                            {
                                pac.Id,
                                pac.Pessoa.Usuario.Login,
                                pac.Pessoa.Nome,
                                pac.Pessoa.Usuario.Email,
                                pac.NumeroConvenio,
                                DataNascimento = pac.Pessoa.DataNascimento.Date,
                                pac.Pessoa.Genero,
                                pac.Pessoa.Cpf,
                                pac.Pessoa.Rg
                            };

                DgvPacientes.DataSource = dados.ToList();
            }

            else
            {
                var dados = from pac in _pacientes
                            select new
                            {
                                pac.Id,
                                pac.Pessoa.Usuario.Login,
                                pac.Pessoa.Nome,
                                pac.Pessoa.Usuario.Email,
                                pac.NumeroConvenio,
                                DataNascimento = pac.Pessoa.DataNascimento.Date,
                                pac.Pessoa.Genero,
                                pac.Pessoa.Cpf,
                                pac.Pessoa.Rg
                            };

                DgvPacientes.DataSource = dados.ToList();
            }
        }

        private async void BtnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCriacaoEAtualizacao())
                {
                }

                else
                {
                    MdlPaciente mdlPaciente = CriarObjetoPaciente();

                    var isOK = await paciente.CriarPacienteNoBanco(mdlPaciente);

                    if (isOK)
                    {
                        MessageBox.Show("Paciente criado!");
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtIdPaciente.Text) || !int.TryParse(TxtIdPaciente.Text, out int i))
                {
                    MessageBox.Show("Para deletar um paciente é preciso que o campo ID Paciente tenha um valor numérico");
                }
                else
                {
                    int id = int.Parse(TxtIdPaciente.Text);
                    var response = paciente.DeletarFuncionario(id);
                    if (response.StatusCode.ToString() == "404")
                    {
                        MessageBox.Show("ID de Paciente inserido não existe no banco de dados");
                    }
                    else
                    {
                        MessageBox.Show($"Paciente ID: {id} deletado!");
                    }

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("(404) Not Found."))
                {
                    MessageBox.Show("ID de Paciente não encontrado no banco!");
                }

            }
        }

        private async void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtIdPaciente.Text) || !int.TryParse(TxtIdPaciente.Text, out int i))
                {
                    MessageBox.Show("É preciso ter um ID de funcionário válido para atualizá-lo");
                }
                else
                {
                    List<MdlPaciente> funcionarios = paciente.ListaPacientes();
                    MdlPaciente funcionarioDoBanco = funcionarios.FirstOrDefault(wh => wh.Id == int.Parse(TxtIdPaciente.Text));

                    if (funcionarioDoBanco == null)
                    {
                        MessageBox.Show("Não existe paciente com este ID!");
                    }

                    else if (!ValidarCriacaoEAtualizacao())
                    {
                    }

                    else
                    {
                        MdlPaciente mdlPaciente = CriarObjetoPaciente();

                        if (funcionarioDoBanco.Equals(mdlPaciente))
                        {
                            MessageBox.Show("Os dados são iguais aos já registrados para este ID de paciente!");
                        }
                        else
                        {
                            var isOk = await paciente.AtualizarPaciente(mdlPaciente, int.Parse(TxtIdPaciente.Text));
                            if (isOk)
                            {
                                MessageBox.Show("Atualizado com sucesso!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarCriacaoEAtualizacao()
        {
            if (string.IsNullOrEmpty(TxtNumConvenio.Text) ||
                    string.IsNullOrEmpty(TxtNome.Text) || string.IsNullOrEmpty(TxtRg.Text) || string.IsNullOrEmpty(TxtNome.Text) || string.IsNullOrEmpty(CbGenero.Text) ||
                    string.IsNullOrEmpty(TxtLogin.Text) || string.IsNullOrEmpty(TxtSenha.Text) || string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Para criar/atualizar um funcionário todos os campos obrigatórios devem estar preenchidos:" +
                                    "\n\nCampos obrigatórios:\n" +
                                    "- Numero Convenio;\n" +
                                    "- Nome;\n" +
                                    "- RG;\n" +
                                    "- CPF;\n" +
                                    "- Genero;\n" +
                                    "- Data de Nascimento;\n" +
                                    "- Login;\n" +
                                    "- Senha;\n" +
                                    "- Email;") ;
                
                return false;
            }

            else if (!DateTime.TryParse(TxtDataNascimento.Text, out DateTime i))
            {
                MessageBox.Show("Insira uma data válida. O formato deve ser yyyy-MM-dd!");
                return false;
            }

            else
            {
                return true;
            }
        }

        private MdlPaciente CriarObjetoPaciente()
        {
            MdlUsuario mdlUsuario = new MdlUsuario()
            {
                Login = TxtLogin.Text,
                Senha = TxtSenha.Text,
                Email = TxtEmail.Text,
                Ativo = true,
                PerfilId = 2
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

            MdlPaciente mdlPaciente = new MdlPaciente()
            {
                NumeroConvenio = TxtNumConvenio.Text,
                Pessoa = mdlPessoa
            };

            return mdlPaciente;
        }

    }
}

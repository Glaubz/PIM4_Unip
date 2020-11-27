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
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }

        CtlMedico medico = new CtlMedico();

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var _medicos = medico.ListaMedicos();

            if (!string.IsNullOrEmpty(TxtIdMedico.Text))
            {
                var idFunc = int.Parse(TxtIdMedico.Text);

                var dados = from med in _medicos
                            where med.Id == idFunc
                            select new
                            {
                                med.Id,
                                med.Pessoa.Usuario.Login,
                                med.Pessoa.Nome,
                                med.Pessoa.Usuario.Email,
                                IdEspecialidade = med.EspecialidadeId,
                                med.Especialidade.Descricao,
                                DataNascimento = med.Pessoa.DataNascimento.Date,
                                med.Pessoa.Genero,
                                med.Pessoa.Cpf,
                                med.Pessoa.Rg
                            };

                DgvMedicos.DataSource = dados.ToList();
            }
            else if (!string.IsNullOrEmpty(CbIdEspecialidade.Text.Split("-")[0]) && CbIdEspecialidade.Text != "Qualquer especialidade")
            {
                var idEspecialidade = int.Parse(CbIdEspecialidade.Text.Split("-")[0]);

                var dados = from med in _medicos
                            where med.Especialidade.Id == idEspecialidade
                            select new
                            {
                                med.Id,
                                med.Pessoa.Usuario.Login,
                                med.Pessoa.Nome,
                                med.Pessoa.Usuario.Email,
                                IdEspecialidade = med.EspecialidadeId,
                                med.Especialidade.Descricao,
                                DataNascimento = med.Pessoa.DataNascimento.Date,
                                med.Pessoa.Genero,
                                med.Pessoa.Cpf,
                                med.Pessoa.Rg
                            };

                DgvMedicos.DataSource = dados.ToList();
            }
            else
            {
                var dados = from med in _medicos
                            select new
                            {
                                med.Id,
                                med.Pessoa.Usuario.Login,
                                med.Pessoa.Nome,
                                med.Pessoa.Usuario.Email,
                                IdEspecialidade = med.EspecialidadeId,
                                med.Especialidade.Descricao,
                                DataNascimento = med.Pessoa.DataNascimento.Date,
                                med.Pessoa.Genero,
                                med.Pessoa.Cpf,
                                med.Pessoa.Rg
                            };

                DgvMedicos.DataSource = dados.ToList();
            }
        }

        private async void BtnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCriacaoEAtualizacao())
                {
                }

                else if (string.IsNullOrEmpty(CbIdEspecialidade.Text) || CbIdEspecialidade.Text == "Qualquer especialidade")
                {
                    MessageBox.Show("Insira um ID de especialidade válido!");
                }

                else
                {
                    MdlMedico mdlMedico = CriarObjetoMedico();

                    var isOK = await medico.CriarMedicoNoBanco(mdlMedico);

                    if (isOK)
                    {
                        MessageBox.Show("Médico criado!");
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
                if (string.IsNullOrEmpty(TxtIdMedico.Text) || !int.TryParse(TxtIdMedico.Text, out int i))
                {
                    MessageBox.Show("Para deletar um médico é preciso que o campo ID Médico tenha um valor numérico");
                }
                else
                {
                    int id = int.Parse(TxtIdMedico.Text);
                    var response = medico.DeletarMedico(id);
                    if (response.StatusCode.ToString() == "404")
                    {
                        MessageBox.Show("ID de médico inserido não existe no banco de dados");
                    }
                    else
                    {
                        MessageBox.Show($"Médico ID: {id} deletado!");
                    }

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("(404) Not Found."))
                {
                    MessageBox.Show("ID de médico não encontrado no banco!");
                }

            }
        }

        private async void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtIdMedico.Text) || !int.TryParse(TxtIdMedico.Text, out int i))
                {
                    MessageBox.Show("É preciso ter um ID de médico válido para atualizá-lo");
                }
                else
                {
                    List<MdlMedico> medicos = medico.ListaMedicos();
                    MdlMedico medicoDoBanco = medicos.FirstOrDefault(wh => wh.Id == int.Parse(TxtIdMedico.Text));

                    if (medicoDoBanco == null)
                    {
                        MessageBox.Show("Não existe médico com este ID!");
                    }

                    else if (!ValidarCriacaoEAtualizacao())
                    {
                    }

                    else
                    {
                        MdlMedico mdlMedico = CriarObjetoMedico();

                        if (medicoDoBanco.Equals(mdlMedico))
                        {
                            MessageBox.Show("Os dados são iguais aos já registrados para este ID de médico!");
                        }
                        else
                        {
                            var isOk = await medico.AtualizarMedico(mdlMedico, int.Parse(TxtIdMedico.Text));
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
            if (string.IsNullOrEmpty(TxtCrm.Text) || string.IsNullOrEmpty(CbIdEspecialidade.Text.Split("-")[0]) ||
                    string.IsNullOrEmpty(TxtNome.Text) || string.IsNullOrEmpty(TxtRg.Text) || string.IsNullOrEmpty(TxtCpf.Text) || string.IsNullOrEmpty(CbGenero.Text) ||
                    string.IsNullOrEmpty(TxtLogin.Text) || string.IsNullOrEmpty(TxtSenha.Text) || string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Para criar/atualizar um médico todos os campos obrigatórios devem estar preenchidos:" +
                                    "\n\nCampos obrigatórios:\n" +
                                    "- Salario;\n" +
                                    "- ID Especialidade;\n" +
                                    "- Nome;\n" +
                                    "- RG;\n" +
                                    "- CPF;\n" +
                                    "- Genero;\n" +
                                    "- Login;\n" +
                                    "- Senha;\n" +
                                    "- Email;\n" +
                                    "- Data de Nascimento;");

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

        private MdlMedico CriarObjetoMedico()
        {
            //MdlEspecialidade mdlEspecialidade = new MdlEspecialidade()
            //{
            //    Id = int.Parse(CbIdEspecialidade.Text.Split("-")[0]),
            //    Descricao = CbIdEspecialidade.Text.Split("-")[1]
            //};

            MdlUsuario mdlUsuario = new MdlUsuario()
            {
                Login = TxtLogin.Text,
                Senha = TxtSenha.Text,
                Email = TxtEmail.Text,
                Ativo = true,
                PerfilId = 1
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

            MdlMedico mdlMedico = new MdlMedico()
            {
                CRM = TxtCrm.Text,
                EspecialidadeId = int.Parse(CbIdEspecialidade.Text.Split("-")[0]),
                Pessoa = mdlPessoa
                //Especialidade = mdlEspecialidade
            };

            return mdlMedico;
        }

    }
}

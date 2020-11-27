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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        CtlConsulta consulta = new CtlConsulta();

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var _consultas = consulta.ListaConsultas();

            if (!string.IsNullOrEmpty(TxtIdConsulta.Text))
            {
                var idFunc = int.Parse(TxtIdConsulta.Text);

                var dados = from cons in _consultas
                            where cons.Id == idFunc
                            select new
                            {
                                cons.Id,
                                cons.DataConsulta,
                                cons.DataRetorno,
                                cons.DescricaoEnfermidade,
                                cons.PacienteId,
                                cons.NomePaciente,
                                cons.MedicoConsulta.MedicoId,
                                cons.NomeMedico
                            };

                DgvConsultas.DataSource = dados.ToList();
            }

            else if (!string.IsNullOrEmpty(TxtIdPaciente.Text))
            {
                var idPac = int.Parse(TxtIdPaciente.Text);

                var dados = from cons in _consultas
                            where cons.PacienteId == idPac
                            select new
                            {
                                cons.Id,
                                cons.DataConsulta,
                                cons.DataRetorno,
                                cons.DescricaoEnfermidade,
                                cons.PacienteId,
                                cons.NomePaciente,
                                cons.MedicoConsulta.MedicoId,
                                cons.NomeMedico
                            };

                DgvConsultas.DataSource = dados.ToList();
            }

            else if (!string.IsNullOrEmpty(TxtIdMedico.Text))
            {
                var idMed = int.Parse(TxtIdMedico.Text);

                var dados = from cons in _consultas
                            where cons.MedicoConsulta.MedicoId == idMed
                            select new
                            {
                                cons.Id,
                                cons.DataConsulta,
                                cons.DataRetorno,
                                cons.DescricaoEnfermidade,
                                cons.PacienteId,
                                cons.NomePaciente,
                                cons.MedicoConsulta.MedicoId,
                                cons.NomeMedico
                            };

                DgvConsultas.DataSource = dados.ToList();
            }

            else
            {
                var dados = from cons in _consultas
                            select new
                            {
                                cons.Id,
                                cons.DataConsulta,
                                cons.DataRetorno,
                                cons.DescricaoEnfermidade,
                                cons.PacienteId,
                                cons.NomePaciente,
                                cons.MedicoConsulta.MedicoId,
                                cons.NomeMedico
                            };

                DgvConsultas.DataSource = dados.ToList();
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
                    MdlConsulta mdlConsulta = CriarObjetoConsulta();

                    var isOK = await consulta.CriarConsultaNoBanco(mdlConsulta);

                    if (isOK)
                    {
                        MessageBox.Show("Funcionário criado!");
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
                if (string.IsNullOrEmpty(TxtIdConsulta.Text) || !int.TryParse(TxtIdConsulta.Text, out int i))
                {
                    MessageBox.Show("Para deletar uma consulta é preciso que o campo ID Consulta tenha um valor numérico");
                }
                else
                {
                    int id = int.Parse(TxtIdConsulta.Text);
                    var response = consulta.DeletarConsulta(id);
                    if (response.StatusCode.ToString() == "404")
                    {
                        MessageBox.Show("ID de consulta inserido não existe no banco de dados");
                    }
                    else
                    {
                        MessageBox.Show($"Consulta ID: {id} deletado!");
                    }

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("(404) Not Found."))
                {
                    MessageBox.Show("ID de consulta não encontrado no banco!");
                }

            }
        }

        private async void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtIdConsulta.Text) || !int.TryParse(TxtIdConsulta.Text, out int i))
                {
                    MessageBox.Show("É preciso ter um ID de consulta válido para atualizá-lo");
                }
                else
                {
                    List<MdlConsulta> consultas = consulta.ListaConsultas();
                    MdlConsulta consultaDoBanco = consultas.FirstOrDefault(wh => wh.Id == int.Parse(TxtIdConsulta.Text));

                    if (consultaDoBanco == null)
                    {
                        MessageBox.Show("Não existe consulta com este ID!");
                    }

                    else if (!ValidarCriacaoEAtualizacao())
                    {
                    }

                    else
                    {
                        MdlConsulta mdlConsulta = CriarObjetoConsulta();

                        if (consultaDoBanco.Equals(mdlConsulta))
                        {
                            MessageBox.Show("Os dados são iguais aos já registrados para este ID de funcionário!");
                        }
                        else
                        {
                            var isOk = await consulta.AtualizarConsulta(mdlConsulta, int.Parse(TxtIdConsulta.Text));
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
            if (string.IsNullOrEmpty(TxtDataConsulta.Text) ||
                    string.IsNullOrEmpty(TxtIdPaciente.Text) || string.IsNullOrEmpty(TxtNomeDoPaciente.Text) || 
                    string.IsNullOrEmpty(TxtIdMedico.Text) || string.IsNullOrEmpty(TxtNomeMedico.Text) || 
                    string.IsNullOrEmpty(TxtDescricaoEnfermidade.Text))
            {
                MessageBox.Show("Para criar/atualizar um funcionário todos os campos obrigatórios devem estar preenchidos:" +
                                    "\n\nCampos obrigatórios:\n" +
                                    "- Data de Consulta;\n" +
                                    "- ID Paciente;\n" +
                                    "- Nome Paciente;\n" +
                                    "- ID Médico;\n" +
                                    "- Nome Médico;");

                return false;
            }

            else if (!DateTime.TryParse(TxtDataConsulta.Text, out DateTime i))
            {
                MessageBox.Show("Insira uma data válida para data de consulta. O formato deve ser yyyy-MM-dd!");
                return false;
            }

            else if (!DateTime.TryParse(TxtDataRetorno.Text, out DateTime i2) && !string.IsNullOrEmpty(TxtDataRetorno.Text))
            {
                MessageBox.Show("Insira uma data válida para data de retorno. O formato deve ser yyyy-MM-dd ou o campo deve estar vazio!");
                return false;
            }

            else
            {
                return true;
            }
        }

        private MdlConsulta CriarObjetoConsulta()
        {

            MdlConsulta mdlConsulta = new MdlConsulta()
            {
                DataConsulta = DateTime.Parse(TxtDataConsulta.Text),
                DataRetorno = DateTime.Parse(TxtDataRetorno.Text),

            };

            if (!string.IsNullOrEmpty(TxtDataRetorno.Text))
            {
                mdlConsulta.Retorno = true;
            }

            return mdlConsulta;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjetoOrientacao.Application.ApplicationImplementation;
using ProjetoOrientacao.Data;

namespace ProjetoOrientacao.WinForms
{
    public partial class FormTipoEntrega : Form
    {
        private readonly TipoEntregaApplication TipoEntregaApplication = new TipoEntregaApplication();
        private TipoEntrega tipoEntrega;

        public FormTipoEntrega()
        {
            InitializeComponent();
        }

        private void FormTipoEntrega_Load(object sender, EventArgs e)
        {
            dataGridViewTipoEntrega.ColumnCount = 2;
            dataGridViewTipoEntrega.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewTipoEntrega.MultiSelect = false;
            dataGridViewTipoEntrega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewTipoEntrega.Columns[0].HeaderText = "Código Tipo Entrega";
            dataGridViewTipoEntrega.Columns[0].DataPropertyName = "IdTipoEntrega";
            dataGridViewTipoEntrega.Columns[0].Width = 200;
            dataGridViewTipoEntrega.Columns[0].Name = "IdTipoEntrega";

            dataGridViewTipoEntrega.Columns[1].HeaderText = "Descrição Tipo Entrega";
            dataGridViewTipoEntrega.Columns[1].DataPropertyName = "Descricao";
            dataGridViewTipoEntrega.Columns[1].Width = 300;
            dataGridViewTipoEntrega.Columns[1].Name = "Descricao";
                        
            CarregarDados();

        }

        private void CarregarDados()
        {
            dataGridViewTipoEntrega.DataSource =
                TipoEntregaApplication.TodosTiposEntrega().Select(x => new
                {
                    x.IdTipoEntrega,
                    x.Descricao
                }).ToList();
        }

        private void buttonSalvarTipoEntrega_Click(object sender, EventArgs e)
        {
            if (tipoEntrega == null)
                tipoEntrega = new TipoEntrega();

            int idTipoEntrega = 0;

            int.TryParse(textBoxCodigoTipoEntrega.Text, out idTipoEntrega);

            //idTipoEntrega = Convert.ToInt16(textBoxCodigoTipoEntrega.Text);

            tipoEntrega.IdTipoEntrega = idTipoEntrega;
            tipoEntrega.Descricao = textBoxDescricaoTipoEntrega.Text;

            var erros = TipoEntregaApplication.SalvarTipoEntrega(tipoEntrega);

            if (erros.Count == 0)
            {
                MessageBox.Show("Tipo de Entrega Salvo com Sucesso!");
                CarregarDados();
                LimparCampos();
            }

            else
            {
                MessageBox.Show("Erro ao salvar Tipo de Entrega" 
                    + erros.FirstOrDefault());
            }

        }

        private void LimparCampos()
        {
            textBoxCodigoTipoEntrega.Clear();
            textBoxDescricaoTipoEntrega.Clear();
            tipoEntrega = null;
        }

        private void buttonExcluirTipoEntrega_Click(object sender, EventArgs e)
        {
            if (dataGridViewTipoEntrega.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridViewTipoEntrega.SelectedRows[0];
                int idTipoEntrega = (int)linha.Cells["IdTipoEntrega"].Value;

                tipoEntrega = TipoEntregaApplication.ObterTipoEntrega
                    (
                        x => x.IdTipoEntrega == idTipoEntrega
                    );

                var erros = TipoEntregaApplication.ExcluirTipoEntrega(tipoEntrega);

                if (erros.Count == 0)
                {
                    MessageBox.Show("Tipo de Entrega excluído com sucesso!");
                    CarregarDados();
                    LimparCampos();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir " + erros.FirstOrDefault());
                }
            }

            else
            {
                MessageBox.Show("Selecione um Tipo de Entrega para excluir!");
            }
        }

        private void buttonEditarTipoEntrega_Click(object sender, EventArgs e)
        {
            if (dataGridViewTipoEntrega.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridViewTipoEntrega.SelectedRows[0];
                int idTipoEntrega = (int)linha.Cells["IdTipoEntrega"].Value;

                tipoEntrega = TipoEntregaApplication.ObterTipoEntrega
                    (x => x.IdTipoEntrega == idTipoEntrega);

                textBoxCodigoTipoEntrega.Text = tipoEntrega.IdTipoEntrega.ToString();
                textBoxDescricaoTipoEntrega.Text = tipoEntrega.Descricao;
            }

            else
            {
                MessageBox.Show("Selecone um Tipo de Entrega para alterar!");
            }
        }
    }
}

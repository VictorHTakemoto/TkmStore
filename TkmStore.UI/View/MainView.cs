using System.ComponentModel;
using TkmStore.DAL.Model.Entity;
using TkmStore.UI.Controller;

namespace TkmStore.UI.View
{
    public partial class MainView : Form
    {
        //Form principal
        private BindingList<Cliente> clientes;
        public MainView()
        {
            InitializeComponent();
            clientes = new BindingList<Cliente>();
            dataGridView1.DataSource = clientes;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //configuracao para que o usuario nao possa alterar o ID
            dataGridView1.Columns["IdCliente"].ReadOnly = true;
        }

        //Funcao responsavel por realizar novos cadastros
        private void NovoUsuarioBtn_Click(object sender, EventArgs e)
        {
            CadastroClientes cadastro = new CadastroClientes();
            cadastro.ShowDialog();
        }

        //Funcao responsavel por buscar os dados do banco e exibir na lista
        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager();
                List<Cliente> clientes = userManager.BuscarCadastro();
                var bindingList = new BindingList<Cliente>(clientes);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deu Erro: {ex}");
            }
        }

        //Funcao responsavel por atualizar os dados do cadastro
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                UserManager userManager = new UserManager();
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Cliente cliente = dataGridView1.Rows[e.RowIndex].DataBoundItem as Cliente;
                string result = userManager.UpdateCadastro(cliente);
            }
        }

        //Funcao responsavel por excluir registros do banco
        private void ExcluirRegistro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
                Cliente cliente = linhaSelecionada.DataBoundItem as Cliente;
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes) 
                {
                    UserManager userManager = new UserManager();
                    string result = userManager.RemoverCadastro(cliente);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    MessageBox.Show(result);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
    }
}

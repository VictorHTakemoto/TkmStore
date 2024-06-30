using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TkmStore.DAL.Model.Entity;
using TkmStore.UI.Controller;

namespace TkmStore.UI.View
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || 
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Prencha todos campos");
                return;
            }
            var result = userManager.NovoCadastro(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            this.Close();
            MessageBox.Show(result);
        }
    }
}

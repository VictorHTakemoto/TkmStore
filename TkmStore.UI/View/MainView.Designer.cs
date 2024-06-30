namespace TkmStore.UI.View
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CadastroBtn = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ExcluirRegistro = new Button();
            textBox1 = new TextBox();
            BuscarBtn = new Button();
            dataGridView1 = new DataGridView();
            NovoUsuarioBtn = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // CadastroBtn
            // 
            CadastroBtn.Location = new Point(6, 449);
            CadastroBtn.Name = "CadastroBtn";
            CadastroBtn.RightToLeft = RightToLeft.Yes;
            CadastroBtn.Size = new Size(75, 23);
            CadastroBtn.TabIndex = 0;
            CadastroBtn.Text = "Cadastro";
            CadastroBtn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1259, 675);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ExcluirRegistro);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(BuscarBtn);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(NovoUsuarioBtn);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1251, 647);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuários";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ExcluirRegistro
            // 
            ExcluirRegistro.Location = new Point(769, 79);
            ExcluirRegistro.Name = "ExcluirRegistro";
            ExcluirRegistro.Size = new Size(75, 23);
            ExcluirRegistro.TabIndex = 4;
            ExcluirRegistro.Text = "Excluir";
            ExcluirRegistro.UseVisualStyleBackColor = true;
            ExcluirRegistro.Click += ExcluirRegistro_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(769, 50);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(75, 23);
            BuscarBtn.TabIndex = 2;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(6, 107);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(838, 342);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // NovoUsuarioBtn
            // 
            NovoUsuarioBtn.Location = new Point(6, 455);
            NovoUsuarioBtn.Name = "NovoUsuarioBtn";
            NovoUsuarioBtn.Size = new Size(92, 23);
            NovoUsuarioBtn.TabIndex = 0;
            NovoUsuarioBtn.Text = "Novo Usuário";
            NovoUsuarioBtn.UseVisualStyleBackColor = true;
            NovoUsuarioBtn.Click += NovoUsuarioBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CadastroBtn);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1251, 647);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Produtos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1251, 647);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Vendas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControl1);
            Name = "MainView";
            Text = "MainView";
            Load += MainView_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CadastroBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button NovoUsuarioBtn;
        private DataGridView dataGridView1;
        private Button BuscarBtn;
        private TextBox textBox1;
        private Button ExcluirRegistro;
    }
}
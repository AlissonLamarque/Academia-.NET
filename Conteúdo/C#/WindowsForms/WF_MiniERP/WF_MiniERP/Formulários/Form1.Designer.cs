namespace WF_MiniERP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_titulo = new Label();
            button_CadastroProduto = new Button();
            button_CadastroFornecedor = new Button();
            button_CadastroCliente = new Button();
            groupBox_Cadastro = new GroupBox();
            button_Compra = new Button();
            groupBox_Notas = new GroupBox();
            listView_Nota = new ListView();
            columnHeader_Produto = new ColumnHeader();
            columnHeader_Fornecedor = new ColumnHeader();
            columnHeader_Cliente = new ColumnHeader();
            button_Sair = new Button();
            groupBox_Cadastro.SuspendLayout();
            groupBox_Notas.SuspendLayout();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(326, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(124, 37);
            label_titulo.TabIndex = 0;
            label_titulo.Text = "MiniEPR";
            // 
            // button_CadastroProduto
            // 
            button_CadastroProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_CadastroProduto.Location = new Point(53, 41);
            button_CadastroProduto.Name = "button_CadastroProduto";
            button_CadastroProduto.Size = new Size(126, 31);
            button_CadastroProduto.TabIndex = 1;
            button_CadastroProduto.Text = "PRODUTO";
            button_CadastroProduto.UseVisualStyleBackColor = true;
            button_CadastroProduto.Click += button_CadastroProduto_Click;
            // 
            // button_CadastroFornecedor
            // 
            button_CadastroFornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_CadastroFornecedor.Location = new Point(53, 134);
            button_CadastroFornecedor.Name = "button_CadastroFornecedor";
            button_CadastroFornecedor.Size = new Size(126, 31);
            button_CadastroFornecedor.TabIndex = 2;
            button_CadastroFornecedor.Text = "FORNECEDOR";
            button_CadastroFornecedor.UseVisualStyleBackColor = true;
            button_CadastroFornecedor.Click += button_CadastroFornecedor_Click;
            // 
            // button_CadastroCliente
            // 
            button_CadastroCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_CadastroCliente.Location = new Point(53, 90);
            button_CadastroCliente.Name = "button_CadastroCliente";
            button_CadastroCliente.Size = new Size(126, 27);
            button_CadastroCliente.TabIndex = 3;
            button_CadastroCliente.Text = "CLIENTE";
            button_CadastroCliente.UseVisualStyleBackColor = true;
            button_CadastroCliente.Click += button_CadastroCliente_Click;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(button_Compra);
            groupBox_Cadastro.Controls.Add(button_CadastroFornecedor);
            groupBox_Cadastro.Controls.Add(button_CadastroProduto);
            groupBox_Cadastro.Controls.Add(button_CadastroCliente);
            groupBox_Cadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Cadastro.Location = new Point(29, 80);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(237, 268);
            groupBox_Cadastro.TabIndex = 5;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "ÁREA DE CADASTRO";
            // 
            // button_Compra
            // 
            button_Compra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Compra.Location = new Point(53, 186);
            button_Compra.Name = "button_Compra";
            button_Compra.Size = new Size(126, 58);
            button_Compra.TabIndex = 4;
            button_Compra.Text = "REALIZAR COMPRA";
            button_Compra.UseVisualStyleBackColor = true;
            button_Compra.Click += button_Compra_Click;
            // 
            // groupBox_Notas
            // 
            groupBox_Notas.Controls.Add(listView_Nota);
            groupBox_Notas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Notas.Location = new Point(341, 80);
            groupBox_Notas.Name = "groupBox_Notas";
            groupBox_Notas.Size = new Size(405, 268);
            groupBox_Notas.TabIndex = 6;
            groupBox_Notas.TabStop = false;
            groupBox_Notas.Text = "NOTAS";
            // 
            // listView_Nota
            // 
            listView_Nota.BackColor = SystemColors.Control;
            listView_Nota.BorderStyle = BorderStyle.None;
            listView_Nota.Columns.AddRange(new ColumnHeader[] { columnHeader_Produto, columnHeader_Fornecedor, columnHeader_Cliente });
            listView_Nota.Dock = DockStyle.Fill;
            listView_Nota.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listView_Nota.Location = new Point(3, 29);
            listView_Nota.Name = "listView_Nota";
            listView_Nota.Size = new Size(399, 236);
            listView_Nota.TabIndex = 0;
            listView_Nota.UseCompatibleStateImageBehavior = false;
            listView_Nota.View = View.Details;
            // 
            // columnHeader_Produto
            // 
            columnHeader_Produto.Text = "Produto";
            columnHeader_Produto.Width = 132;
            // 
            // columnHeader_Fornecedor
            // 
            columnHeader_Fornecedor.Text = "Fornecedor";
            columnHeader_Fornecedor.Width = 132;
            // 
            // columnHeader_Cliente
            // 
            columnHeader_Cliente.Text = "Cliente";
            columnHeader_Cliente.Width = 132;
            // 
            // button_Sair
            // 
            button_Sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Sair.Location = new Point(326, 391);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(124, 34);
            button_Sair.TabIndex = 7;
            button_Sair.Text = "SAIR";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Sair);
            Controls.Add(groupBox_Notas);
            Controls.Add(label_titulo);
            Controls.Add(groupBox_Cadastro);
            Name = "Form1";
            Text = "Form1";
            groupBox_Cadastro.ResumeLayout(false);
            groupBox_Notas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Button button_CadastroProduto;
        private Button button_CadastroFornecedor;
        private Button button_CadastroCliente;
        private GroupBox groupBox_Cadastro;
        private GroupBox groupBox_Notas;
        private ListView listView_Nota;
        private ColumnHeader columnHeader_Produto;
        private ColumnHeader columnHeader_Fornecedor;
        private ColumnHeader columnHeader_Cliente;
        private Button button_Sair;
        private Button button_Compra;
    }
}
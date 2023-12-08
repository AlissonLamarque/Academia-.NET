namespace _13_MiniERPcomEntity
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
            label_Titulo = new Label();
            groupBox_Cadastro = new GroupBox();
            groupBox2 = new GroupBox();
            button_Produto = new Button();
            button_Compra = new Button();
            button_Cliente = new Button();
            button_Fornecedor = new Button();
            button_Sair = new Button();
            listView_Lista = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox_Lista = new GroupBox();
            groupBox_Cadastro.SuspendLayout();
            groupBox_Lista.SuspendLayout();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(251, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(278, 37);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "Sistema de Compras";
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(groupBox2);
            groupBox_Cadastro.Controls.Add(button_Produto);
            groupBox_Cadastro.Controls.Add(button_Compra);
            groupBox_Cadastro.Controls.Add(button_Cliente);
            groupBox_Cadastro.Controls.Add(button_Fornecedor);
            groupBox_Cadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Cadastro.Location = new Point(29, 80);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(237, 268);
            groupBox_Cadastro.TabIndex = 1;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "ÁREA DE CADASTRO";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(341, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 268);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista";
            // 
            // button_Produto
            // 
            button_Produto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Produto.Location = new Point(53, 41);
            button_Produto.Name = "button_Produto";
            button_Produto.Size = new Size(126, 31);
            button_Produto.TabIndex = 1;
            button_Produto.Text = "PRODUTO";
            button_Produto.UseVisualStyleBackColor = true;
            button_Produto.Click += button_Produto_Click;
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
            // button_Cliente
            // 
            button_Cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cliente.Location = new Point(53, 90);
            button_Cliente.Name = "button_Cliente";
            button_Cliente.Size = new Size(126, 27);
            button_Cliente.TabIndex = 2;
            button_Cliente.Text = "CLIENTE";
            button_Cliente.UseVisualStyleBackColor = true;
            button_Cliente.Click += button_Cliente_Click;
            // 
            // button_Fornecedor
            // 
            button_Fornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Fornecedor.Location = new Point(53, 134);
            button_Fornecedor.Name = "button_Fornecedor";
            button_Fornecedor.Size = new Size(126, 31);
            button_Fornecedor.TabIndex = 3;
            button_Fornecedor.Text = "FORNECEDOR";
            button_Fornecedor.UseVisualStyleBackColor = true;
            button_Fornecedor.Click += button_Fornecedor_Click;
            // 
            // button_Sair
            // 
            button_Sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Sair.Location = new Point(326, 391);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(124, 34);
            button_Sair.TabIndex = 0;
            button_Sair.Text = "SAIR";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // listView_Lista
            // 
            listView_Lista.BackColor = SystemColors.Control;
            listView_Lista.BorderStyle = BorderStyle.None;
            listView_Lista.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView_Lista.Dock = DockStyle.Fill;
            listView_Lista.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listView_Lista.Location = new Point(3, 29);
            listView_Lista.Name = "listView_Lista";
            listView_Lista.Size = new Size(399, 236);
            listView_Lista.TabIndex = 5;
            listView_Lista.UseCompatibleStateImageBehavior = false;
            listView_Lista.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Produtos";
            columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Clientes";
            columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fornecedores";
            columnHeader3.Width = 132;
            // 
            // groupBox_Lista
            // 
            groupBox_Lista.Controls.Add(listView_Lista);
            groupBox_Lista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Lista.Location = new Point(341, 80);
            groupBox_Lista.Name = "groupBox_Lista";
            groupBox_Lista.Size = new Size(405, 268);
            groupBox_Lista.TabIndex = 6;
            groupBox_Lista.TabStop = false;
            groupBox_Lista.Text = "LISTA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Lista);
            Controls.Add(button_Sair);
            Controls.Add(groupBox_Cadastro);
            Controls.Add(label_Titulo);
            Name = "Form1";
            Text = "Desafio MiniERP com Entity";
            groupBox_Cadastro.ResumeLayout(false);
            groupBox_Lista.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private GroupBox groupBox_Cadastro;
        private GroupBox groupBox2;
        private Button button_Sair;
        private Button button_Produto;
        private Button button_Cliente;
        private Button button_Fornecedor;
        private Button button_Compra;
        private ListView listView_Lista;
        private GroupBox groupBox_Lista;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
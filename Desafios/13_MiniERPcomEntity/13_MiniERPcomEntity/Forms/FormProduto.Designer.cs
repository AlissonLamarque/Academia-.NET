namespace _13_MiniERPcomEntity.Forms
{
    partial class FormProduto
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
            label_Produto = new Label();
            label_Nome = new Label();
            label_Desc = new Label();
            label_Valor = new Label();
            label_Fornecedor = new Label();
            textBox_Nome = new TextBox();
            textBox_Desc = new TextBox();
            textBox_Valor = new TextBox();
            numericUpDown_Fornecedor = new NumericUpDown();
            button_Enviar = new Button();
            button_Fornecedores = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fornecedor).BeginInit();
            SuspendLayout();
            // 
            // label_Produto
            // 
            label_Produto.AutoSize = true;
            label_Produto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Produto.Location = new Point(110, 9);
            label_Produto.Name = "label_Produto";
            label_Produto.Size = new Size(113, 30);
            label_Produto.TabIndex = 0;
            label_Produto.Text = "PRODUTO";
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nome.Location = new Point(81, 66);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(57, 21);
            label_Nome.TabIndex = 1;
            label_Nome.Text = "Nome";
            // 
            // label_Desc
            // 
            label_Desc.AutoSize = true;
            label_Desc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Desc.Location = new Point(81, 135);
            label_Desc.Name = "label_Desc";
            label_Desc.Size = new Size(84, 21);
            label_Desc.TabIndex = 2;
            label_Desc.Text = "Descrição";
            // 
            // label_Valor
            // 
            label_Valor.AutoSize = true;
            label_Valor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Valor.Location = new Point(81, 250);
            label_Valor.Name = "label_Valor";
            label_Valor.Size = new Size(101, 21);
            label_Valor.TabIndex = 3;
            label_Valor.Text = "Valor em R$";
            // 
            // label_Fornecedor
            // 
            label_Fornecedor.AutoSize = true;
            label_Fornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Fornecedor.Location = new Point(81, 330);
            label_Fornecedor.Name = "label_Fornecedor";
            label_Fornecedor.Size = new Size(96, 21);
            label_Fornecedor.TabIndex = 4;
            label_Fornecedor.Text = "Fornecedor";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(81, 90);
            textBox_Nome.MaxLength = 50;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.PlaceholderText = "Nome do produto";
            textBox_Nome.Size = new Size(178, 23);
            textBox_Nome.TabIndex = 5;
            textBox_Nome.KeyPress += textBox_Nome_KeyPress;
            // 
            // textBox_Desc
            // 
            textBox_Desc.Location = new Point(81, 159);
            textBox_Desc.MaxLength = 200;
            textBox_Desc.Multiline = true;
            textBox_Desc.Name = "textBox_Desc";
            textBox_Desc.PlaceholderText = "Breve descrição sobre o produto";
            textBox_Desc.Size = new Size(178, 67);
            textBox_Desc.TabIndex = 6;
            textBox_Desc.KeyPress += textBox_Desc_KeyPress;
            // 
            // textBox_Valor
            // 
            textBox_Valor.Location = new Point(81, 274);
            textBox_Valor.MaxLength = 18;
            textBox_Valor.Name = "textBox_Valor";
            textBox_Valor.PlaceholderText = "Valor do produto";
            textBox_Valor.Size = new Size(178, 23);
            textBox_Valor.TabIndex = 7;
            textBox_Valor.KeyPress += textBox_Valor_KeyPress;
            // 
            // numericUpDown_Fornecedor
            // 
            numericUpDown_Fornecedor.Location = new Point(81, 354);
            numericUpDown_Fornecedor.Name = "numericUpDown_Fornecedor";
            numericUpDown_Fornecedor.Size = new Size(142, 23);
            numericUpDown_Fornecedor.TabIndex = 8;
            // 
            // button_Enviar
            // 
            button_Enviar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Enviar.Location = new Point(110, 408);
            button_Enviar.Name = "button_Enviar";
            button_Enviar.Size = new Size(113, 30);
            button_Enviar.TabIndex = 9;
            button_Enviar.Text = "ENVIAR";
            button_Enviar.UseVisualStyleBackColor = true;
            button_Enviar.Click += button_Enviar_Click;
            // 
            // button_Fornecedores
            // 
            button_Fornecedores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Fornecedores.Location = new Point(229, 354);
            button_Fornecedores.Name = "button_Fornecedores";
            button_Fornecedores.Size = new Size(30, 23);
            button_Fornecedores.TabIndex = 10;
            button_Fornecedores.Text = "...";
            button_Fornecedores.UseVisualStyleBackColor = true;
            button_Fornecedores.Click += button_Fornecedores_Click;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 450);
            Controls.Add(button_Fornecedores);
            Controls.Add(button_Enviar);
            Controls.Add(numericUpDown_Fornecedor);
            Controls.Add(textBox_Valor);
            Controls.Add(textBox_Desc);
            Controls.Add(textBox_Nome);
            Controls.Add(label_Fornecedor);
            Controls.Add(label_Valor);
            Controls.Add(label_Desc);
            Controls.Add(label_Nome);
            Controls.Add(label_Produto);
            Name = "FormProduto";
            Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Produto;
        private Label label_Nome;
        private Label label_Desc;
        private Label label_Valor;
        private Label label_Fornecedor;
        private TextBox textBox_Nome;
        private TextBox textBox_Desc;
        private TextBox textBox_Valor;
        private NumericUpDown numericUpDown_Fornecedor;
        private Button button_Enviar;
        private Button button_Fornecedores;
    }
}
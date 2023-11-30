namespace WF_MiniERP
{
    partial class Form_Produto
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
            label_Titulo = new Label();
            button_Enviar = new Button();
            label_Nome = new Label();
            label_Descricao = new Label();
            textBox_Nome = new TextBox();
            textBox_Descricao = new TextBox();
            label_Valor = new Label();
            textBox_Valor = new TextBox();
            numericUpDown_Fornecedor = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fornecedor).BeginInit();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(110, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(113, 30);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "PRODUTO";
            // 
            // button_Enviar
            // 
            button_Enviar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Enviar.Location = new Point(110, 408);
            button_Enviar.Name = "button_Enviar";
            button_Enviar.Size = new Size(113, 30);
            button_Enviar.TabIndex = 1;
            button_Enviar.Text = "ENVIAR";
            button_Enviar.UseVisualStyleBackColor = true;
            button_Enviar.Click += button_Enviar_Click;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nome.Location = new Point(81, 66);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(57, 21);
            label_Nome.TabIndex = 2;
            label_Nome.Text = "Nome";
            // 
            // label_Descricao
            // 
            label_Descricao.AutoSize = true;
            label_Descricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Descricao.Location = new Point(81, 135);
            label_Descricao.Name = "label_Descricao";
            label_Descricao.Size = new Size(84, 21);
            label_Descricao.TabIndex = 3;
            label_Descricao.Text = "Descrição";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(81, 90);
            textBox_Nome.MaxLength = 50;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.PlaceholderText = "Nome do produto";
            textBox_Nome.Size = new Size(178, 23);
            textBox_Nome.TabIndex = 4;
            textBox_Nome.KeyPress += textBox_Nome_KeyPress;
            // 
            // textBox_Descricao
            // 
            textBox_Descricao.Location = new Point(81, 159);
            textBox_Descricao.MaxLength = 200;
            textBox_Descricao.Multiline = true;
            textBox_Descricao.Name = "textBox_Descricao";
            textBox_Descricao.PlaceholderText = "Breve descrição sobre o produto";
            textBox_Descricao.Size = new Size(178, 67);
            textBox_Descricao.TabIndex = 5;
            textBox_Descricao.KeyPress += textBox_Descricao_KeyPress;
            // 
            // label_Valor
            // 
            label_Valor.AutoSize = true;
            label_Valor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Valor.Location = new Point(81, 250);
            label_Valor.Name = "label_Valor";
            label_Valor.Size = new Size(101, 21);
            label_Valor.TabIndex = 6;
            label_Valor.Text = "Valor em R$";
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
            numericUpDown_Fornecedor.Size = new Size(178, 23);
            numericUpDown_Fornecedor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 330);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 9;
            label1.Text = "Fornecedor";
            // 
            // Form_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 450);
            Controls.Add(label1);
            Controls.Add(numericUpDown_Fornecedor);
            Controls.Add(textBox_Valor);
            Controls.Add(label_Valor);
            Controls.Add(textBox_Descricao);
            Controls.Add(textBox_Nome);
            Controls.Add(label_Descricao);
            Controls.Add(label_Nome);
            Controls.Add(button_Enviar);
            Controls.Add(label_Titulo);
            Name = "Form_Produto";
            Text = "Cadastro de produto";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private Button button_Enviar;
        private Label label_Nome;
        private Label label_Descricao;
        private TextBox textBox_Nome;
        private TextBox textBox_Descricao;
        private Label label_Valor;
        private TextBox textBox_Valor;
        private NumericUpDown numericUpDown_Fornecedor;
        private Label label1;
    }
}
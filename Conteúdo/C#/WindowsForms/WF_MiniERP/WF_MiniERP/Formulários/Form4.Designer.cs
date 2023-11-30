namespace WF_MiniERP
{
    partial class Form_Fornecedor
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
            label_Nome = new Label();
            textBox_Nome = new TextBox();
            button_Enviar = new Button();
            label_Cnpj = new Label();
            textBox_Cnpj = new TextBox();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(97, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(151, 30);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "FORNECEDOR";
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nome.Location = new Point(81, 87);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(57, 21);
            label_Nome.TabIndex = 1;
            label_Nome.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(81, 111);
            textBox_Nome.MaxLength = 100;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.PlaceholderText = "Digite o nome da empresa";
            textBox_Nome.Size = new Size(178, 23);
            textBox_Nome.TabIndex = 2;
            textBox_Nome.KeyPress += textBox_Nome_KeyPress;
            // 
            // button_Enviar
            // 
            button_Enviar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Enviar.Location = new Point(122, 296);
            button_Enviar.Name = "button_Enviar";
            button_Enviar.Size = new Size(95, 30);
            button_Enviar.TabIndex = 3;
            button_Enviar.Text = "ENVIAR";
            button_Enviar.UseVisualStyleBackColor = true;
            button_Enviar.Click += button_Enviar_Click;
            // 
            // label_Cnpj
            // 
            label_Cnpj.AutoSize = true;
            label_Cnpj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Cnpj.Location = new Point(81, 172);
            label_Cnpj.Name = "label_Cnpj";
            label_Cnpj.Size = new Size(49, 21);
            label_Cnpj.TabIndex = 4;
            label_Cnpj.Text = "CNPJ";
            // 
            // textBox_Cnpj
            // 
            textBox_Cnpj.Location = new Point(81, 196);
            textBox_Cnpj.MaxLength = 14;
            textBox_Cnpj.Name = "textBox_Cnpj";
            textBox_Cnpj.PlaceholderText = "Digite o cnpj de sua empresa";
            textBox_Cnpj.Size = new Size(178, 23);
            textBox_Cnpj.TabIndex = 5;
            textBox_Cnpj.KeyPress += textBox_Cnpj_KeyPress;
            // 
            // Form_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 338);
            Controls.Add(textBox_Cnpj);
            Controls.Add(label_Cnpj);
            Controls.Add(button_Enviar);
            Controls.Add(textBox_Nome);
            Controls.Add(label_Nome);
            Controls.Add(label_Titulo);
            Name = "Form_Fornecedor";
            Text = "Cadastro de fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private Label label_Nome;
        private TextBox textBox_Nome;
        private Button button_Enviar;
        private Label label_Cnpj;
        private TextBox textBox_Cnpj;
    }
}
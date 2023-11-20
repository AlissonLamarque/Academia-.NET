namespace _12_AmigoSecretoWinForms
{
    partial class Form_2
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
            label_Cadastro = new Label();
            label_Nome = new Label();
            label_Email = new Label();
            label_NomeInvalido = new Label();
            label_EmailInvalido = new Label();
            textBox_Nome = new TextBox();
            textBox_Email = new TextBox();
            button_EnviarCadastro = new Button();
            label_Amigos = new Label();
            listView_Amigos = new ListView();
            list_Nome = new ColumnHeader();
            list_Email = new ColumnHeader();
            button_SairCadastro = new Button();
            button_LimparLista = new Button();
            SuspendLayout();
            // 
            // label_Cadastro
            // 
            label_Cadastro.AutoSize = true;
            label_Cadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Cadastro.Location = new Point(98, 9);
            label_Cadastro.Name = "label_Cadastro";
            label_Cadastro.Size = new Size(125, 30);
            label_Cadastro.TabIndex = 0;
            label_Cadastro.Text = "CADASTRO";
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nome.Location = new Point(29, 85);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(59, 21);
            label_Nome.TabIndex = 1;
            label_Nome.Text = "NOME";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Email.Location = new Point(30, 208);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(58, 21);
            label_Email.TabIndex = 2;
            label_Email.Text = "EMAIL";
            // 
            // label_NomeInvalido
            // 
            label_NomeInvalido.AutoSize = true;
            label_NomeInvalido.ForeColor = Color.Red;
            label_NomeInvalido.Location = new Point(29, 135);
            label_NomeInvalido.Name = "label_NomeInvalido";
            label_NomeInvalido.Size = new Size(85, 15);
            label_NomeInvalido.TabIndex = 3;
            label_NomeInvalido.Text = "Nome inválido";
            label_NomeInvalido.Visible = false;
            // 
            // label_EmailInvalido
            // 
            label_EmailInvalido.AutoSize = true;
            label_EmailInvalido.ForeColor = Color.Red;
            label_EmailInvalido.Location = new Point(30, 258);
            label_EmailInvalido.Name = "label_EmailInvalido";
            label_EmailInvalido.Size = new Size(81, 15);
            label_EmailInvalido.TabIndex = 4;
            label_EmailInvalido.Text = "Email inválido";
            label_EmailInvalido.Visible = false;
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(29, 109);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.PlaceholderText = "Digite um nome";
            textBox_Nome.Size = new Size(259, 23);
            textBox_Nome.TabIndex = 5;
            textBox_Nome.KeyPress += textBox_Nome_KeyPress;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(30, 232);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.PlaceholderText = "Digite um email";
            textBox_Email.Size = new Size(259, 23);
            textBox_Email.TabIndex = 6;
            textBox_Email.KeyPress += textBox_Email_KeyPress;
            // 
            // button_EnviarCadastro
            // 
            button_EnviarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_EnviarCadastro.Location = new Point(112, 330);
            button_EnviarCadastro.Name = "button_EnviarCadastro";
            button_EnviarCadastro.Size = new Size(83, 33);
            button_EnviarCadastro.TabIndex = 7;
            button_EnviarCadastro.Text = "ENVIAR";
            button_EnviarCadastro.UseVisualStyleBackColor = true;
            button_EnviarCadastro.Click += button_EnviarCadastro_Click;
            // 
            // label_Amigos
            // 
            label_Amigos.AutoSize = true;
            label_Amigos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Amigos.Location = new Point(560, 9);
            label_Amigos.Name = "label_Amigos";
            label_Amigos.Size = new Size(98, 30);
            label_Amigos.TabIndex = 8;
            label_Amigos.Text = "AMIGOS";
            // 
            // listView_Amigos
            // 
            listView_Amigos.Columns.AddRange(new ColumnHeader[] { list_Nome, list_Email });
            listView_Amigos.Location = new Point(449, 85);
            listView_Amigos.Name = "listView_Amigos";
            listView_Amigos.Size = new Size(318, 209);
            listView_Amigos.TabIndex = 9;
            listView_Amigos.UseCompatibleStateImageBehavior = false;
            listView_Amigos.View = View.Details;
            // 
            // list_Nome
            // 
            list_Nome.Text = "Nome";
            list_Nome.Width = 160;
            // 
            // list_Email
            // 
            list_Email.Text = "Email";
            list_Email.Width = 153;
            // 
            // button_SairCadastro
            // 
            button_SairCadastro.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_SairCadastro.Location = new Point(349, 403);
            button_SairCadastro.Name = "button_SairCadastro";
            button_SairCadastro.Size = new Size(105, 35);
            button_SairCadastro.TabIndex = 10;
            button_SairCadastro.Text = "PRONTO";
            button_SairCadastro.UseVisualStyleBackColor = true;
            button_SairCadastro.Click += button_SairCadastro_Click;
            // 
            // button_LimparLista
            // 
            button_LimparLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_LimparLista.Location = new Point(575, 330);
            button_LimparLista.Name = "button_LimparLista";
            button_LimparLista.Size = new Size(83, 33);
            button_LimparLista.TabIndex = 11;
            button_LimparLista.Text = "LIMPAR";
            button_LimparLista.UseVisualStyleBackColor = true;
            button_LimparLista.Click += button_LimparLista_Click;
            // 
            // Form_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button_LimparLista);
            Controls.Add(button_SairCadastro);
            Controls.Add(listView_Amigos);
            Controls.Add(label_Amigos);
            Controls.Add(button_EnviarCadastro);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Nome);
            Controls.Add(label_EmailInvalido);
            Controls.Add(label_NomeInvalido);
            Controls.Add(label_Email);
            Controls.Add(label_Nome);
            Controls.Add(label_Cadastro);
            Name = "Form_2";
            Text = "Form_Cadastro";
            Load += Form_2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Cadastro;
        private Label label_Nome;
        private Label label_Email;
        private Label label_NomeInvalido;
        private Label label_EmailInvalido;
        private TextBox textBox_Nome;
        private TextBox textBox_Email;
        private Button button_EnviarCadastro;
        private Label label_Amigos;
        private ListView listView_Amigos;
        private ColumnHeader list_Nome;
        private ColumnHeader list_Email;
        private Button button_SairCadastro;
        private Button button_LimparLista;
    }
}
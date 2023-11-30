namespace WF_MiniERP
{
    partial class Form_Cliente
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
            label_Email = new Label();
            textBox_Nome = new TextBox();
            textBox_Email = new TextBox();
            button_Enviar = new Button();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(122, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(95, 30);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "CLIENTE";
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
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Email.Location = new Point(81, 172);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(53, 21);
            label_Email.TabIndex = 2;
            label_Email.Text = "Email";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(81, 111);
            textBox_Nome.MaxLength = 50;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.PlaceholderText = "Digite seu nome";
            textBox_Nome.Size = new Size(178, 23);
            textBox_Nome.TabIndex = 3;
            textBox_Nome.KeyPress += textBox_Nome_KeyPress;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(81, 196);
            textBox_Email.MaxLength = 50;
            textBox_Email.Name = "textBox_Email";
            textBox_Email.PlaceholderText = "Digite um email válido";
            textBox_Email.Size = new Size(178, 23);
            textBox_Email.TabIndex = 4;
            textBox_Email.KeyPress += textBox_Email_KeyPress;
            // 
            // button_Enviar
            // 
            button_Enviar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Enviar.Location = new Point(122, 296);
            button_Enviar.Name = "button_Enviar";
            button_Enviar.Size = new Size(95, 30);
            button_Enviar.TabIndex = 5;
            button_Enviar.Text = "ENVIAR";
            button_Enviar.UseVisualStyleBackColor = true;
            button_Enviar.Click += button_Enviar_Click;
            // 
            // Form_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 338);
            Controls.Add(button_Enviar);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Nome);
            Controls.Add(label_Email);
            Controls.Add(label_Nome);
            Controls.Add(label_Titulo);
            Name = "Form_Cliente";
            Text = "Cadastro de cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private Label label_Nome;
        private Label label_Email;
        private TextBox textBox_Nome;
        private TextBox textBox_Email;
        private Button button_Enviar;
    }
}
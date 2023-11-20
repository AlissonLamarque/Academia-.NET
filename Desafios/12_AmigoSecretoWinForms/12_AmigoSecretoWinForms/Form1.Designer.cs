namespace _12_AmigoSecretoWinForms
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
            label_Titulo1 = new Label();
            label_Titulo2 = new Label();
            button_Cadastrar = new Button();
            button_Gerar = new Button();
            button_Sair = new Button();
            SuspendLayout();
            // 
            // label_Titulo1
            // 
            label_Titulo1.AutoSize = true;
            label_Titulo1.BorderStyle = BorderStyle.FixedSingle;
            label_Titulo1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo1.Location = new Point(335, 9);
            label_Titulo1.Name = "label_Titulo1";
            label_Titulo1.Size = new Size(460, 49);
            label_Titulo1.TabIndex = 0;
            label_Titulo1.Text = "DESAFIO AMIGO SECRETO";
            // 
            // label_Titulo2
            // 
            label_Titulo2.AutoSize = true;
            label_Titulo2.BorderStyle = BorderStyle.FixedSingle;
            label_Titulo2.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo2.Location = new Point(470, 58);
            label_Titulo2.Name = "label_Titulo2";
            label_Titulo2.Size = new Size(204, 37);
            label_Titulo2.TabIndex = 1;
            label_Titulo2.Text = "Windows Forms";
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cadastrar.Location = new Point(505, 216);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(130, 41);
            button_Cadastrar.TabIndex = 2;
            button_Cadastrar.Text = "CADASTRO";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // button_Gerar
            // 
            button_Gerar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Gerar.Location = new Point(481, 293);
            button_Gerar.Name = "button_Gerar";
            button_Gerar.Size = new Size(182, 39);
            button_Gerar.TabIndex = 4;
            button_Gerar.Text = "AMIGO SECRETO";
            button_Gerar.UseVisualStyleBackColor = true;
            button_Gerar.Click += button_Gerar_Click;
            // 
            // button_Sair
            // 
            button_Sair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Sair.Location = new Point(505, 403);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(130, 37);
            button_Sair.TabIndex = 5;
            button_Sair.Text = "SAIR";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1136, 627);
            Controls.Add(button_Sair);
            Controls.Add(button_Gerar);
            Controls.Add(button_Cadastrar);
            Controls.Add(label_Titulo2);
            Controls.Add(label_Titulo1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo1;
        private Label label_Titulo2;
        private Button button_Cadastrar;
        private Button button_Gerar;
        private Button button_Sair;
    }
}
namespace _12_AmigoSecretoWinForms
{
    partial class Form_3
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
            label1 = new Label();
            listView_AmigoSecreto = new ListView();
            column_Nome1 = new ColumnHeader();
            column_Email1 = new ColumnHeader();
            column_Nome2 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button_GerarAmigoSecreto = new Button();
            button_ListarAmigoSecreto = new Button();
            button_SairAmigoSecreto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 0;
            label1.Text = "AMIGOS SECRETOS";
            // 
            // listView_AmigoSecreto
            // 
            listView_AmigoSecreto.Columns.AddRange(new ColumnHeader[] { column_Nome1, column_Email1, column_Nome2, columnHeader2 });
            listView_AmigoSecreto.Location = new Point(220, 62);
            listView_AmigoSecreto.Name = "listView_AmigoSecreto";
            listView_AmigoSecreto.Size = new Size(379, 282);
            listView_AmigoSecreto.TabIndex = 1;
            listView_AmigoSecreto.UseCompatibleStateImageBehavior = false;
            listView_AmigoSecreto.View = View.Details;
            // 
            // column_Nome1
            // 
            column_Nome1.Text = "Nome";
            column_Nome1.Width = 100;
            // 
            // column_Email1
            // 
            column_Email1.Text = "Email";
            column_Email1.Width = 90;
            // 
            // column_Nome2
            // 
            column_Nome2.Text = "Nome";
            column_Nome2.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Email";
            columnHeader2.Width = 85;
            // 
            // button_GerarAmigoSecreto
            // 
            button_GerarAmigoSecreto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_GerarAmigoSecreto.Location = new Point(220, 350);
            button_GerarAmigoSecreto.Name = "button_GerarAmigoSecreto";
            button_GerarAmigoSecreto.Size = new Size(108, 30);
            button_GerarAmigoSecreto.TabIndex = 2;
            button_GerarAmigoSecreto.Text = "GERAR";
            button_GerarAmigoSecreto.UseVisualStyleBackColor = true;
            button_GerarAmigoSecreto.Click += button_GerarAmigoSecreto_Click;
            // 
            // button_ListarAmigoSecreto
            // 
            button_ListarAmigoSecreto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_ListarAmigoSecreto.Location = new Point(356, 350);
            button_ListarAmigoSecreto.Name = "button_ListarAmigoSecreto";
            button_ListarAmigoSecreto.Size = new Size(108, 30);
            button_ListarAmigoSecreto.TabIndex = 3;
            button_ListarAmigoSecreto.Text = "LISTAR";
            button_ListarAmigoSecreto.UseVisualStyleBackColor = true;
            button_ListarAmigoSecreto.Click += button_ListarAmigoSecreto_Click;
            // 
            // button_SairAmigoSecreto
            // 
            button_SairAmigoSecreto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_SairAmigoSecreto.Location = new Point(491, 350);
            button_SairAmigoSecreto.Name = "button_SairAmigoSecreto";
            button_SairAmigoSecreto.Size = new Size(108, 30);
            button_SairAmigoSecreto.TabIndex = 4;
            button_SairAmigoSecreto.Text = "PRONTO";
            button_SairAmigoSecreto.UseVisualStyleBackColor = true;
            button_SairAmigoSecreto.Click += button_SairAmigoSecreto_Click;
            // 
            // Form_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button_SairAmigoSecreto);
            Controls.Add(button_ListarAmigoSecreto);
            Controls.Add(button_GerarAmigoSecreto);
            Controls.Add(listView_AmigoSecreto);
            Controls.Add(label1);
            Name = "Form_3";
            Text = "Form_AmigoSecreto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView_AmigoSecreto;
        private ColumnHeader column_Nome1;
        private ColumnHeader column_Email1;
        private ColumnHeader column_Nome2;
        private ColumnHeader columnHeader2;
        private Button button_GerarAmigoSecreto;
        private Button button_ListarAmigoSecreto;
        private Button button_SairAmigoSecreto;
    }
}
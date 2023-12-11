namespace _13_MiniERPcomEntity.Forms
{
    partial class FormListaNotas
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
            listView_Notas = new ListView();
            columnHeader_Id = new ColumnHeader();
            columnHeader_P = new ColumnHeader();
            columnHeader_C = new ColumnHeader();
            label_Titulo = new Label();
            button_Pronto = new Button();
            SuspendLayout();
            // 
            // listView_Notas
            // 
            listView_Notas.BackColor = SystemColors.Control;
            listView_Notas.BorderStyle = BorderStyle.FixedSingle;
            listView_Notas.Columns.AddRange(new ColumnHeader[] { columnHeader_Id, columnHeader_P, columnHeader_C });
            listView_Notas.Location = new Point(12, 37);
            listView_Notas.Name = "listView_Notas";
            listView_Notas.Size = new Size(341, 261);
            listView_Notas.TabIndex = 0;
            listView_Notas.UseCompatibleStateImageBehavior = false;
            listView_Notas.View = View.Details;
            // 
            // columnHeader_Id
            // 
            columnHeader_Id.Text = "Id";
            columnHeader_Id.Width = 35;
            // 
            // columnHeader_P
            // 
            columnHeader_P.Text = "Produto";
            columnHeader_P.Width = 150;
            // 
            // columnHeader_C
            // 
            columnHeader_C.Text = "Cliente";
            columnHeader_C.Width = 150;
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(104, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(158, 25);
            label_Titulo.TabIndex = 1;
            label_Titulo.Text = "LISTA DE NOTAS";
            // 
            // button_Pronto
            // 
            button_Pronto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Pronto.Location = new Point(133, 304);
            button_Pronto.Name = "button_Pronto";
            button_Pronto.Size = new Size(101, 31);
            button_Pronto.TabIndex = 2;
            button_Pronto.Text = "PRONTO";
            button_Pronto.UseVisualStyleBackColor = true;
            button_Pronto.Click += button_Pronto_Click;
            // 
            // FormListaNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 347);
            Controls.Add(button_Pronto);
            Controls.Add(label_Titulo);
            Controls.Add(listView_Notas);
            Name = "FormListaNotas";
            Text = "FormListaNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView_Notas;
        private ColumnHeader columnHeader_Id;
        private ColumnHeader columnHeader_P;
        private ColumnHeader columnHeader_C;
        private Label label_Titulo;
        private Button button_Pronto;
    }
}
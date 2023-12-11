namespace _13_MiniERPcomEntity.Forms
{
    partial class FormListaFornecedor
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
            listView_Fornecedores = new ListView();
            columnHeader_Id = new ColumnHeader();
            columnHeader_Fornecedor = new ColumnHeader();
            button_Pronto = new Button();
            SuspendLayout();
            // 
            // listView_Fornecedores
            // 
            listView_Fornecedores.BackColor = SystemColors.Control;
            listView_Fornecedores.BorderStyle = BorderStyle.None;
            listView_Fornecedores.Columns.AddRange(new ColumnHeader[] { columnHeader_Id, columnHeader_Fornecedor });
            listView_Fornecedores.Location = new Point(2, 1);
            listView_Fornecedores.Name = "listView_Fornecedores";
            listView_Fornecedores.Size = new Size(238, 290);
            listView_Fornecedores.TabIndex = 0;
            listView_Fornecedores.UseCompatibleStateImageBehavior = false;
            listView_Fornecedores.View = View.Details;
            // 
            // columnHeader_Id
            // 
            columnHeader_Id.Text = "Id";
            columnHeader_Id.Width = 35;
            // 
            // columnHeader_Fornecedor
            // 
            columnHeader_Fornecedor.Text = "Fornecedor";
            columnHeader_Fornecedor.Width = 200;
            // 
            // button_Pronto
            // 
            button_Pronto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Pronto.Location = new Point(77, 297);
            button_Pronto.Name = "button_Pronto";
            button_Pronto.Size = new Size(88, 31);
            button_Pronto.TabIndex = 1;
            button_Pronto.Text = "PRONTO";
            button_Pronto.UseVisualStyleBackColor = true;
            button_Pronto.Click += button_Pronto_Click;
            // 
            // FormListaFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 333);
            Controls.Add(button_Pronto);
            Controls.Add(listView_Fornecedores);
            Name = "FormListaFornecedor";
            Text = "Lista de Fornecedores";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_Fornecedores;
        private Button button_Pronto;
        private ColumnHeader columnHeader_Id;
        private ColumnHeader columnHeader_Fornecedor;
    }
}
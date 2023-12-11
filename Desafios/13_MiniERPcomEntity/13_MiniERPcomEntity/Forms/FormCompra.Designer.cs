namespace _13_MiniERPcomEntity.Forms
{
    partial class FormCompra
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
            label_Produto = new Label();
            label_Cliente = new Label();
            listView_Compra = new ListView();
            columnHeader_PId = new ColumnHeader();
            columnHeader_P = new ColumnHeader();
            columnHeader_CId = new ColumnHeader();
            columnHeader_C = new ColumnHeader();
            numericUpDown_Produto = new NumericUpDown();
            numericUpDown_Cliente = new NumericUpDown();
            button_Pronto = new Button();
            button_Realizar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cliente).BeginInit();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(183, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(210, 30);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "REALIZAR COMPRA";
            // 
            // label_Produto
            // 
            label_Produto.AutoSize = true;
            label_Produto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Produto.Location = new Point(30, 65);
            label_Produto.Name = "label_Produto";
            label_Produto.Size = new Size(72, 21);
            label_Produto.TabIndex = 1;
            label_Produto.Text = "Produto";
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Cliente.Location = new Point(30, 142);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(64, 21);
            label_Cliente.TabIndex = 2;
            label_Cliente.Text = "Cliente";
            // 
            // listView_Compra
            // 
            listView_Compra.Columns.AddRange(new ColumnHeader[] { columnHeader_PId, columnHeader_P, columnHeader_CId, columnHeader_C });
            listView_Compra.Location = new Point(210, 65);
            listView_Compra.Name = "listView_Compra";
            listView_Compra.Size = new Size(351, 199);
            listView_Compra.TabIndex = 3;
            listView_Compra.UseCompatibleStateImageBehavior = false;
            listView_Compra.View = View.Details;
            // 
            // columnHeader_PId
            // 
            columnHeader_PId.Text = "id";
            columnHeader_PId.Width = 22;
            // 
            // columnHeader_P
            // 
            columnHeader_P.Text = "Produtos";
            columnHeader_P.Width = 150;
            // 
            // columnHeader_CId
            // 
            columnHeader_CId.Text = "id";
            columnHeader_CId.Width = 22;
            // 
            // columnHeader_C
            // 
            columnHeader_C.Text = "Clientes";
            columnHeader_C.Width = 150;
            // 
            // numericUpDown_Produto
            // 
            numericUpDown_Produto.Location = new Point(30, 89);
            numericUpDown_Produto.Name = "numericUpDown_Produto";
            numericUpDown_Produto.Size = new Size(120, 23);
            numericUpDown_Produto.TabIndex = 4;
            // 
            // numericUpDown_Cliente
            // 
            numericUpDown_Cliente.Location = new Point(30, 166);
            numericUpDown_Cliente.Name = "numericUpDown_Cliente";
            numericUpDown_Cliente.Size = new Size(120, 23);
            numericUpDown_Cliente.TabIndex = 5;
            // 
            // button_Pronto
            // 
            button_Pronto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Pronto.Location = new Point(231, 313);
            button_Pronto.Name = "button_Pronto";
            button_Pronto.Size = new Size(95, 30);
            button_Pronto.TabIndex = 6;
            button_Pronto.Text = "PRONTO";
            button_Pronto.UseVisualStyleBackColor = true;
            button_Pronto.Click += button_Pronto_Click;
            // 
            // button_Realizar
            // 
            button_Realizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Realizar.Location = new Point(42, 234);
            button_Realizar.Name = "button_Realizar";
            button_Realizar.Size = new Size(95, 30);
            button_Realizar.TabIndex = 7;
            button_Realizar.Text = "REALIZAR";
            button_Realizar.UseVisualStyleBackColor = true;
            button_Realizar.Click += button_Realizar_Click;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 355);
            Controls.Add(button_Realizar);
            Controls.Add(button_Pronto);
            Controls.Add(numericUpDown_Cliente);
            Controls.Add(numericUpDown_Produto);
            Controls.Add(listView_Compra);
            Controls.Add(label_Cliente);
            Controls.Add(label_Produto);
            Controls.Add(label_Titulo);
            Name = "FormCompra";
            Text = "FormCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private Label label_Produto;
        private Label label_Cliente;
        private ListView listView_Compra;
        private NumericUpDown numericUpDown_Produto;
        private NumericUpDown numericUpDown_Cliente;
        private Button button_Pronto;
        private Button button_Realizar;
        private ColumnHeader columnHeader_PId;
        private ColumnHeader columnHeader_P;
        private ColumnHeader columnHeader_CId;
        private ColumnHeader columnHeader_C;
    }
}
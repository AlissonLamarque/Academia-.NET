namespace WF_MiniERP.Formulários
{
    partial class Form_Compra
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
            listView_Compra = new ListView();
            numericUpDown_Produto = new NumericUpDown();
            numericUpDown_Cliente = new NumericUpDown();
            label_Produto = new Label();
            label_Cliente = new Label();
            button_RealizarCompra = new Button();
            button_Pronto = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cliente).BeginInit();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(83, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(210, 30);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "REALIZAR COMPRA";
            // 
            // listView_Compra
            // 
            listView_Compra.Location = new Point(12, 75);
            listView_Compra.Name = "listView_Compra";
            listView_Compra.Size = new Size(181, 199);
            listView_Compra.TabIndex = 1;
            listView_Compra.UseCompatibleStateImageBehavior = false;
            // 
            // numericUpDown_Produto
            // 
            numericUpDown_Produto.Location = new Point(221, 99);
            numericUpDown_Produto.Name = "numericUpDown_Produto";
            numericUpDown_Produto.Size = new Size(120, 23);
            numericUpDown_Produto.TabIndex = 2;
            // 
            // numericUpDown_Cliente
            // 
            numericUpDown_Cliente.Location = new Point(221, 176);
            numericUpDown_Cliente.Name = "numericUpDown_Cliente";
            numericUpDown_Cliente.Size = new Size(120, 23);
            numericUpDown_Cliente.TabIndex = 3;
            // 
            // label_Produto
            // 
            label_Produto.AutoSize = true;
            label_Produto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Produto.Location = new Point(221, 75);
            label_Produto.Name = "label_Produto";
            label_Produto.Size = new Size(72, 21);
            label_Produto.TabIndex = 5;
            label_Produto.Text = "Produto";
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Cliente.Location = new Point(221, 152);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(64, 21);
            label_Cliente.TabIndex = 6;
            label_Cliente.Text = "Cliente";
            // 
            // button_RealizarCompra
            // 
            button_RealizarCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_RealizarCompra.Location = new Point(233, 244);
            button_RealizarCompra.Name = "button_RealizarCompra";
            button_RealizarCompra.Size = new Size(95, 30);
            button_RealizarCompra.TabIndex = 8;
            button_RealizarCompra.Text = "REALIZAR";
            button_RealizarCompra.UseVisualStyleBackColor = true;
            // 
            // button_Pronto
            // 
            button_Pronto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Pronto.Location = new Point(134, 300);
            button_Pronto.Name = "button_Pronto";
            button_Pronto.Size = new Size(95, 30);
            button_Pronto.TabIndex = 9;
            button_Pronto.Text = "PRONTO";
            button_Pronto.UseVisualStyleBackColor = true;
            button_Pronto.Click += button_Pronto_Click;
            // 
            // Form_Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 342);
            Controls.Add(button_Pronto);
            Controls.Add(button_RealizarCompra);
            Controls.Add(label_Cliente);
            Controls.Add(label_Produto);
            Controls.Add(numericUpDown_Cliente);
            Controls.Add(numericUpDown_Produto);
            Controls.Add(listView_Compra);
            Controls.Add(label_Titulo);
            Name = "Form_Compra";
            Text = "Processo de compra";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private ListView listView_Compra;
        private NumericUpDown numericUpDown_Produto;
        private NumericUpDown numericUpDown_Cliente;
        private Label label_Produto;
        private Label label_Cliente;
        private Button button_RealizarCompra;
        private Button button_Pronto;
    }
}
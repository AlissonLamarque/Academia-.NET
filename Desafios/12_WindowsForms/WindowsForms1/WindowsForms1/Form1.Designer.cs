namespace WindowsForms1
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
            components = new System.ComponentModel.Container();
            Label_Frase = new Label();
            textBox_frase = new TextBox();
            textBox_relacaoNomes = new TextBox();
            button_limpar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            inicioToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            contextMenuStrip4 = new ContextMenuStrip(components);
            menuToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip5 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            textBox_relacaoNomes2 = new TextBox();
            listView_pessoas = new ListView();
            listview_Nome = new ColumnHeader();
            listview_Email = new ColumnHeader();
            contextMenuStrip6 = new ContextMenuStrip(components);
            contextMenuStrip7 = new ContextMenuStrip(components);
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip4.SuspendLayout();
            contextMenuStrip7.SuspendLayout();
            SuspendLayout();
            // 
            // Label_Frase
            // 
            Label_Frase.AutoSize = true;
            Label_Frase.Location = new Point(15, 116);
            Label_Frase.Name = "Label_Frase";
            Label_Frase.Size = new Size(93, 15);
            Label_Frase.TabIndex = 0;
            Label_Frase.Text = "Digite uma frase";
            // 
            // textBox_frase
            // 
            textBox_frase.BorderStyle = BorderStyle.FixedSingle;
            textBox_frase.Location = new Point(114, 112);
            textBox_frase.Name = "textBox_frase";
            textBox_frase.Size = new Size(405, 23);
            textBox_frase.TabIndex = 1;
            textBox_frase.KeyPress += textBox_frase_KeyPress;
            // 
            // textBox_relacaoNomes
            // 
            textBox_relacaoNomes.BorderStyle = BorderStyle.FixedSingle;
            textBox_relacaoNomes.Enabled = false;
            textBox_relacaoNomes.Location = new Point(15, 152);
            textBox_relacaoNomes.Multiline = true;
            textBox_relacaoNomes.Name = "textBox_relacaoNomes";
            textBox_relacaoNomes.Size = new Size(464, 372);
            textBox_relacaoNomes.TabIndex = 2;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(570, 112);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(75, 23);
            button_limpar.TabIndex = 3;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += button_limpar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(104, 26);
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(103, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(106, 26);
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(105, 22);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // contextMenuStrip5
            // 
            contextMenuStrip5.Name = "contextMenuStrip5";
            contextMenuStrip5.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1036, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // textBox_relacaoNomes2
            // 
            textBox_relacaoNomes2.BorderStyle = BorderStyle.None;
            textBox_relacaoNomes2.Location = new Point(570, 152);
            textBox_relacaoNomes2.Multiline = true;
            textBox_relacaoNomes2.Name = "textBox_relacaoNomes2";
            textBox_relacaoNomes2.Size = new Size(444, 372);
            textBox_relacaoNomes2.TabIndex = 10;
            // 
            // listView_pessoas
            // 
            listView_pessoas.Columns.AddRange(new ColumnHeader[] { listview_Nome, listview_Email });
            listView_pessoas.Location = new Point(15, 152);
            listView_pessoas.Name = "listView_pessoas";
            listView_pessoas.Size = new Size(504, 372);
            listView_pessoas.TabIndex = 11;
            listView_pessoas.UseCompatibleStateImageBehavior = false;
            listView_pessoas.View = View.Details;
            // 
            // listview_Nome
            // 
            listview_Nome.Text = "Nome";
            listview_Nome.Width = 250;
            // 
            // listview_Email
            // 
            listview_Email.Text = "Email";
            listview_Email.Width = 250;
            // 
            // contextMenuStrip6
            // 
            contextMenuStrip6.Name = "contextMenuStrip6";
            contextMenuStrip6.Size = new Size(61, 4);
            // 
            // contextMenuStrip7
            // 
            contextMenuStrip7.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem1, ajudaToolStripMenuItem });
            contextMenuStrip7.Name = "contextMenuStrip7";
            contextMenuStrip7.Size = new Size(106, 48);
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(105, 22);
            menuToolStripMenuItem1.Text = "Menu";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(105, 22);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 657);
            Controls.Add(listView_pessoas);
            Controls.Add(textBox_relacaoNomes2);
            Controls.Add(menuStrip1);
            Controls.Add(button_limpar);
            Controls.Add(textBox_relacaoNomes);
            Controls.Add(textBox_frase);
            Controls.Add(Label_Frase);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip4.ResumeLayout(false);
            contextMenuStrip7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Frase;
        private TextBox textBox_frase;
        private TextBox textBox_relacaoNomes;
        private Button button_limpar;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip5;
        private MenuStrip menuStrip1;
        private TextBox textBox_relacaoNomes2;
        private ListView listView_pessoas;
        private ColumnHeader listview_Nome;
        private ColumnHeader listview_Email;
        private ContextMenuStrip contextMenuStrip6;
        private ContextMenuStrip contextMenuStrip7;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem ajudaToolStripMenuItem;
    }
}
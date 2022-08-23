namespace Projeto_EasyMoney
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textDescrição = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNovo = new System.Windows.Forms.ToolStripButton();
            this.toolSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBuscarPorID = new System.Windows.Forms.ToolStripLabel();
            this.toolBuscaID = new System.Windows.Forms.ToolStripTextBox();
            this.toolLupa = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(14, 58);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(43, 20);
            this.textID.TabIndex = 8;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Receita",
            "Despesa"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(88, 57);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(206, 21);
            this.comboBoxCategoria.TabIndex = 9;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // boxData
            // 
            this.boxData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.boxData.Location = new System.Drawing.Point(195, 108);
            this.boxData.Name = "boxData";
            this.boxData.Size = new System.Drawing.Size(99, 20);
            this.boxData.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descrição";
            // 
            // textDescrição
            // 
            this.textDescrição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDescrição.Location = new System.Drawing.Point(14, 162);
            this.textDescrição.MaxLength = 100;
            this.textDescrição.Name = "textDescrição";
            this.textDescrição.Size = new System.Drawing.Size(333, 20);
            this.textDescrição.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(14, 108);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(139, 20);
            this.textValor.TabIndex = 15;
            this.textValor.TextChanged += new System.EventHandler(this.textValor_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNovo,
            this.toolSalvar,
            this.toolCancelar,
            this.toolExcluir,
            this.toolStripSeparator1,
            this.toolBuscarPorID,
            this.toolBuscaID,
            this.toolLupa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNovo
            // 
            this.toolNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNovo.Image = ((System.Drawing.Image)(resources.GetObject("toolNovo.Image")));
            this.toolNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNovo.Name = "toolNovo";
            this.toolNovo.Size = new System.Drawing.Size(23, 22);
            this.toolNovo.Text = "Novo";
            this.toolNovo.Click += new System.EventHandler(this.toolNovo_Click);
            // 
            // toolSalvar
            // 
            this.toolSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolSalvar.Image")));
            this.toolSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSalvar.Name = "toolSalvar";
            this.toolSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolSalvar.Text = "Salvar";
            // 
            // toolCancelar
            // 
            this.toolCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolCancelar.Image")));
            this.toolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancelar.Name = "toolCancelar";
            this.toolCancelar.Size = new System.Drawing.Size(23, 22);
            this.toolCancelar.Text = "Cancelar";
            // 
            // toolExcluir
            // 
            this.toolExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolExcluir.Image = ((System.Drawing.Image)(resources.GetObject("toolExcluir.Image")));
            this.toolExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExcluir.Name = "toolExcluir";
            this.toolExcluir.Size = new System.Drawing.Size(23, 22);
            this.toolExcluir.Text = "Excluir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBuscarPorID
            // 
            this.toolBuscarPorID.Name = "toolBuscarPorID";
            this.toolBuscarPorID.Size = new System.Drawing.Size(80, 22);
            this.toolBuscarPorID.Text = "Buscar por ID:";
            // 
            // toolBuscaID
            // 
            this.toolBuscaID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolBuscaID.Name = "toolBuscaID";
            this.toolBuscaID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolLupa
            // 
            this.toolLupa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLupa.Image = ((System.Drawing.Image)(resources.GetObject("toolLupa.Image")));
            this.toolLupa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLupa.Name = "toolLupa";
            this.toolLupa.Size = new System.Drawing.Size(32, 22);
            this.toolLupa.Text = "Buscar";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 203);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDescrição);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker boxData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDescrição;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNovo;
        private System.Windows.Forms.ToolStripButton toolSalvar;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolBuscarPorID;
        private System.Windows.Forms.ToolStripTextBox toolBuscaID;
        private System.Windows.Forms.ToolStripSplitButton toolLupa;
    }
}
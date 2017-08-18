namespace ProjetoOrientacao.WinForms
{
    partial class FormTipoEntrega
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
            this.groupBoxTipoEntregaFormulario = new System.Windows.Forms.GroupBox();
            this.buttonSalvarTipoEntrega = new System.Windows.Forms.Button();
            this.textBoxDescricaoTipoEntrega = new System.Windows.Forms.TextBox();
            this.textBoxCodigoTipoEntrega = new System.Windows.Forms.TextBox();
            this.labelDescricaoTipoEntrega = new System.Windows.Forms.Label();
            this.labelCodigoTipoEntrega = new System.Windows.Forms.Label();
            this.groupBoxTipoEntregaTabela = new System.Windows.Forms.GroupBox();
            this.buttonExcluirTipoEntrega = new System.Windows.Forms.Button();
            this.buttonEditarTipoEntrega = new System.Windows.Forms.Button();
            this.dataGridViewTipoEntrega = new System.Windows.Forms.DataGridView();
            this.groupBoxTipoEntregaFormulario.SuspendLayout();
            this.groupBoxTipoEntregaTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTipoEntregaFormulario
            // 
            this.groupBoxTipoEntregaFormulario.Controls.Add(this.buttonSalvarTipoEntrega);
            this.groupBoxTipoEntregaFormulario.Controls.Add(this.textBoxDescricaoTipoEntrega);
            this.groupBoxTipoEntregaFormulario.Controls.Add(this.textBoxCodigoTipoEntrega);
            this.groupBoxTipoEntregaFormulario.Controls.Add(this.labelDescricaoTipoEntrega);
            this.groupBoxTipoEntregaFormulario.Controls.Add(this.labelCodigoTipoEntrega);
            this.groupBoxTipoEntregaFormulario.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTipoEntregaFormulario.Name = "groupBoxTipoEntregaFormulario";
            this.groupBoxTipoEntregaFormulario.Size = new System.Drawing.Size(601, 160);
            this.groupBoxTipoEntregaFormulario.TabIndex = 0;
            this.groupBoxTipoEntregaFormulario.TabStop = false;
            this.groupBoxTipoEntregaFormulario.Text = "Cadastrar/Alterar Tipo Entrega";
            // 
            // buttonSalvarTipoEntrega
            // 
            this.buttonSalvarTipoEntrega.Location = new System.Drawing.Point(28, 115);
            this.buttonSalvarTipoEntrega.Name = "buttonSalvarTipoEntrega";
            this.buttonSalvarTipoEntrega.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarTipoEntrega.TabIndex = 4;
            this.buttonSalvarTipoEntrega.Text = "Salvar";
            this.buttonSalvarTipoEntrega.UseVisualStyleBackColor = true;
            this.buttonSalvarTipoEntrega.Click += new System.EventHandler(this.buttonSalvarTipoEntrega_Click);
            // 
            // textBoxDescricaoTipoEntrega
            // 
            this.textBoxDescricaoTipoEntrega.Location = new System.Drawing.Point(99, 65);
            this.textBoxDescricaoTipoEntrega.Name = "textBoxDescricaoTipoEntrega";
            this.textBoxDescricaoTipoEntrega.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricaoTipoEntrega.TabIndex = 3;
            // 
            // textBoxCodigoTipoEntrega
            // 
            this.textBoxCodigoTipoEntrega.Enabled = false;
            this.textBoxCodigoTipoEntrega.Location = new System.Drawing.Point(99, 33);
            this.textBoxCodigoTipoEntrega.Name = "textBoxCodigoTipoEntrega";
            this.textBoxCodigoTipoEntrega.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoTipoEntrega.TabIndex = 2;
            // 
            // labelDescricaoTipoEntrega
            // 
            this.labelDescricaoTipoEntrega.AutoSize = true;
            this.labelDescricaoTipoEntrega.Location = new System.Drawing.Point(25, 72);
            this.labelDescricaoTipoEntrega.Name = "labelDescricaoTipoEntrega";
            this.labelDescricaoTipoEntrega.Size = new System.Drawing.Size(58, 13);
            this.labelDescricaoTipoEntrega.TabIndex = 1;
            this.labelDescricaoTipoEntrega.Text = "Descrição:";
            // 
            // labelCodigoTipoEntrega
            // 
            this.labelCodigoTipoEntrega.AutoSize = true;
            this.labelCodigoTipoEntrega.Location = new System.Drawing.Point(25, 33);
            this.labelCodigoTipoEntrega.Name = "labelCodigoTipoEntrega";
            this.labelCodigoTipoEntrega.Size = new System.Drawing.Size(43, 13);
            this.labelCodigoTipoEntrega.TabIndex = 0;
            this.labelCodigoTipoEntrega.Text = "Código:";
            // 
            // groupBoxTipoEntregaTabela
            // 
            this.groupBoxTipoEntregaTabela.Controls.Add(this.buttonExcluirTipoEntrega);
            this.groupBoxTipoEntregaTabela.Controls.Add(this.buttonEditarTipoEntrega);
            this.groupBoxTipoEntregaTabela.Controls.Add(this.dataGridViewTipoEntrega);
            this.groupBoxTipoEntregaTabela.Location = new System.Drawing.Point(13, 207);
            this.groupBoxTipoEntregaTabela.Name = "groupBoxTipoEntregaTabela";
            this.groupBoxTipoEntregaTabela.Size = new System.Drawing.Size(600, 231);
            this.groupBoxTipoEntregaTabela.TabIndex = 1;
            this.groupBoxTipoEntregaTabela.TabStop = false;
            this.groupBoxTipoEntregaTabela.Text = "Tipos de Entrega Cadastrados";
            // 
            // buttonExcluirTipoEntrega
            // 
            this.buttonExcluirTipoEntrega.Location = new System.Drawing.Point(504, 202);
            this.buttonExcluirTipoEntrega.Name = "buttonExcluirTipoEntrega";
            this.buttonExcluirTipoEntrega.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirTipoEntrega.TabIndex = 2;
            this.buttonExcluirTipoEntrega.Text = "Excluir";
            this.buttonExcluirTipoEntrega.UseVisualStyleBackColor = true;
            this.buttonExcluirTipoEntrega.Click += new System.EventHandler(this.buttonExcluirTipoEntrega_Click);
            // 
            // buttonEditarTipoEntrega
            // 
            this.buttonEditarTipoEntrega.Location = new System.Drawing.Point(6, 202);
            this.buttonEditarTipoEntrega.Name = "buttonEditarTipoEntrega";
            this.buttonEditarTipoEntrega.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarTipoEntrega.TabIndex = 1;
            this.buttonEditarTipoEntrega.Text = "Editar";
            this.buttonEditarTipoEntrega.UseVisualStyleBackColor = true;
            this.buttonEditarTipoEntrega.Click += new System.EventHandler(this.buttonEditarTipoEntrega_Click);
            // 
            // dataGridViewTipoEntrega
            // 
            this.dataGridViewTipoEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipoEntrega.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTipoEntrega.Name = "dataGridViewTipoEntrega";
            this.dataGridViewTipoEntrega.Size = new System.Drawing.Size(573, 150);
            this.dataGridViewTipoEntrega.TabIndex = 0;
            // 
            // FormTipoEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 465);
            this.Controls.Add(this.groupBoxTipoEntregaTabela);
            this.Controls.Add(this.groupBoxTipoEntregaFormulario);
            this.Name = "FormTipoEntrega";
            this.Tag = "";
            this.Text = "Formulário Tipo Entrega";
            this.Load += new System.EventHandler(this.FormTipoEntrega_Load);
            this.groupBoxTipoEntregaFormulario.ResumeLayout(false);
            this.groupBoxTipoEntregaFormulario.PerformLayout();
            this.groupBoxTipoEntregaTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoEntregaFormulario;
        private System.Windows.Forms.GroupBox groupBoxTipoEntregaTabela;
        private System.Windows.Forms.Button buttonSalvarTipoEntrega;
        private System.Windows.Forms.TextBox textBoxDescricaoTipoEntrega;
        private System.Windows.Forms.TextBox textBoxCodigoTipoEntrega;
        private System.Windows.Forms.Label labelDescricaoTipoEntrega;
        private System.Windows.Forms.Label labelCodigoTipoEntrega;
        private System.Windows.Forms.Button buttonExcluirTipoEntrega;
        private System.Windows.Forms.Button buttonEditarTipoEntrega;
        private System.Windows.Forms.DataGridView dataGridViewTipoEntrega;
    }
}


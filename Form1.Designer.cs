
namespace Loja_de_tênis_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgTenis = new System.Windows.Forms.DataGridView();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTenis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(693, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano:";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(100, 47);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(118, 26);
            this.tbMarca.TabIndex = 4;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(323, 48);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(116, 26);
            this.tbModelo.TabIndex = 5;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(758, 48);
            this.tbAno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(106, 26);
            this.tbAno.TabIndex = 6;
            // 
            // tbCor
            // 
            this.tbCor.Location = new System.Drawing.Point(534, 46);
            this.tbCor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(123, 26);
            this.tbCor.TabIndex = 7;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(333, 109);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 29);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(445, 109);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(99, 29);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgTenis
            // 
            this.dgTenis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTenis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTenis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgTenis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTenis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTenis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaID,
            this.colunaMarca,
            this.colunaModelo,
            this.colunaCor,
            this.colunaAno});
            this.dgTenis.Location = new System.Drawing.Point(12, 160);
            this.dgTenis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgTenis.Name = "dgTenis";
            this.dgTenis.Size = new System.Drawing.Size(867, 270);
            this.dgTenis.TabIndex = 10;
            // 
            // colunaID
            // 
            this.colunaID.HeaderText = "ID";
            this.colunaID.Name = "colunaID";
            this.colunaID.Width = 70;
            // 
            // colunaMarca
            // 
            this.colunaMarca.HeaderText = "Marca";
            this.colunaMarca.Name = "colunaMarca";
            this.colunaMarca.Width = 160;
            // 
            // colunaModelo
            // 
            this.colunaModelo.HeaderText = "Modelo";
            this.colunaModelo.Name = "colunaModelo";
            this.colunaModelo.Width = 300;
            // 
            // colunaCor
            // 
            this.colunaCor.HeaderText = "Cor";
            this.colunaCor.Name = "colunaCor";
            this.colunaCor.Width = 194;
            // 
            // colunaAno
            // 
            this.colunaAno.HeaderText = "Ano";
            this.colunaAno.Name = "colunaAno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 444);
            this.Controls.Add(this.dgTenis);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbCor);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTenis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbCor;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dgTenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaAno;
    }
}


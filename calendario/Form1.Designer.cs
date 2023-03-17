namespace calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDataInicial = new System.Windows.Forms.TextBox();
            this.txtBoxDataFinal = new System.Windows.Forms.TextBox();
            this.txtBoxDataAtual = new System.Windows.Forms.TextBox();
            this.btnSelecionarData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 49);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Atual";
            // 
            // txtBoxDataInicial
            // 
            this.txtBoxDataInicial.BackColor = System.Drawing.Color.White;
            this.txtBoxDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDataInicial.Location = new System.Drawing.Point(342, 100);
            this.txtBoxDataInicial.Name = "txtBoxDataInicial";
            this.txtBoxDataInicial.Size = new System.Drawing.Size(100, 21);
            this.txtBoxDataInicial.TabIndex = 4;
            // 
            // txtBoxDataFinal
            // 
            this.txtBoxDataFinal.BackColor = System.Drawing.Color.White;
            this.txtBoxDataFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDataFinal.Location = new System.Drawing.Point(342, 129);
            this.txtBoxDataFinal.Name = "txtBoxDataFinal";
            this.txtBoxDataFinal.Size = new System.Drawing.Size(100, 21);
            this.txtBoxDataFinal.TabIndex = 5;
            // 
            // txtBoxDataAtual
            // 
            this.txtBoxDataAtual.BackColor = System.Drawing.Color.White;
            this.txtBoxDataAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDataAtual.Location = new System.Drawing.Point(342, 161);
            this.txtBoxDataAtual.Name = "txtBoxDataAtual";
            this.txtBoxDataAtual.Size = new System.Drawing.Size(100, 21);
            this.txtBoxDataAtual.TabIndex = 6;
            // 
            // btnSelecionarData
            // 
            this.btnSelecionarData.BackColor = System.Drawing.Color.OldLace;
            this.btnSelecionarData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionarData.Location = new System.Drawing.Point(290, 209);
            this.btnSelecionarData.Name = "btnSelecionarData";
            this.btnSelecionarData.Size = new System.Drawing.Size(130, 24);
            this.btnSelecionarData.TabIndex = 7;
            this.btnSelecionarData.Text = "Selecionar Data";
            this.btnSelecionarData.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(496, 276);
            this.Controls.Add(this.btnSelecionarData);
            this.Controls.Add(this.txtBoxDataAtual);
            this.Controls.Add(this.txtBoxDataFinal);
            this.Controls.Add(this.txtBoxDataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Exemplo de calendário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDataInicial;
        private System.Windows.Forms.TextBox txtBoxDataFinal;
        private System.Windows.Forms.TextBox txtBoxDataAtual;
        private System.Windows.Forms.Button btnSelecionarData;
    }
}


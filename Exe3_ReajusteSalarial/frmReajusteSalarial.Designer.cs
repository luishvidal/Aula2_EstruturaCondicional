namespace Exe3_ReajusteSalarial
{
    partial class frmReajusteSalarial
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
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rdbVeterano = new System.Windows.Forms.RadioButton();
            this.rdbCalouro = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rdbNoturno = new System.Windows.Forms.RadioButton();
            this.rdbVespertino = new System.Windows.Forms.RadioButton();
            this.rdbMatutino = new System.Windows.Forms.RadioButton();
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lbxResume = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSituacaoSalarial = new System.Windows.Forms.Label();
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rdbVeterano);
            this.gbxCategoria.Controls.Add(this.rdbCalouro);
            this.gbxCategoria.Location = new System.Drawing.Point(70, 113);
            this.gbxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCategoria.Size = new System.Drawing.Size(225, 78);
            this.gbxCategoria.TabIndex = 0;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rdbVeterano
            // 
            this.rdbVeterano.AutoSize = true;
            this.rdbVeterano.Location = new System.Drawing.Point(110, 29);
            this.rdbVeterano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbVeterano.Name = "rdbVeterano";
            this.rdbVeterano.Size = new System.Drawing.Size(93, 24);
            this.rdbVeterano.TabIndex = 1;
            this.rdbVeterano.TabStop = true;
            this.rdbVeterano.Text = "Veterano";
            this.rdbVeterano.UseVisualStyleBackColor = true;
            // 
            // rdbCalouro
            // 
            this.rdbCalouro.AutoSize = true;
            this.rdbCalouro.Location = new System.Drawing.Point(9, 29);
            this.rdbCalouro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCalouro.Name = "rdbCalouro";
            this.rdbCalouro.Size = new System.Drawing.Size(82, 24);
            this.rdbCalouro.TabIndex = 0;
            this.rdbCalouro.TabStop = true;
            this.rdbCalouro.Text = "Calouro";
            this.rdbCalouro.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rdbNoturno);
            this.gbxTurno.Controls.Add(this.rdbVespertino);
            this.gbxTurno.Controls.Add(this.rdbMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(393, 9);
            this.gbxTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTurno.Size = new System.Drawing.Size(150, 154);
            this.gbxTurno.TabIndex = 1;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rdbNoturno
            // 
            this.rdbNoturno.AutoSize = true;
            this.rdbNoturno.Location = new System.Drawing.Point(10, 102);
            this.rdbNoturno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNoturno.Name = "rdbNoturno";
            this.rdbNoturno.Size = new System.Drawing.Size(84, 24);
            this.rdbNoturno.TabIndex = 2;
            this.rdbNoturno.TabStop = true;
            this.rdbNoturno.Text = "Noturno";
            this.rdbNoturno.UseVisualStyleBackColor = true;
            // 
            // rdbVespertino
            // 
            this.rdbVespertino.AutoSize = true;
            this.rdbVespertino.Location = new System.Drawing.Point(10, 66);
            this.rdbVespertino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbVespertino.Name = "rdbVespertino";
            this.rdbVespertino.Size = new System.Drawing.Size(104, 24);
            this.rdbVespertino.TabIndex = 1;
            this.rdbVespertino.TabStop = true;
            this.rdbVespertino.Text = "Vespertino";
            this.rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // rdbMatutino
            // 
            this.rdbMatutino.AutoSize = true;
            this.rdbMatutino.Location = new System.Drawing.Point(9, 29);
            this.rdbMatutino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMatutino.Name = "rdbMatutino";
            this.rdbMatutino.Size = new System.Drawing.Size(89, 24);
            this.rdbMatutino.TabIndex = 0;
            this.rdbMatutino.TabStop = true;
            this.rdbMatutino.Text = "Matutino";
            this.rdbMatutino.UseVisualStyleBackColor = true;
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Location = new System.Drawing.Point(18, 14);
            this.lblSalarioMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(116, 20);
            this.lblSalarioMinimo.TabIndex = 2;
            this.lblSalarioMinimo.Text = "Salário mínimo:";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(18, 71);
            this.lblHorasTrabalhadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(144, 20);
            this.lblHorasTrabalhadas.TabIndex = 3;
            this.lblHorasTrabalhadas.Text = "Horas trabalhadas:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(146, 9);
            this.txtSalarioMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(148, 26);
            this.txtSalarioMinimo.TabIndex = 4;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(171, 66);
            this.txtHorasTrabalhadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(148, 26);
            this.txtHorasTrabalhadas.TabIndex = 5;
            // 
            // lbxResume
            // 
            this.lbxResume.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResume.FormattingEnabled = true;
            this.lbxResume.ItemHeight = 18;
            this.lbxResume.Location = new System.Drawing.Point(18, 198);
            this.lbxResume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxResume.Name = "lbxResume";
            this.lbxResume.Size = new System.Drawing.Size(523, 148);
            this.lbxResume.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(375, 349);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 46);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSituacaoSalarial
            // 
            this.lblSituacaoSalarial.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSituacaoSalarial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSituacaoSalarial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoSalarial.Location = new System.Drawing.Point(70, 350);
            this.lblSituacaoSalarial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacaoSalarial.Name = "lblSituacaoSalarial";
            this.lblSituacaoSalarial.Size = new System.Drawing.Size(300, 46);
            this.lblSituacaoSalarial.TabIndex = 9;
            this.lblSituacaoSalarial.Text = "Situação Salarial";
            this.lblSituacaoSalarial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 402);
            this.Controls.Add(this.lblSituacaoSalarial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbxResume);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.lblSalarioMinimo);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReajusteSalarial";
            this.Text = "Reajuste Salarial";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton rdbVeterano;
        private System.Windows.Forms.RadioButton rdbCalouro;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rdbNoturno;
        private System.Windows.Forms.RadioButton rdbVespertino;
        private System.Windows.Forms.RadioButton rdbMatutino;
        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.ListBox lbxResume;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSituacaoSalarial;
    }
}


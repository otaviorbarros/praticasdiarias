namespace Praticas
{
    partial class FrmSalario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.lboxSalFinal = new System.Windows.Forms.ListBox();
            this.lboxFiltro = new System.Windows.Forms.ListBox();
            this.rbMaior = new System.Windows.Forms.RadioButton();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.btnSeparar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aumento %:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtrar valores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario Final:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(168, 97);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(168, 193);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrar.TabIndex = 5;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(168, 147);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(100, 20);
            this.txtAumento.TabIndex = 7;
            // 
            // lboxSalFinal
            // 
            this.lboxSalFinal.FormattingEnabled = true;
            this.lboxSalFinal.Location = new System.Drawing.Point(437, 68);
            this.lboxSalFinal.Name = "lboxSalFinal";
            this.lboxSalFinal.Size = new System.Drawing.Size(120, 95);
            this.lboxSalFinal.TabIndex = 8;
            // 
            // lboxFiltro
            // 
            this.lboxFiltro.FormattingEnabled = true;
            this.lboxFiltro.Location = new System.Drawing.Point(607, 68);
            this.lboxFiltro.Name = "lboxFiltro";
            this.lboxFiltro.Size = new System.Drawing.Size(120, 95);
            this.lboxFiltro.TabIndex = 9;
            // 
            // rbMaior
            // 
            this.rbMaior.AutoSize = true;
            this.rbMaior.Location = new System.Drawing.Point(307, 193);
            this.rbMaior.Name = "rbMaior";
            this.rbMaior.Size = new System.Drawing.Size(51, 17);
            this.rbMaior.TabIndex = 10;
            this.rbMaior.TabStop = true;
            this.rbMaior.Text = "Maior";
            this.rbMaior.UseVisualStyleBackColor = true;
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.Location = new System.Drawing.Point(307, 226);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(55, 17);
            this.rbMenor.TabIndex = 11;
            this.rbMenor.TabStop = true;
            this.rbMenor.Text = "Menor";
            this.rbMenor.UseVisualStyleBackColor = true;
            // 
            // btnSeparar
            // 
            this.btnSeparar.Location = new System.Drawing.Point(168, 237);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(100, 23);
            this.btnSeparar.TabIndex = 12;
            this.btnSeparar.Text = "Separar";
            this.btnSeparar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(307, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filtro";
            // 
            // FrmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSeparar);
            this.Controls.Add(this.rbMenor);
            this.Controls.Add(this.rbMaior);
            this.Controls.Add(this.lboxFiltro);
            this.Controls.Add(this.lboxSalFinal);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSalario";
            this.Text = "FrmSalario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.ListBox lboxSalFinal;
        private System.Windows.Forms.ListBox lboxFiltro;
        private System.Windows.Forms.RadioButton rbMaior;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
    }
}
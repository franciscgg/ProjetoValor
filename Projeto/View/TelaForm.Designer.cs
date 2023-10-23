namespace Projeto.View
{
    partial class TelaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_primeirovalor = new TextBox();
            tb_segundovalor = new TextBox();
            tb_terceirovalor = new TextBox();
            btn_calcular = new Button();
            lbl_resultado = new Label();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 30);
            label1.TabIndex = 0;
            label1.Text = "Sistema de maior Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(42, 97);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 1;
            label2.Text = "Primeiro Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(42, 132);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 2;
            label3.Text = "Segundo Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(42, 168);
            label4.Name = "label4";
            label4.Size = new Size(98, 17);
            label4.TabIndex = 3;
            label4.Text = "Terceiro Valor:";
            // 
            // tb_primeirovalor
            // 
            tb_primeirovalor.Location = new Point(160, 94);
            tb_primeirovalor.Name = "tb_primeirovalor";
            tb_primeirovalor.Size = new Size(255, 23);
            tb_primeirovalor.TabIndex = 4;
            // 
            // tb_segundovalor
            // 
            tb_segundovalor.Location = new Point(160, 131);
            tb_segundovalor.Name = "tb_segundovalor";
            tb_segundovalor.Size = new Size(255, 23);
            tb_segundovalor.TabIndex = 5;
            // 
            // tb_terceirovalor
            // 
            tb_terceirovalor.Location = new Point(160, 166);
            tb_terceirovalor.Name = "tb_terceirovalor";
            tb_terceirovalor.Size = new Size(255, 23);
            tb_terceirovalor.TabIndex = 6;
            // 
            // btn_calcular
            // 
            btn_calcular.BackColor = Color.Black;
            btn_calcular.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.ForeColor = SystemColors.ButtonFace;
            btn_calcular.Location = new Point(12, 220);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(439, 32);
            btn_calcular.TabIndex = 7;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.BackColor = Color.Red;
            lbl_resultado.Location = new Point(42, 304);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(373, 126);
            lbl_resultado.TabIndex = 8;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.Black;
            btn_limpar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar.ForeColor = SystemColors.Control;
            btn_limpar.Location = new Point(12, 258);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(439, 31);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // TelaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(463, 450);
            Controls.Add(btn_limpar);
            Controls.Add(lbl_resultado);
            Controls.Add(btn_calcular);
            Controls.Add(tb_terceirovalor);
            Controls.Add(tb_segundovalor);
            Controls.Add(tb_primeirovalor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_primeirovalor;
        private TextBox tb_segundovalor;
        private TextBox tb_terceirovalor;
        private Button btn_calcular;
        private Label lbl_resultado;
        private Button btn_limpar;
    }
}
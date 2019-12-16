namespace CifraDeCesar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtChaveCript = new System.Windows.Forms.TextBox();
            this.TxtMensagemCript = new System.Windows.Forms.TextBox();
            this.BtnCript = new System.Windows.Forms.Button();
            this.Txt_ResultadoCRIPT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_ResultadoDECRIPT = new System.Windows.Forms.TextBox();
            this.BtnDECRIPT = new System.Windows.Forms.Button();
            this.TxtMensagemDECript = new System.Windows.Forms.TextBox();
            this.TxtChaveDECRIPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensagem:";
            // 
            // TxtChaveCript
            // 
            this.TxtChaveCript.BackColor = System.Drawing.SystemColors.Control;
            this.TxtChaveCript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtChaveCript.Location = new System.Drawing.Point(80, 55);
            this.TxtChaveCript.Name = "TxtChaveCript";
            this.TxtChaveCript.Size = new System.Drawing.Size(100, 20);
            this.TxtChaveCript.TabIndex = 3;
            // 
            // TxtMensagemCript
            // 
            this.TxtMensagemCript.BackColor = System.Drawing.SystemColors.Control;
            this.TxtMensagemCript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMensagemCript.Location = new System.Drawing.Point(80, 84);
            this.TxtMensagemCript.Name = "TxtMensagemCript";
            this.TxtMensagemCript.Size = new System.Drawing.Size(100, 20);
            this.TxtMensagemCript.TabIndex = 4;
            // 
            // BtnCript
            // 
            this.BtnCript.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCript.Location = new System.Drawing.Point(105, 110);
            this.BtnCript.Name = "BtnCript";
            this.BtnCript.Size = new System.Drawing.Size(75, 23);
            this.BtnCript.TabIndex = 5;
            this.BtnCript.Text = "Criptografar";
            this.BtnCript.UseVisualStyleBackColor = false;
            this.BtnCript.Click += new System.EventHandler(this.BtnCript_Click);
            // 
            // Txt_ResultadoCRIPT
            // 
            this.Txt_ResultadoCRIPT.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_ResultadoCRIPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ResultadoCRIPT.Location = new System.Drawing.Point(15, 177);
            this.Txt_ResultadoCRIPT.Name = "Txt_ResultadoCRIPT";
            this.Txt_ResultadoCRIPT.Size = new System.Drawing.Size(197, 20);
            this.Txt_ResultadoCRIPT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(272, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Resultado:";
            // 
            // Txt_ResultadoDECRIPT
            // 
            this.Txt_ResultadoDECRIPT.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_ResultadoDECRIPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ResultadoDECRIPT.Location = new System.Drawing.Point(275, 177);
            this.Txt_ResultadoDECRIPT.Name = "Txt_ResultadoDECRIPT";
            this.Txt_ResultadoDECRIPT.Size = new System.Drawing.Size(197, 20);
            this.Txt_ResultadoDECRIPT.TabIndex = 13;
            // 
            // BtnDECRIPT
            // 
            this.BtnDECRIPT.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDECRIPT.Location = new System.Drawing.Point(351, 110);
            this.BtnDECRIPT.Name = "BtnDECRIPT";
            this.BtnDECRIPT.Size = new System.Drawing.Size(89, 23);
            this.BtnDECRIPT.TabIndex = 12;
            this.BtnDECRIPT.Text = "Descriptografar";
            this.BtnDECRIPT.UseVisualStyleBackColor = false;
            this.BtnDECRIPT.Click += new System.EventHandler(this.BtnDECRIPT_Click);
            // 
            // TxtMensagemDECript
            // 
            this.TxtMensagemDECript.BackColor = System.Drawing.SystemColors.Control;
            this.TxtMensagemDECript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMensagemDECript.Location = new System.Drawing.Point(340, 84);
            this.TxtMensagemDECript.Name = "TxtMensagemDECript";
            this.TxtMensagemDECript.Size = new System.Drawing.Size(100, 20);
            this.TxtMensagemDECript.TabIndex = 11;
            // 
            // TxtChaveDECRIPT
            // 
            this.TxtChaveDECRIPT.BackColor = System.Drawing.SystemColors.Control;
            this.TxtChaveDECRIPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtChaveDECRIPT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtChaveDECRIPT.Location = new System.Drawing.Point(340, 55);
            this.TxtChaveDECRIPT.Name = "TxtChaveDECRIPT";
            this.TxtChaveDECRIPT.Size = new System.Drawing.Size(100, 20);
            this.TxtChaveDECRIPT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(272, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mensagem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(272, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chave:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "CRIPTOGRAFAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(287, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "DESCRIPTOGRAFAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CifraDeCesar.Properties.Resources.chave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 237);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_ResultadoDECRIPT);
            this.Controls.Add(this.BtnDECRIPT);
            this.Controls.Add(this.TxtMensagemDECript);
            this.Controls.Add(this.TxtChaveDECRIPT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_ResultadoCRIPT);
            this.Controls.Add(this.BtnCript);
            this.Controls.Add(this.TxtMensagemCript);
            this.Controls.Add(this.TxtChaveCript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cifra de César";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtChaveCript;
        private System.Windows.Forms.TextBox TxtMensagemCript;
        private System.Windows.Forms.Button BtnCript;
        private System.Windows.Forms.TextBox Txt_ResultadoCRIPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_ResultadoDECRIPT;
        private System.Windows.Forms.Button BtnDECRIPT;
        private System.Windows.Forms.TextBox TxtMensagemDECript;
        private System.Windows.Forms.TextBox TxtChaveDECRIPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


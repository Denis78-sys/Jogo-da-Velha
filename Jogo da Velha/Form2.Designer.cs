using System;

namespace Jogo_da_Velha
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1_nome_jogador_vez = new System.Windows.Forms.Label();
            this.label_faltam = new System.Windows.Forms.Label();
            this.label2_n_jogadas_fim = new System.Windows.Forms.Label();
            this.label_jogadas = new System.Windows.Forms.Label();
            this.label_nome_jogador_1 = new System.Windows.Forms.Label();
            this.label_nome_jogador_2 = new System.Windows.Forms.Label();
            this.n_pontos_jogador1 = new System.Windows.Forms.Label();
            this.n_pontos_jogador2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label_vencedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_empate = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_nome_jogador_vez
            // 
            this.label1_nome_jogador_vez.AutoSize = true;
            this.label1_nome_jogador_vez.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_nome_jogador_vez.ForeColor = System.Drawing.Color.Blue;
            this.label1_nome_jogador_vez.Location = new System.Drawing.Point(519, 63);
            this.label1_nome_jogador_vez.Name = "label1_nome_jogador_vez";
            this.label1_nome_jogador_vez.Size = new System.Drawing.Size(37, 43);
            this.label1_nome_jogador_vez.TabIndex = 0;
            this.label1_nome_jogador_vez.Text = "...";
            this.label1_nome_jogador_vez.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_faltam
            // 
            this.label_faltam.AutoSize = true;
            this.label_faltam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_faltam.ForeColor = System.Drawing.Color.Black;
            this.label_faltam.Location = new System.Drawing.Point(564, 178);
            this.label_faltam.Name = "label_faltam";
            this.label_faltam.Size = new System.Drawing.Size(90, 25);
            this.label_faltam.TabIndex = 1;
            this.label_faltam.Text = "Faltam ";
            // 
            // label2_n_jogadas_fim
            // 
            this.label2_n_jogadas_fim.AutoSize = true;
            this.label2_n_jogadas_fim.BackColor = System.Drawing.Color.Yellow;
            this.label2_n_jogadas_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_n_jogadas_fim.ForeColor = System.Drawing.Color.Red;
            this.label2_n_jogadas_fim.Location = new System.Drawing.Point(646, 169);
            this.label2_n_jogadas_fim.Name = "label2_n_jogadas_fim";
            this.label2_n_jogadas_fim.Size = new System.Drawing.Size(36, 37);
            this.label2_n_jogadas_fim.TabIndex = 2;
            this.label2_n_jogadas_fim.Text = "9";
            this.label2_n_jogadas_fim.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_jogadas
            // 
            this.label_jogadas.AutoSize = true;
            this.label_jogadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jogadas.ForeColor = System.Drawing.Color.Black;
            this.label_jogadas.Location = new System.Drawing.Point(687, 178);
            this.label_jogadas.Name = "label_jogadas";
            this.label_jogadas.Size = new System.Drawing.Size(95, 25);
            this.label_jogadas.TabIndex = 3;
            this.label_jogadas.Text = "jogadas";
            // 
            // label_nome_jogador_1
            // 
            this.label_nome_jogador_1.AutoSize = true;
            this.label_nome_jogador_1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_jogador_1.ForeColor = System.Drawing.Color.Red;
            this.label_nome_jogador_1.Location = new System.Drawing.Point(185, 221);
            this.label_nome_jogador_1.Name = "label_nome_jogador_1";
            this.label_nome_jogador_1.Size = new System.Drawing.Size(91, 24);
            this.label_nome_jogador_1.TabIndex = 4;
            this.label_nome_jogador_1.Text = "Jogador 1";
            // 
            // label_nome_jogador_2
            // 
            this.label_nome_jogador_2.AutoSize = true;
            this.label_nome_jogador_2.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_jogador_2.ForeColor = System.Drawing.Color.Blue;
            this.label_nome_jogador_2.Location = new System.Drawing.Point(185, 304);
            this.label_nome_jogador_2.Name = "label_nome_jogador_2";
            this.label_nome_jogador_2.Size = new System.Drawing.Size(91, 24);
            this.label_nome_jogador_2.TabIndex = 5;
            this.label_nome_jogador_2.Text = "Jogador 2";
            // 
            // n_pontos_jogador1
            // 
            this.n_pontos_jogador1.AutoSize = true;
            this.n_pontos_jogador1.BackColor = System.Drawing.Color.Yellow;
            this.n_pontos_jogador1.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_pontos_jogador1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n_pontos_jogador1.Location = new System.Drawing.Point(322, 213);
            this.n_pontos_jogador1.Name = "n_pontos_jogador1";
            this.n_pontos_jogador1.Size = new System.Drawing.Size(31, 34);
            this.n_pontos_jogador1.TabIndex = 6;
            this.n_pontos_jogador1.Text = "0";
            this.n_pontos_jogador1.Click += new System.EventHandler(this.n_pontos_jogador1_Click);
            // 
            // n_pontos_jogador2
            // 
            this.n_pontos_jogador2.AutoSize = true;
            this.n_pontos_jogador2.BackColor = System.Drawing.Color.Yellow;
            this.n_pontos_jogador2.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_pontos_jogador2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n_pontos_jogador2.Location = new System.Drawing.Point(322, 296);
            this.n_pontos_jogador2.Name = "n_pontos_jogador2";
            this.n_pontos_jogador2.Size = new System.Drawing.Size(31, 34);
            this.n_pontos_jogador2.TabIndex = 7;
            this.n_pontos_jogador2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(398, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "vitórias";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(398, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "vitórias";
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.Blue;
            this.btn_7.Location = new System.Drawing.Point(526, 221);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(90, 77);
            this.btn_7.TabIndex = 10;
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.Blue;
            this.btn_8.Location = new System.Drawing.Point(622, 221);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(90, 77);
            this.btn_8.TabIndex = 11;
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.Blue;
            this.btn_9.Location = new System.Drawing.Point(718, 221);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(90, 77);
            this.btn_9.TabIndex = 12;
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.Blue;
            this.btn_4.Location = new System.Drawing.Point(526, 304);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(90, 77);
            this.btn_4.TabIndex = 13;
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.Blue;
            this.btn_5.Location = new System.Drawing.Point(622, 304);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(90, 77);
            this.btn_5.TabIndex = 14;
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.Blue;
            this.btn_6.Location = new System.Drawing.Point(718, 304);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(90, 77);
            this.btn_6.TabIndex = 15;
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.Blue;
            this.btn_1.Location = new System.Drawing.Point(526, 387);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(90, 77);
            this.btn_1.TabIndex = 16;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.Blue;
            this.btn_2.Location = new System.Drawing.Point(622, 387);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(90, 77);
            this.btn_2.TabIndex = 17;
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.Blue;
            this.btn_3.Location = new System.Drawing.Point(718, 387);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(90, 77);
            this.btn_3.TabIndex = 18;
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button11.Location = new System.Drawing.Point(890, 221);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 64);
            this.button11.TabIndex = 20;
            this.button11.Text = "NOVO JOGO";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(902, 434);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 30);
            this.button12.TabIndex = 21;
            this.button12.Text = "SAIR";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label_vencedor
            // 
            this.label_vencedor.AutoSize = true;
            this.label_vencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vencedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_vencedor.Location = new System.Drawing.Point(567, 472);
            this.label_vencedor.Name = "label_vencedor";
            this.label_vencedor.Size = new System.Drawing.Size(0, 25);
            this.label_vencedor.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(202, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Empate";
            // 
            // label_empate
            // 
            this.label_empate.AutoSize = true;
            this.label_empate.BackColor = System.Drawing.Color.Yellow;
            this.label_empate.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_empate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_empate.Location = new System.Drawing.Point(322, 392);
            this.label_empate.Name = "label_empate";
            this.label_empate.Size = new System.Drawing.Size(31, 34);
            this.label_empate.TabIndex = 25;
            this.label_empate.Text = "0";
            // 
            // btn_reset
            // 
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(890, 307);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(112, 33);
            this.btn_reset.TabIndex = 26;
            this.btn_reset.Text = "RESETAR JOGO";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1024, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Desenvolvido por Denis Marques";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1212, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label_empate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_vencedor);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.n_pontos_jogador2);
            this.Controls.Add(this.n_pontos_jogador1);
            this.Controls.Add(this.label_nome_jogador_2);
            this.Controls.Add(this.label_nome_jogador_1);
            this.Controls.Add(this.label_jogadas);
            this.Controls.Add(this.label2_n_jogadas_fim);
            this.Controls.Add(this.label_faltam);
            this.Controls.Add(this.label1_nome_jogador_vez);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1_nome_jogador_vez;
        private System.Windows.Forms.Label label_faltam;
        private System.Windows.Forms.Label label2_n_jogadas_fim;
        private System.Windows.Forms.Label label_jogadas;
        private System.Windows.Forms.Label label_nome_jogador_1;
        private System.Windows.Forms.Label label_nome_jogador_2;
        private System.Windows.Forms.Label n_pontos_jogador1;
        private System.Windows.Forms.Label n_pontos_jogador2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label_vencedor;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_empate;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label2;
    }
}
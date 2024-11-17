namespace BatalhaNaval
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
            this.txtPlayerPhase = new System.Windows.Forms.Label();
            this.txtPlayerScore = new System.Windows.Forms.Label();
            this.txtPlayerScoreLabel = new System.Windows.Forms.Label();
            this.txtCPUScore = new System.Windows.Forms.Label();
            this.txtCPUScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerPhase
            // 
            this.txtPlayerPhase.AutoSize = true;
            this.txtPlayerPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerPhase.Location = new System.Drawing.Point(128, 416);
            this.txtPlayerPhase.Name = "txtPlayerPhase";
            this.txtPlayerPhase.Size = new System.Drawing.Size(208, 24);
            this.txtPlayerPhase.TabIndex = 0;
            this.txtPlayerPhase.Text = "Escolha suas posições!";
            // 
            // txtPlayerScore
            // 
            this.txtPlayerScore.AutoSize = true;
            this.txtPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerScore.Location = new System.Drawing.Point(220, 16);
            this.txtPlayerScore.Name = "txtPlayerScore";
            this.txtPlayerScore.Size = new System.Drawing.Size(20, 24);
            this.txtPlayerScore.TabIndex = 0;
            this.txtPlayerScore.Text = "0";
            // 
            // txtPlayerScoreLabel
            // 
            this.txtPlayerScoreLabel.AutoSize = true;
            this.txtPlayerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerScoreLabel.Location = new System.Drawing.Point(147, 16);
            this.txtPlayerScoreLabel.Name = "txtPlayerScoreLabel";
            this.txtPlayerScoreLabel.Size = new System.Drawing.Size(67, 24);
            this.txtPlayerScoreLabel.TabIndex = 0;
            this.txtPlayerScoreLabel.Text = "Player:";
            // 
            // txtCPUScore
            // 
            this.txtCPUScore.AutoSize = true;
            this.txtCPUScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUScore.Location = new System.Drawing.Point(616, 19);
            this.txtCPUScore.Name = "txtCPUScore";
            this.txtCPUScore.Size = new System.Drawing.Size(20, 24);
            this.txtCPUScore.TabIndex = 0;
            this.txtCPUScore.Text = "0";
            // 
            // txtCPUScoreLabel
            // 
            this.txtCPUScoreLabel.AutoSize = true;
            this.txtCPUScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUScoreLabel.Location = new System.Drawing.Point(543, 19);
            this.txtCPUScoreLabel.Name = "txtCPUScoreLabel";
            this.txtCPUScoreLabel.Size = new System.Drawing.Size(53, 24);
            this.txtCPUScoreLabel.TabIndex = 0;
            this.txtCPUScoreLabel.Text = "CPU:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtCPUScoreLabel);
            this.Controls.Add(this.txtCPUScore);
            this.Controls.Add(this.txtPlayerScoreLabel);
            this.Controls.Add(this.txtPlayerScore);
            this.Controls.Add(this.txtPlayerPhase);
            this.Name = "Form1";
            this.Text = "BatalhaNaval";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayerPhase;
        private System.Windows.Forms.Label txtPlayerScore;
        private System.Windows.Forms.Label txtPlayerScoreLabel;
        private System.Windows.Forms.Label txtCPUScore;
        private System.Windows.Forms.Label txtCPUScoreLabel;
    }
}


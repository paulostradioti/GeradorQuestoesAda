namespace WinFormsApp2
{
    partial class Gerador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.btnMultipleChoice = new System.Windows.Forms.Button();
            this.btnTrueFalse = new System.Windows.Forms.Button();
            this.btnGaps = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuestion.AutoScroll = true;
            this.pnlQuestion.AutoSize = true;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 57);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(676, 664);
            this.pnlQuestion.TabIndex = 0;
            // 
            // btnMultipleChoice
            // 
            this.btnMultipleChoice.Location = new System.Drawing.Point(136, 15);
            this.btnMultipleChoice.Name = "btnMultipleChoice";
            this.btnMultipleChoice.Size = new System.Drawing.Size(139, 23);
            this.btnMultipleChoice.TabIndex = 1;
            this.btnMultipleChoice.Text = "Múltipla Escolha";
            this.btnMultipleChoice.UseVisualStyleBackColor = true;
            this.btnMultipleChoice.Click += new System.EventHandler(this.btnMultipleChoice_Click);
            // 
            // btnTrueFalse
            // 
            this.btnTrueFalse.Location = new System.Drawing.Point(281, 15);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(139, 23);
            this.btnTrueFalse.TabIndex = 2;
            this.btnTrueFalse.Text = "Verdadeiro ou Falso";
            this.btnTrueFalse.UseVisualStyleBackColor = true;
            this.btnTrueFalse.Click += new System.EventHandler(this.btnTrueFalse_Click);
            // 
            // btnGaps
            // 
            this.btnGaps.Location = new System.Drawing.Point(426, 15);
            this.btnGaps.Name = "btnGaps";
            this.btnGaps.Size = new System.Drawing.Size(139, 23);
            this.btnGaps.TabIndex = 3;
            this.btnGaps.Text = "Gaps";
            this.btnGaps.UseVisualStyleBackColor = true;
            this.btnGaps.Click += new System.EventHandler(this.btnGaps_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnMultipleChoice);
            this.panel2.Controls.Add(this.btnGaps);
            this.panel2.Controls.Add(this.btnTrueFalse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 51);
            this.panel2.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(594, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Gerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(676, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlQuestion);
            this.Name = "Gerador";
            this.Text = "Ada - Gerador de Questões";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlQuestion;
        private Button btnMultipleChoice;
        private Button btnTrueFalse;
        private Button btnGaps;
        private Panel panel2;
        private Button btnClear;
    }
}
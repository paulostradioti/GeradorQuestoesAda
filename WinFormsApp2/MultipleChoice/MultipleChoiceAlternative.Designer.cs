namespace GeradorQuestoes.MultipleChoice
{
    partial class MultipleChoiceAlternative
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbCorrect = new System.Windows.Forms.RadioButton();
            this.txtAlternativa1 = new System.Windows.Forms.TextBox();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTitle
            // 
            this.grpTitle.Controls.Add(this.label1);
            this.grpTitle.Controls.Add(this.lblTexto);
            this.grpTitle.Controls.Add(this.textBox1);
            this.grpTitle.Controls.Add(this.rbCorrect);
            this.grpTitle.Controls.Add(this.txtAlternativa1);
            this.grpTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTitle.Location = new System.Drawing.Point(3, 3);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(629, 246);
            this.grpTitle.TabIndex = 5;
            this.grpTitle.TabStop = false;
            this.grpTitle.Text = "Alternativa ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Feedback";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(11, 32);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(50, 21);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Texto";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 50);
            this.textBox1.TabIndex = 3;
            // 
            // rbCorrect
            // 
            this.rbCorrect.AutoSize = true;
            this.rbCorrect.Location = new System.Drawing.Point(12, 215);
            this.rbCorrect.Name = "rbCorrect";
            this.rbCorrect.Size = new System.Drawing.Size(83, 25);
            this.rbCorrect.TabIndex = 2;
            this.rbCorrect.TabStop = true;
            this.rbCorrect.Text = "Correta";
            this.rbCorrect.UseVisualStyleBackColor = true;
            // 
            // txtAlternativa1
            // 
            this.txtAlternativa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlternativa1.Location = new System.Drawing.Point(11, 56);
            this.txtAlternativa1.Multiline = true;
            this.txtAlternativa1.Name = "txtAlternativa1";
            this.txtAlternativa1.Size = new System.Drawing.Size(608, 50);
            this.txtAlternativa1.TabIndex = 1;
            // 
            // MultipleChoiceAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTitle);
            this.Name = "MultipleChoiceAlternative";
            this.Size = new System.Drawing.Size(638, 256);
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpTitle;
        private RadioButton rbCorrect;
        private TextBox txtAlternativa1;
        private Label label1;
        private Label lblTexto;
        private TextBox textBox1;
    }
}

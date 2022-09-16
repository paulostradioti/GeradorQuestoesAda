namespace GeradorQuestoes.MultipleChoice
{
    partial class MultipleChoiceControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.tabAlternativa1 = new System.Windows.Forms.TabPage();
            this.cbCorrect = new System.Windows.Forms.CheckBox();
            this.txtFeedback1 = new System.Windows.Forms.TextBox();
            this.txtAlternativa1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.tabAnswers = new System.Windows.Forms.TabControl();
            this.tabAlternativa2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabAlternativa3 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabAlternativa4 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabAlternativa1.SuspendLayout();
            this.tabAnswers.SuspendLayout();
            this.tabAlternativa2.SuspendLayout();
            this.tabAlternativa3.SuspendLayout();
            this.tabAlternativa4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Múltipla Escolha";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnunciado.Location = new System.Drawing.Point(6, 28);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(617, 66);
            this.txtEnunciado.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEnunciado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enunciado";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(577, 392);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // tabAlternativa1
            // 
            this.tabAlternativa1.Controls.Add(this.cbCorrect);
            this.tabAlternativa1.Controls.Add(this.txtFeedback1);
            this.tabAlternativa1.Controls.Add(this.txtAlternativa1);
            this.tabAlternativa1.Controls.Add(this.label2);
            this.tabAlternativa1.Controls.Add(this.lblTexto);
            this.tabAlternativa1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabAlternativa1.Location = new System.Drawing.Point(4, 24);
            this.tabAlternativa1.Name = "tabAlternativa1";
            this.tabAlternativa1.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlternativa1.Size = new System.Drawing.Size(641, 203);
            this.tabAlternativa1.TabIndex = 0;
            this.tabAlternativa1.Text = "Alternativa 1";
            this.tabAlternativa1.UseVisualStyleBackColor = true;
            // 
            // cbCorrect
            // 
            this.cbCorrect.AutoSize = true;
            this.cbCorrect.Location = new System.Drawing.Point(11, 165);
            this.cbCorrect.Name = "cbCorrect";
            this.cbCorrect.Size = new System.Drawing.Size(84, 25);
            this.cbCorrect.TabIndex = 6;
            this.cbCorrect.Text = "Correta";
            this.cbCorrect.UseVisualStyleBackColor = true;
            // 
            // txtFeedback1
            // 
            this.txtFeedback1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback1.Location = new System.Drawing.Point(11, 104);
            this.txtFeedback1.Multiline = true;
            this.txtFeedback1.Name = "txtFeedback1";
            this.txtFeedback1.Size = new System.Drawing.Size(608, 50);
            this.txtFeedback1.TabIndex = 3;
            // 
            // txtAlternativa1
            // 
            this.txtAlternativa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlternativa1.Location = new System.Drawing.Point(11, 27);
            this.txtAlternativa1.Multiline = true;
            this.txtAlternativa1.Name = "txtAlternativa1";
            this.txtAlternativa1.Size = new System.Drawing.Size(608, 50);
            this.txtAlternativa1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Feedback";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(0, 3);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(50, 21);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Texto";
            // 
            // tabAnswers
            // 
            this.tabAnswers.Controls.Add(this.tabAlternativa1);
            this.tabAnswers.Controls.Add(this.tabAlternativa2);
            this.tabAnswers.Controls.Add(this.tabAlternativa3);
            this.tabAnswers.Controls.Add(this.tabAlternativa4);
            this.tabAnswers.Location = new System.Drawing.Point(8, 136);
            this.tabAnswers.Name = "tabAnswers";
            this.tabAnswers.SelectedIndex = 0;
            this.tabAnswers.Size = new System.Drawing.Size(649, 231);
            this.tabAnswers.TabIndex = 4;
            // 
            // tabAlternativa2
            // 
            this.tabAlternativa2.Controls.Add(this.checkBox1);
            this.tabAlternativa2.Controls.Add(this.textBox1);
            this.tabAlternativa2.Controls.Add(this.textBox2);
            this.tabAlternativa2.Controls.Add(this.label3);
            this.tabAlternativa2.Controls.Add(this.label4);
            this.tabAlternativa2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabAlternativa2.Location = new System.Drawing.Point(4, 24);
            this.tabAlternativa2.Name = "tabAlternativa2";
            this.tabAlternativa2.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlternativa2.Size = new System.Drawing.Size(641, 203);
            this.tabAlternativa2.TabIndex = 1;
            this.tabAlternativa2.Text = "Alternativa 2";
            this.tabAlternativa2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Correta";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(11, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 50);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(11, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(608, 50);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Feedback";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Texto";
            // 
            // tabAlternativa3
            // 
            this.tabAlternativa3.Controls.Add(this.checkBox2);
            this.tabAlternativa3.Controls.Add(this.textBox3);
            this.tabAlternativa3.Controls.Add(this.textBox4);
            this.tabAlternativa3.Controls.Add(this.label5);
            this.tabAlternativa3.Controls.Add(this.label6);
            this.tabAlternativa3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabAlternativa3.Location = new System.Drawing.Point(4, 24);
            this.tabAlternativa3.Name = "tabAlternativa3";
            this.tabAlternativa3.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlternativa3.Size = new System.Drawing.Size(641, 203);
            this.tabAlternativa3.TabIndex = 2;
            this.tabAlternativa3.Text = "Alternativa 3";
            this.tabAlternativa3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 168);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 25);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Correta";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(11, 104);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(608, 50);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(11, 27);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(608, 50);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Feedback";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Texto";
            // 
            // tabAlternativa4
            // 
            this.tabAlternativa4.Controls.Add(this.checkBox3);
            this.tabAlternativa4.Controls.Add(this.textBox5);
            this.tabAlternativa4.Controls.Add(this.textBox6);
            this.tabAlternativa4.Controls.Add(this.label7);
            this.tabAlternativa4.Controls.Add(this.label8);
            this.tabAlternativa4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabAlternativa4.Location = new System.Drawing.Point(4, 24);
            this.tabAlternativa4.Name = "tabAlternativa4";
            this.tabAlternativa4.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlternativa4.Size = new System.Drawing.Size(641, 203);
            this.tabAlternativa4.TabIndex = 3;
            this.tabAlternativa4.Text = "Alternativa 4";
            this.tabAlternativa4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 168);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 25);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Correta";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(11, 104);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(608, 50);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(11, 27);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(608, 50);
            this.textBox6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Feedback";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Texto";
            // 
            // MultipleChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.tabAnswers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MultipleChoiceControl";
            this.Size = new System.Drawing.Size(664, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAlternativa1.ResumeLayout(false);
            this.tabAlternativa1.PerformLayout();
            this.tabAnswers.ResumeLayout(false);
            this.tabAlternativa2.ResumeLayout(false);
            this.tabAlternativa2.PerformLayout();
            this.tabAlternativa3.ResumeLayout(false);
            this.tabAlternativa3.PerformLayout();
            this.tabAlternativa4.ResumeLayout(false);
            this.tabAlternativa4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtEnunciado;
        private Label label1;
        private Button btnGerar;
        private TabPage tabAlternativa1;
        private TextBox txtFeedback1;
        private TextBox txtAlternativa1;
        private Label label2;
        private Label lblTexto;
        private TabControl tabAnswers;
        private CheckBox cbCorrect;
        private TabPage tabAlternativa2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TabPage tabAlternativa3;
        private CheckBox checkBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TabPage tabAlternativa4;
        private CheckBox checkBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
    }
}

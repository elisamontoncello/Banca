namespace Banca
{
    partial class Salvadanaio
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
            creditoAttualeLbl = new Label();
            label1 = new Label();
            numericUpDownPercentuale = new NumericUpDown();
            label2 = new Label();
            calcoloRisparmioBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            risparmioMensileTxt = new TextBox();
            risparmioAnnualeTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercentuale).BeginInit();
            SuspendLayout();
            // 
            // creditoAttualeLbl
            // 
            creditoAttualeLbl.AutoSize = true;
            creditoAttualeLbl.Location = new Point(955, 81);
            creditoAttualeLbl.Name = "creditoAttualeLbl";
            creditoAttualeLbl.Size = new Size(52, 21);
            creditoAttualeLbl.TabIndex = 0;
            creditoAttualeLbl.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(664, 81);
            label1.Name = "label1";
            label1.Size = new Size(219, 21);
            label1.TabIndex = 1;
            label1.Text = "Credito presente sul tuo conto";
            // 
            // numericUpDownPercentuale
            // 
            numericUpDownPercentuale.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownPercentuale.Location = new Point(803, 184);
            numericUpDownPercentuale.Name = "numericUpDownPercentuale";
            numericUpDownPercentuale.Size = new Size(150, 29);
            numericUpDownPercentuale.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(984, 186);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 3;
            label2.Text = "%";
            // 
            // calcoloRisparmioBtn
            // 
            calcoloRisparmioBtn.BackColor = Color.FromArgb(192, 192, 255);
            calcoloRisparmioBtn.Location = new Point(829, 287);
            calcoloRisparmioBtn.Name = "calcoloRisparmioBtn";
            calcoloRisparmioBtn.Size = new Size(94, 29);
            calcoloRisparmioBtn.TabIndex = 4;
            calcoloRisparmioBtn.Text = "Calcola";
            calcoloRisparmioBtn.UseVisualStyleBackColor = false;
            calcoloRisparmioBtn.Click += calcoloRisparmioBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 388);
            label3.Name = "label3";
            label3.Size = new Size(471, 21);
            label3.TabIndex = 7;
            label3.Text = "Credito che hai risparmiato questo mese applicando la percentuale";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 477);
            label4.Name = "label4";
            label4.Size = new Size(271, 21);
            label4.TabIndex = 8;
            label4.Text = "Credito che risparmieresti in un anno ";
            // 
            // risparmioMensileTxt
            // 
            risparmioMensileTxt.Location = new Point(1046, 380);
            risparmioMensileTxt.Name = "risparmioMensileTxt";
            risparmioMensileTxt.ReadOnly = true;
            risparmioMensileTxt.Size = new Size(125, 29);
            risparmioMensileTxt.TabIndex = 9;
            // 
            // risparmioAnnualeTxt
            // 
            risparmioAnnualeTxt.Location = new Point(856, 469);
            risparmioAnnualeTxt.Name = "risparmioAnnualeTxt";
            risparmioAnnualeTxt.ReadOnly = true;
            risparmioAnnualeTxt.Size = new Size(125, 29);
            risparmioAnnualeTxt.TabIndex = 10;
            // 
            // Salvadanaio
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1765, 744);
            Controls.Add(risparmioAnnualeTxt);
            Controls.Add(risparmioMensileTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(calcoloRisparmioBtn);
            Controls.Add(label2);
            Controls.Add(numericUpDownPercentuale);
            Controls.Add(label1);
            Controls.Add(creditoAttualeLbl);
            Name = "Salvadanaio";
            Text = "Salvadanaio";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercentuale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label creditoAttualeLbl;
        private Label label1;
        private NumericUpDown numericUpDownPercentuale;
        private Label label2;
        private Button calcoloRisparmioBtn;
        private Label label3;
        private Label label4;
        private TextBox risparmioMensileTxt;
        private TextBox risparmioAnnualeTxt;
    }
}
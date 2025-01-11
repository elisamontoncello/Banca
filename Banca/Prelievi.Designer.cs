namespace Banca
{
    partial class Prelievi
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
            prelievoBtn = new Button();
            saldoLbl = new Label();
            numericUpDown1 = new NumericUpDown();
            creditoTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(598, 28);
            label1.Name = "label1";
            label1.Size = new Size(565, 23);
            label1.TabIndex = 0;
            label1.Text = "Effettua un prelievo tramite l'app e recati in posta a ritirare il denato";
            // 
            // prelievoBtn
            // 
            prelievoBtn.BackColor = Color.FromArgb(192, 192, 255);
            prelievoBtn.Location = new Point(1102, 324);
            prelievoBtn.Name = "prelievoBtn";
            prelievoBtn.Size = new Size(102, 50);
            prelievoBtn.TabIndex = 3;
            prelievoBtn.Text = "Preleva";
            prelievoBtn.UseVisualStyleBackColor = false;
            prelievoBtn.Click += prelievoBtn_Click;
            // 
            // saldoLbl
            // 
            saldoLbl.AutoSize = true;
            saldoLbl.Location = new Point(326, 304);
            saldoLbl.Name = "saldoLbl";
            saldoLbl.Size = new Size(0, 21);
            saldoLbl.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Location = new Point(807, 195);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 29);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // creditoTxt
            // 
            creditoTxt.Location = new Point(739, 110);
            creditoTxt.Name = "creditoTxt";
            creditoTxt.ReadOnly = true;
            creditoTxt.Size = new Size(281, 29);
            creditoTxt.TabIndex = 14;
            // 
            // Prelievi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1769, 743);
            Controls.Add(creditoTxt);
            Controls.Add(numericUpDown1);
            Controls.Add(saldoLbl);
            Controls.Add(prelievoBtn);
            Controls.Add(label1);
            Name = "Prelievi";
            Text = "Prelievi";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button prelievoBtn;
        private Label saldoLbl;
        private NumericUpDown numericUpDown1;
        private TextBox creditoTxt;
    }
}
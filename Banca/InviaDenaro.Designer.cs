namespace Banca
{
    partial class InviaDenaro
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
            userNameTxt = new TextBox();
            numericUpDown1 = new NumericUpDown();
            inviaBtn = new Button();
            creditoTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // userNameTxt
            // 
            userNameTxt.Location = new Point(332, 200);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.Size = new Size(125, 29);
            userNameTxt.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Location = new Point(321, 301);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 29);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // inviaBtn
            // 
            inviaBtn.Location = new Point(343, 369);
            inviaBtn.Name = "inviaBtn";
            inviaBtn.Size = new Size(94, 29);
            inviaBtn.TabIndex = 12;
            inviaBtn.Text = "Invia";
            inviaBtn.UseVisualStyleBackColor = true;
            inviaBtn.Click += inviaBtn_Click_1;
            // 
            // creditoTxt
            // 
            creditoTxt.Location = new Point(246, 88);
            creditoTxt.Name = "creditoTxt";
            creditoTxt.Size = new Size(281, 29);
            creditoTxt.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 22);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 14;
            label1.Text = "Trasita verso chi vuoi!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 154);
            label2.Name = "label2";
            label2.Size = new Size(475, 21);
            label2.TabIndex = 15;
            label2.Text = "Inserisci il numero di account dell'utente a cui vuoi inviare il denaro";
            // 
            // InviaDenaro
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(creditoTxt);
            Controls.Add(inviaBtn);
            Controls.Add(numericUpDown1);
            Controls.Add(userNameTxt);
            Name = "InviaDenaro";
            Text = "InviaDenaro";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userNameTxt;
        private NumericUpDown numericUpDown1;
        private Button inviaBtn;
        private TextBox creditoTxt;
        private Label label1;
        private Label label2;
    }
}
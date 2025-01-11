namespace Banca
{
    partial class Registrazione_Form
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
            button1 = new Button();
            label3 = new Label();
            usrtxtR = new TextBox();
            passtxtR = new TextBox();
            checkBoxPassword = new CheckBox();
            infobtn = new Button();
            chisiamoBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 126);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 194);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 2;
            label2.Text = "Crea Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(787, 277);
            button1.Name = "button1";
            button1.Size = new Size(130, 38);
            button1.TabIndex = 3;
            button1.Text = "Registrati";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(631, 22);
            label3.Name = "label3";
            label3.Size = new Size(469, 23);
            label3.TabIndex = 4;
            label3.Text = "Registrati per ottenere la nostra carta di credito esclusiva";
            // 
            // usrtxtR
            // 
            usrtxtR.Location = new Point(736, 118);
            usrtxtR.Name = "usrtxtR";
            usrtxtR.Size = new Size(219, 29);
            usrtxtR.TabIndex = 5;
            // 
            // passtxtR
            // 
            passtxtR.Location = new Point(736, 186);
            passtxtR.Name = "passtxtR";
            passtxtR.PasswordChar = '*';
            passtxtR.Size = new Size(219, 29);
            passtxtR.TabIndex = 6;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.Location = new Point(1042, 186);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(81, 25);
            checkBoxPassword.TabIndex = 7;
            checkBoxPassword.Text = "mostra";
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // infobtn
            // 
            infobtn.BackColor = Color.FromArgb(192, 192, 255);
            infobtn.Location = new Point(1250, 421);
            infobtn.Name = "infobtn";
            infobtn.Size = new Size(96, 67);
            infobtn.TabIndex = 9;
            infobtn.Text = "!";
            infobtn.UseVisualStyleBackColor = false;
            infobtn.Click += infobtn_Click;
            // 
            // chisiamoBtn
            // 
            chisiamoBtn.BackColor = Color.FromArgb(192, 192, 255);
            chisiamoBtn.Location = new Point(1135, 421);
            chisiamoBtn.Name = "chisiamoBtn";
            chisiamoBtn.Size = new Size(94, 67);
            chisiamoBtn.TabIndex = 10;
            chisiamoBtn.Text = "?";
            chisiamoBtn.UseVisualStyleBackColor = false;
            chisiamoBtn.Click += chisiamoBtn_Click;
            // 
            // Registrazione_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1780, 743);
            Controls.Add(chisiamoBtn);
            Controls.Add(infobtn);
            Controls.Add(checkBoxPassword);
            Controls.Add(passtxtR);
            Controls.Add(usrtxtR);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrazione_Form";
            Text = "Registrazione_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox usrtxtR;
        private TextBox passtxtR;
        private CheckBox checkBoxPassword;
        private Button infobtn;
        private Button chisiamoBtn;
    }
}
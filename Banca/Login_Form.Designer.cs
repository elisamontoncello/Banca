namespace Banca
{
    partial class Login_Form
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
            passtxt = new TextBox();
            button2 = new Button();
            checkBoxPassword = new CheckBox();
            usrtxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 85);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 144);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(200, 217);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 23);
            label3.Name = "label3";
            label3.Size = new Size(415, 23);
            label3.TabIndex = 3;
            label3.Text = "Accesso per possessori della nostra carta di credito";
            // 
            // passtxt
            // 
            passtxt.Location = new Point(255, 136);
            passtxt.Name = "passtxt";
            passtxt.PasswordChar = '*';
            passtxt.Size = new Size(213, 29);
            passtxt.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(374, 280);
            button2.Name = "button2";
            button2.Size = new Size(282, 87);
            button2.TabIndex = 6;
            button2.Text = "Registrati se non possiedi un \r\naccount!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.Location = new Point(483, 138);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(81, 25);
            checkBoxPassword.TabIndex = 7;
            checkBoxPassword.Text = "mostra";
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // usrtxt
            // 
            usrtxt.Location = new Point(255, 77);
            usrtxt.Name = "usrtxt";
            usrtxt.Size = new Size(213, 29);
            usrtxt.TabIndex = 8;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(usrtxt);
            Controls.Add(checkBoxPassword);
            Controls.Add(button2);
            Controls.Add(passtxt);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Form";
            Text = "Login_Form";
            FormClosing += Login_Form_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox passtxt;
        private Button button2;
        private CheckBox checkBoxPassword;
        private TextBox usrtxt;
    }
}
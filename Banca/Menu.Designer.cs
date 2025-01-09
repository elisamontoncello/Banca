﻿namespace Banca
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            impostaInformazioniToolStripMenuItem = new ToolStripMenuItem();
            transizioniToolStripMenuItem = new ToolStripMenuItem();
            prelieviToolStripMenuItem = new ToolStripMenuItem();
            inviaDenaroToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            aggiungiCreditoBtn = new Button();
            creditoTxt = new TextBox();
            altroToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, transizioniToolStripMenuItem, altroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impostaInformazioniToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(80, 25);
            accountToolStripMenuItem.Text = "Account";
            // 
            // impostaInformazioniToolStripMenuItem
            // 
            impostaInformazioniToolStripMenuItem.Name = "impostaInformazioniToolStripMenuItem";
            impostaInformazioniToolStripMenuItem.Size = new Size(242, 26);
            impostaInformazioniToolStripMenuItem.Text = "Imposta informazioni";
            impostaInformazioniToolStripMenuItem.Click += impostaInformazioniToolStripMenuItem_Click;
            // 
            // transizioniToolStripMenuItem
            // 
            transizioniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prelieviToolStripMenuItem, inviaDenaroToolStripMenuItem });
            transizioniToolStripMenuItem.Name = "transizioniToolStripMenuItem";
            transizioniToolStripMenuItem.Size = new Size(99, 25);
            transizioniToolStripMenuItem.Text = "Movimenti";
            // 
            // prelieviToolStripMenuItem
            // 
            prelieviToolStripMenuItem.Name = "prelieviToolStripMenuItem";
            prelieviToolStripMenuItem.Size = new Size(224, 26);
            prelieviToolStripMenuItem.Text = "Prelievi";
            prelieviToolStripMenuItem.Click += prelieviToolStripMenuItem_Click;
            // 
            // inviaDenaroToolStripMenuItem
            // 
            inviaDenaroToolStripMenuItem.Name = "inviaDenaroToolStripMenuItem";
            inviaDenaroToolStripMenuItem.Size = new Size(224, 26);
            inviaDenaroToolStripMenuItem.Text = "Invia denaro";
            inviaDenaroToolStripMenuItem.Click += inviaDenaroToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 153);
            label4.Name = "label4";
            label4.Size = new Size(200, 21);
            label4.TabIndex = 9;
            label4.Text = "Credito che vuoi depositare";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Location = new Point(363, 153);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 29);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // aggiungiCreditoBtn
            // 
            aggiungiCreditoBtn.Location = new Point(606, 153);
            aggiungiCreditoBtn.Name = "aggiungiCreditoBtn";
            aggiungiCreditoBtn.Size = new Size(94, 29);
            aggiungiCreditoBtn.TabIndex = 11;
            aggiungiCreditoBtn.Text = "Aggiungi";
            aggiungiCreditoBtn.UseVisualStyleBackColor = true;
            aggiungiCreditoBtn.Click += aggiungiCreditoBtn_Click;
            // 
            // creditoTxt
            // 
            creditoTxt.Location = new Point(247, 245);
            creditoTxt.Name = "creditoTxt";
            creditoTxt.Size = new Size(281, 29);
            creditoTxt.TabIndex = 12;
            // 
            // altroToolStripMenuItem
            // 
            altroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            altroToolStripMenuItem.Name = "altroToolStripMenuItem";
            altroToolStripMenuItem.Size = new Size(58, 25);
            altroToolStripMenuItem.Text = "Altro";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(creditoTxt);
            Controls.Add(aggiungiCreditoBtn);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem impostaInformazioniToolStripMenuItem;
        private ToolStripMenuItem transizioniToolStripMenuItem;
        private ToolStripMenuItem prelieviToolStripMenuItem;
        private ToolStripMenuItem inviaDenaroToolStripMenuItem;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button aggiungiCreditoBtn;
        private TextBox creditoTxt;
        private ToolStripMenuItem altroToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}
namespace FragrantWorld
{
    partial class SignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            FWSign_tableLayoutPanel = new TableLayoutPanel();
            backButton = new Button();
            sign_LoginLbl = new Label();
            sign_LoginTextBox = new TextBox();
            sign_PasswordLbl = new Label();
            sign_PasswordTextBox = new TextBox();
            sign_ForgotLinkLbl = new LinkLabel();
            signButton = new Button();
            FWSign_tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FWSign_tableLayoutPanel
            // 
            FWSign_tableLayoutPanel.BackColor = Color.White;
            FWSign_tableLayoutPanel.ColumnCount = 3;
            FWSign_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.66F));
            FWSign_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            FWSign_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            FWSign_tableLayoutPanel.Controls.Add(backButton, 0, 0);
            FWSign_tableLayoutPanel.Controls.Add(sign_LoginLbl, 1, 1);
            FWSign_tableLayoutPanel.Controls.Add(sign_LoginTextBox, 1, 2);
            FWSign_tableLayoutPanel.Controls.Add(sign_PasswordLbl, 1, 3);
            FWSign_tableLayoutPanel.Controls.Add(sign_PasswordTextBox, 1, 4);
            FWSign_tableLayoutPanel.Controls.Add(sign_ForgotLinkLbl, 1, 5);
            FWSign_tableLayoutPanel.Controls.Add(signButton, 1, 6);
            FWSign_tableLayoutPanel.Dock = DockStyle.Fill;
            FWSign_tableLayoutPanel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FWSign_tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            FWSign_tableLayoutPanel.Location = new Point(0, 0);
            FWSign_tableLayoutPanel.Name = "FWSign_tableLayoutPanel";
            FWSign_tableLayoutPanel.RowCount = 8;
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            FWSign_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            FWSign_tableLayoutPanel.Size = new Size(800, 450);
            FWSign_tableLayoutPanel.TabIndex = 0;
            FWSign_tableLayoutPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(204, 102, 0);
            backButton.Location = new Point(3, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 30);
            backButton.TabIndex = 1;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // sign_LoginLbl
            // 
            sign_LoginLbl.AutoSize = true;
            sign_LoginLbl.Location = new Point(320, 130);
            sign_LoginLbl.Name = "sign_LoginLbl";
            sign_LoginLbl.Size = new Size(58, 20);
            sign_LoginLbl.TabIndex = 0;
            sign_LoginLbl.Text = "Логин:";
            // 
            // sign_LoginTextBox
            // 
            sign_LoginTextBox.BackColor = Color.FromArgb(204, 102, 0);
            sign_LoginTextBox.Location = new Point(320, 163);
            sign_LoginTextBox.MaxLength = 32;
            sign_LoginTextBox.Name = "sign_LoginTextBox";
            sign_LoginTextBox.Size = new Size(196, 28);
            sign_LoginTextBox.TabIndex = 1;
            // 
            // sign_PasswordLbl
            // 
            sign_PasswordLbl.AutoSize = true;
            sign_PasswordLbl.Location = new Point(320, 190);
            sign_PasswordLbl.Name = "sign_PasswordLbl";
            sign_PasswordLbl.Size = new Size(69, 20);
            sign_PasswordLbl.TabIndex = 2;
            sign_PasswordLbl.Text = "Пароль:";
            // 
            // sign_PasswordTextBox
            // 
            sign_PasswordTextBox.BackColor = Color.FromArgb(204, 102, 0);
            sign_PasswordTextBox.Location = new Point(320, 223);
            sign_PasswordTextBox.Name = "sign_PasswordTextBox";
            sign_PasswordTextBox.Size = new Size(196, 28);
            sign_PasswordTextBox.TabIndex = 3;
            // 
            // sign_ForgotLinkLbl
            // 
            sign_ForgotLinkLbl.ActiveLinkColor = Color.RosyBrown;
            sign_ForgotLinkLbl.AutoSize = true;
            sign_ForgotLinkLbl.BackColor = Color.White;
            sign_ForgotLinkLbl.DisabledLinkColor = Color.White;
            sign_ForgotLinkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            sign_ForgotLinkLbl.LinkColor = Color.FromArgb(204, 102, 0);
            sign_ForgotLinkLbl.Location = new Point(320, 250);
            sign_ForgotLinkLbl.Name = "sign_ForgotLinkLbl";
            sign_ForgotLinkLbl.Size = new Size(130, 20);
            sign_ForgotLinkLbl.TabIndex = 4;
            sign_ForgotLinkLbl.TabStop = true;
            sign_ForgotLinkLbl.Text = "Забыли пароль?";
            // 
            // signButton
            // 
            signButton.BackColor = Color.FromArgb(204, 102, 0);
            signButton.Location = new Point(320, 283);
            signButton.Name = "signButton";
            signButton.Size = new Size(196, 33);
            signButton.TabIndex = 5;
            signButton.Text = "Войти";
            signButton.UseVisualStyleBackColor = false;
            signButton.Click += signButton_Click;
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FWSign_tableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign";
            FormClosing += SignForm_FormClosing;
            FWSign_tableLayoutPanel.ResumeLayout(false);
            FWSign_tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FWSign_tableLayoutPanel;
        private Label sign_LoginLbl;
        private TextBox sign_LoginTextBox;
        private TextBox sign_PasswordTextBox;
        private Label sign_PasswordLbl;
        private LinkLabel sign_ForgotLinkLbl;
        private Button signButton;

        private Button backButton;
    }
}
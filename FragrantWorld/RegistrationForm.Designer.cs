namespace FragrantWorld
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            FWR_tableLayoutPanel = new TableLayoutPanel();
            backButton = new Button();
            registrationButton = new Button();
            reg_RePasswordTextBox = new TextBox();
            registrationRePassword = new Label();
            reg_PasswordTextBox = new TextBox();
            registrationPassword = new Label();
            reg_LoginTextBox = new TextBox();
            registrationLogin = new Label();
            reg_PatronymicTextBox = new TextBox();
            registrationPatronymic = new Label();
            reg_SurnameTextBox = new TextBox();
            registrationSurname = new Label();
            reg_NameTextBox = new TextBox();
            registrationName = new Label();
            FWR_tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FWR_tableLayoutPanel
            // 
            FWR_tableLayoutPanel.ColumnCount = 4;
            FWR_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            FWR_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.5F));
            FWR_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.4999962F));
            FWR_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            FWR_tableLayoutPanel.Controls.Add(backButton, 0, 0);
            FWR_tableLayoutPanel.Controls.Add(registrationButton, 2, 13);
            FWR_tableLayoutPanel.Controls.Add(reg_RePasswordTextBox, 2, 12);
            FWR_tableLayoutPanel.Controls.Add(registrationRePassword, 2, 11);
            FWR_tableLayoutPanel.Controls.Add(reg_PasswordTextBox, 2, 10);
            FWR_tableLayoutPanel.Controls.Add(registrationPassword, 2, 9);
            FWR_tableLayoutPanel.Controls.Add(reg_LoginTextBox, 2, 8);
            FWR_tableLayoutPanel.Controls.Add(registrationLogin, 2, 7);
            FWR_tableLayoutPanel.Controls.Add(reg_PatronymicTextBox, 2, 6);
            FWR_tableLayoutPanel.Controls.Add(registrationPatronymic, 2, 5);
            FWR_tableLayoutPanel.Controls.Add(reg_SurnameTextBox, 2, 4);
            FWR_tableLayoutPanel.Controls.Add(registrationSurname, 2, 3);
            FWR_tableLayoutPanel.Controls.Add(reg_NameTextBox, 2, 2);
            FWR_tableLayoutPanel.Controls.Add(registrationName, 2, 1);
            FWR_tableLayoutPanel.Dock = DockStyle.Fill;
            FWR_tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            FWR_tableLayoutPanel.Location = new Point(0, 0);
            FWR_tableLayoutPanel.Name = "FWR_tableLayoutPanel";
            FWR_tableLayoutPanel.RowCount = 14;
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            FWR_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            FWR_tableLayoutPanel.Size = new Size(824, 463);
            FWR_tableLayoutPanel.TabIndex = 80;
            FWR_tableLayoutPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // backButton
            // 
            backButton.Dock = DockStyle.Top;
            backButton.Location = new Point(3, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(84, 36);
            backButton.TabIndex = 80;
            backButton.Text = "Назад";
            backButton.Click += backButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.DarkOrange;
            registrationButton.Location = new Point(392, 415);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(197, 34);
            registrationButton.TabIndex = 69;
            registrationButton.Text = "Зарегистрироваться";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // reg_RePasswordTextBox
            // 
            reg_RePasswordTextBox.BackColor = SystemColors.Control;
            reg_RePasswordTextBox.Location = new Point(392, 383);
            reg_RePasswordTextBox.MaxLength = 28;
            reg_RePasswordTextBox.Name = "reg_RePasswordTextBox";
            reg_RePasswordTextBox.Size = new Size(196, 28);
            reg_RePasswordTextBox.TabIndex = 68;
            reg_RePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // registrationRePassword
            // 
            registrationRePassword.AutoSize = true;
            registrationRePassword.Font = new Font("Comic Sans MS", 9F);
            registrationRePassword.Location = new Point(392, 350);
            registrationRePassword.Name = "registrationRePassword";
            registrationRePassword.Size = new Size(149, 20);
            registrationRePassword.TabIndex = 70;
            registrationRePassword.Text = "Повторите пароль:";
            registrationRePassword.Click += registrationRePassword_Click;
            // 
            // reg_PasswordTextBox
            // 
            reg_PasswordTextBox.BackColor = SystemColors.Control;
            reg_PasswordTextBox.Location = new Point(392, 321);
            reg_PasswordTextBox.MaxLength = 28;
            reg_PasswordTextBox.Name = "reg_PasswordTextBox";
            reg_PasswordTextBox.PasswordChar = '*';
            reg_PasswordTextBox.Size = new Size(196, 28);
            reg_PasswordTextBox.TabIndex = 67;
            reg_PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // registrationPassword
            // 
            registrationPassword.AutoSize = true;
            registrationPassword.Font = new Font("Comic Sans MS", 9F);
            registrationPassword.Location = new Point(392, 288);
            registrationPassword.Name = "registrationPassword";
            registrationPassword.Size = new Size(65, 20);
            registrationPassword.TabIndex = 72;
            registrationPassword.Text = "Пароль";
            // 
            // reg_LoginTextBox
            // 
            reg_LoginTextBox.BackColor = SystemColors.Control;
            reg_LoginTextBox.Location = new Point(392, 259);
            reg_LoginTextBox.MaxLength = 32;
            reg_LoginTextBox.Name = "reg_LoginTextBox";
            reg_LoginTextBox.Size = new Size(196, 28);
            reg_LoginTextBox.TabIndex = 79;
            // 
            // registrationLogin
            // 
            registrationLogin.AutoSize = true;
            registrationLogin.Font = new Font("Comic Sans MS", 9F);
            registrationLogin.Location = new Point(392, 226);
            registrationLogin.Name = "registrationLogin";
            registrationLogin.Size = new Size(54, 20);
            registrationLogin.TabIndex = 78;
            registrationLogin.Text = "Логин";
            // 
            // reg_PatronymicTextBox
            // 
            reg_PatronymicTextBox.BackColor = SystemColors.Control;
            reg_PatronymicTextBox.Location = new Point(392, 197);
            reg_PatronymicTextBox.MaxLength = 32;
            reg_PatronymicTextBox.Name = "reg_PatronymicTextBox";
            reg_PatronymicTextBox.Size = new Size(196, 28);
            reg_PatronymicTextBox.TabIndex = 77;
            // 
            // registrationPatronymic
            // 
            registrationPatronymic.AutoSize = true;
            registrationPatronymic.Font = new Font("Comic Sans MS", 9F);
            registrationPatronymic.Location = new Point(392, 164);
            registrationPatronymic.Name = "registrationPatronymic";
            registrationPatronymic.Size = new Size(162, 20);
            registrationPatronymic.TabIndex = 75;
            registrationPatronymic.Text = "Отчество (если есть)";
            // 
            // reg_SurnameTextBox
            // 
            reg_SurnameTextBox.BackColor = SystemColors.Control;
            reg_SurnameTextBox.Location = new Point(392, 135);
            reg_SurnameTextBox.MaxLength = 32;
            reg_SurnameTextBox.Name = "reg_SurnameTextBox";
            reg_SurnameTextBox.Size = new Size(196, 28);
            reg_SurnameTextBox.TabIndex = 76;
            // 
            // registrationSurname
            // 
            registrationSurname.AutoSize = true;
            registrationSurname.Font = new Font("Comic Sans MS", 9F);
            registrationSurname.Location = new Point(392, 102);
            registrationSurname.Name = "registrationSurname";
            registrationSurname.Size = new Size(76, 20);
            registrationSurname.TabIndex = 74;
            registrationSurname.Text = "Фамилия";
            // 
            // reg_NameTextBox
            // 
            reg_NameTextBox.BackColor = SystemColors.Control;
            reg_NameTextBox.Location = new Point(392, 73);
            reg_NameTextBox.MaxLength = 32;
            reg_NameTextBox.Name = "reg_NameTextBox";
            reg_NameTextBox.Size = new Size(196, 28);
            reg_NameTextBox.TabIndex = 71;
            // 
            // registrationName
            // 
            registrationName.AutoSize = true;
            registrationName.Font = new Font("Comic Sans MS", 9F);
            registrationName.Location = new Point(392, 42);
            registrationName.Name = "registrationName";
            registrationName.Size = new Size(39, 20);
            registrationName.TabIndex = 73;
            registrationName.Text = "Имя";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(824, 463);
            Controls.Add(FWR_tableLayoutPanel);
            Font = new Font("Comic Sans MS", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(842, 510);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += RegistrationForm_Load;
            Resize += RegistrationForm_Resize;
            FWR_tableLayoutPanel.ResumeLayout(false);
            FWR_tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label registrationName;
        private Label registrationSurname;
        private Label registrationPatronymic;
        private TextBox reg_LoginTextBox;
        private Label registrationLogin;
        private TextBox reg_PatronymicTextBox;
        private TextBox reg_SurnameTextBox;
        private Label registrationPassword;
        private TextBox reg_NameTextBox;
        private Label registrationRePassword;
        private TextBox reg_RePasswordTextBox;
        private TextBox reg_PasswordTextBox;
        private Button registrationButton;
        private TableLayoutPanel FWR_tableLayoutPanel;
        private Button backButton;
    }
}
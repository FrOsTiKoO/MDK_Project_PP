namespace FragrantWorld
{
    partial class FW_Autorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FW_Autorization));
            Sign = new Button();
            Registration = new Button();
            SignInGuest = new LinkLabel();
            SuspendLayout();
            // 
            // Sign
            // 
            Sign.BackColor = Color.DarkOrange;
            Sign.FlatAppearance.BorderColor = Color.Orchid;
            Sign.Font = new Font("Comic Sans MS", 9F);
            Sign.Location = new Point(50, 86);
            Sign.Name = "Sign";
            Sign.Size = new Size(200, 29);
            Sign.TabIndex = 0;
            Sign.Text = "Вход";
            Sign.UseVisualStyleBackColor = false;
            Sign.Click += Sign_Click;
            // 
            // Registration
            // 
            Registration.BackColor = Color.DarkOrange;
            Registration.FlatAppearance.BorderColor = Color.Orchid;
            Registration.Font = new Font("Comic Sans MS", 9F);
            Registration.Location = new Point(50, 116);
            Registration.Name = "Registration";
            Registration.Size = new Size(200, 29);
            Registration.TabIndex = 1;
            Registration.Text = "Регистрация";
            Registration.UseVisualStyleBackColor = false;
            Registration.Click += Registration_Click;
            // 
            // SignInGuest
            // 
            SignInGuest.ActiveLinkColor = Color.Silver;
            SignInGuest.AutoSize = true;
            SignInGuest.BackColor = Color.White;
            SignInGuest.DisabledLinkColor = Color.White;
            SignInGuest.Font = new Font("Comic Sans MS", 9F);
            SignInGuest.LinkBehavior = LinkBehavior.NeverUnderline;
            SignInGuest.LinkColor = Color.DarkOrange;
            SignInGuest.Location = new Point(43, 176);
            SignInGuest.Name = "SignInGuest";
            SignInGuest.Size = new Size(223, 20);
            SignInGuest.TabIndex = 2;
            SignInGuest.TabStop = true;
            SignInGuest.Text = "Продолжить в качестве гостя";
            SignInGuest.VisitedLinkColor = Color.Gray;
            SignInGuest.LinkClicked += SignInGuest_LinkClicked;
            // 
            // FW_Autorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(282, 253);
            Controls.Add(SignInGuest);
            Controls.Add(Registration);
            Controls.Add(Sign);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "FW_Autorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аутентификация";
            Load += FW_Autorization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sign;
        private Button Registration;
        private LinkLabel SignInGuest;
    }
}

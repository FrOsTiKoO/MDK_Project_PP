using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FragrantWorld
{
    public partial class RegistrationForm : Form
    {
        // Словарь для хранения исходных размеров элементов управления
        private Dictionary<Control, Size> originalControlSizes = new Dictionary<Control, Size>();
        private Dictionary<Control, Font> originalControlFont = new Dictionary<Control, Font>();

        private Size originalFormSize;
        private Font originalFormFont;

        public RegistrationForm()
        {
            InitializeComponent();

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            backButton.Dock = DockStyle.Top | DockStyle.Left;
            foreach (Control control in FWR_tableLayoutPanel.Controls)
            {
                if (control != backButton) // Исключаем backButton
                {
                    originalControlSizes[control] = control.Size;
                    originalControlFont[control] = control.Font;
                }
            }
        }

        private void RegistrationForm_Resize(object sender, EventArgs e)
        {
            if (this.Width > originalFormSize.Width + 50 && this.Height > originalFormSize.Height + 300)
            {
                // Увеличиваем размеры всех элементов управления на 7.5% от ширины и высоты окна
                foreach (Control control in FWR_tableLayoutPanel.Controls)
                {
                    if (originalControlSizes.ContainsKey(control))
                    {
                        int newWidth = (int)(originalControlSizes[control].Width + (this.Width * 0.075));
                        int newHeight = (int)(originalControlSizes[control].Height + (this.Width * 0.035));
                        float newFontSize = originalControlFont[control].Size + (originalControlFont[control].Size * 0.67f);

                        control.Font = new Font(originalControlFont[control].FontFamily, newFontSize, originalControlFont[control].Style);
                        control.Size = new Size(newWidth, newHeight);

                    }
                }
            }
            else
            {
                // Возвращаем всем элементам управления исходные размеры
                foreach (Control control in FWR_tableLayoutPanel.Controls)
                {
                    if (originalControlSizes.ContainsKey(control))
                    {
                        control.Size = originalControlSizes[control];
                        control.Font = originalControlFont[control];

                    }
                }
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string name = reg_NameTextBox.Text;
            string surname = reg_SurnameTextBox.Text;
            string patronymic = reg_PatronymicTextBox.Text;
            string login = reg_LoginTextBox.Text;
            string password = reg_PasswordTextBox.Text;
            string rePassword = reg_RePasswordTextBox.Text;

            bool isValid = true; // добавляем переменную для проверки на правильность ввода пользователем данных

            if (!Regex.IsMatch(name, @"^[А-ЯЁA-Z][а-яёa-zA-Z]{1, 32}$"))
            {
                MessageBox.Show("Неверное имя. Должно начинаться с заглавной буквы и содержать только русские или только английские буквы.");
                isValid = false;
            }

            if (!Regex.IsMatch(surname, @"^[А-ЯЁA-Z][а-яёa-zA-Z]{1, 32}$"))
            {
                MessageBox.Show("Неверная фамилия. Должно начинаться с заглавной буквы и содержать только русские или английские буквы.");
                isValid = false;
            }

            if (!Regex.IsMatch(patronymic, @"^[А-ЯЁA-Z]?[а-яёa-zA-Z\-]{0, 32}$"))
            {
                MessageBox.Show("Неверное отчество. Должно начинаться с заглавной буквы и содержать только русские или английские буквы.");
                isValid = false;
            }

            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]{1, 32}+$"))
            {
                MessageBox.Show("Неверный логин. Должен содержать только английские буквы и цифры.");
                isValid = false;
            }

            if (password == rePassword)
            {
                if (!Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[!#&])(?=.*\d)[A-Za-z\d!#&]{6, 28}$"))
                {
                    MessageBox.Show("Неверный пароль. Должен содержать минимум 8 символов, включая хотя бы одну заглавную букву, один спецсимвол (!, #, &) и одну цифру.");
                    isValid = false;
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Регистрация прошла успешно.");
            }
        }

        private void registrationRePassword_Click(object sender, EventArgs e)
        {
            // Этот метод можно оставить пустым, если он не используется
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Этот метод можно оставить пустым, если он не используется
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FW_Autorization auth = new();
            auth.Show();
            this.Hide();
        }
    }
}
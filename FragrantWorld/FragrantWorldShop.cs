using FragrantWorld.DatabaseContext;
using FragrantWorld.Mode1s;
using Microsoft.EntityFrameworkCore;

namespace FragrantWorld
{
    public partial class FragrantWorldShop : Form
    {
        private string userRole;
        private int? userId;

        public FragrantWorldShop(string role, int? id)
        {
            InitializeComponent();
            userRole = role;
            userId = id;

            // Настройка формы
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += FragrantWorldShop_Load;
            this.FormClosing += FragrantWorldShop_FormClosing;

            // Подключаем событие CellFormatting
            dataGridViewProducts.CellFormatting += dataGridViewProducts_CellFormatting;
        }

        private void FragrantWorldShop_Load(object sender, EventArgs e)
        {
            // Загрузка товаров
            LoadProducts();

            // Настройка MenuStrip
            if (userRole != "Guest")
            {
                DisplayUserName(userId);
                if (userRole == "Клиент")
                {
                    panel_Control.Visible = false;
                }
            }
            else if (userRole == "Guest")
            {
                panel_Control.Visible = false;
                account.Text = userRole;
            }
            else
            {
                panel_Control.Visible = true;
            }
        }

        private void FragrantWorldShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите покинуть приложение?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public User GetUserById(int? userId)
        {
            using (var context = new AppDbContext())
            {
                return context.Users.FirstOrDefault(u => u.UserId == userId);
            }
        }

        private void DisplayUserName(int? userId)
        {
            // Получаем пользователя по UserId
            var user = GetUserById(userId);

            if (user != null)
            {
                // Форматируем ФИО
                string formattedName = FormatFullName(user.LastName, user.FirstName, user.Patronymic);

                // Отображаем имя в интерфейсе (например, в Label или MenuStrip)
                account.Text = formattedName;
            }
            else
            {
                // Если пользователь не найден, отображаем сообщение
                MessageBox.Show("Пользователь неизвестен");
            }
        }

        private string FormatFullName(string lastName, string firstName, string patronymic)
        {
            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
            {
                return "Неизвестно";
            }

            string formattedFirstName = string.IsNullOrEmpty(firstName) ? "" : $"{firstName[0]}.";
            string formattedPatronymic = string.IsNullOrEmpty(patronymic) ? "" : $"{patronymic[0]}.";

            return $"{lastName} {formattedFirstName} {formattedPatronymic}".Trim();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            // Скрываем текущую форму
            this.Hide();

            // Очищаем данные сессии (например, UserId, UserRole)
            userId = null; // Устанавливаем значение по умолчанию
            userRole = string.Empty;

            SignForm sign = new();
            sign.Show();
        }

        private void panel_Control_Click(object sender, EventArgs e)
        {
            if (userRole == "Администратор" || userRole == "Менеджер")
            {
                PanelControl panel = new();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Доступ запрещен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            // Подключение к базе данных и получение данных
            using (var context = new AppDbContext())
            {
                var products = context.Products.ToList();

                // Очищаем DataGridView
                dataGridViewProducts.Rows.Clear();
                dataGridViewProducts.Margin = new(5);

                // Добавляем товары в DataGridView
                foreach (var product in products)
                {
                    int rowIndex = dataGridViewProducts.Rows.Add();
                    var row = dataGridViewProducts.Rows[rowIndex];

                    // Добавляем данные в строку
                    row.Cells["ProductName"].Value = product.ProductName;
                    row.Cells["ProductDescription"].Value = product.ProductDescription;
                    row.Cells["ProductCost"].Value = product.ProductCost.ToString("C");
                }
            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что была нажата кнопка "Заказать"
            if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "OrderButton")
            {
                var productName = dataGridViewProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                MessageBox.Show($"Товар '{productName}' добавлен в заказ.");
            }
        }

        private void dataGridViewProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Проверяем, что текущая ячейка является кнопкой
            if (dataGridViewProducts.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridViewProducts.Columns[e.ColumnIndex].Name == "OrderButton")
            {
                // Устанавливаем цвет фона кнопки
                e.CellStyle.BackColor = Color.White;
                // Устанавливаем цвет текста кнопки
                e.CellStyle.ForeColor = Color.FromArgb(204, 102, 0); 
                // Устанавливаем шрифт текста кнопки
                e.CellStyle.Font = new Font("Comic Sans MS", 9);
            }
        }
    }
}
using FragrantWorld.DatabaseContext;
using FragrantWorld.Interface;
using FragrantWorld.Services;
using Microsoft.EntityFrameworkCore;

namespace FragrantWorld
{
    public partial class SignForm : Form
    {

        public SignForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FW_Autorization auth = new();
            auth.Show();
            this.Hide();
        }

        private void SignForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void signButton_Click(object sender, EventArgs e)
        {
            var login = sign_LoginTextBox.Text;
            var password = sign_PasswordTextBox.Text;

            using (var context = new AppDbContext())
            {
                var user = context.Users
                    .Include(u => u.UserRoleNavigation) // Подключаем связанную роль пользователя
                    .FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    FragrantWorldShop shop = new FragrantWorldShop(user.UserRoleNavigation.RoleName, user.UserId);
                    shop.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Неправильно введены данные, проверьте правильность введенных данных");
                }

            }
        }

    }
}

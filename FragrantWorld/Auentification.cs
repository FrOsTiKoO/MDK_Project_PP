using FragrantWorld.Interface;
using FragrantWorld.Services;

namespace FragrantWorld
{
    
    public partial class FW_Autorization : Form
    {
 
        private string userRole;
        public FW_Autorization()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            SignForm sign = new();
            sign.Show();
            this.Hide();

        }

        private void FW_Autorization_Load(object sender, EventArgs e)
        {
            Sign.BackColor = Color.FromArgb(204, 102, 0);
            Registration.BackColor = Color.FromArgb(204, 102, 0);
            SignInGuest.LinkColor = Color.FromArgb(204, 102, 0);
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new();
            registration.Show();
            this.Hide();
        }

        private void SignInGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FragrantWorldShop shop = new FragrantWorldShop("Guest", null);
            shop.Show();
            this.Hide();

        }
    }
}

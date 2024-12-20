using FragrantWorld.Interface;
using FragrantWorld.Mode1s;

namespace FragrantWorld
{
    public partial class PanelControl : Form
    {
        private readonly IOrderService _orderService;
        public PanelControl()
        {
            InitializeComponent();
        }


        private void PanelControl_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            // Получаем список заказов из базы данных
            var orders = _orderService.GetAllOrders();

            // Очищаем FlowLayoutPanel
            flowLayoutPanel.Controls.Clear();

            // Добавляем каждый заказ в FlowLayoutPanel
            foreach (var order in orders)
            {
                AddOrderToPanel(order);
            }
        }

        private void AddOrderToPanel(Order order)
        {
            // Добавляем данные заказа в FlowLayoutPanel
            AddLabel($"Заказ №{order.OrderId}", flowLayoutPanel);
            AddLabel($"Дата заказа: {order.OrderDate:dd.MM.yyyy}", flowLayoutPanel);
            AddTextBox($"Дата доставки: ", order.DeliveryDate.ToString("dd.MM.yyyy"), flowLayoutPanel);
            AddComboBox($"Статус заказа: ", new[] { "Новый", "Доставлен" }, order.OrderStatus.ToString(), flowLayoutPanel);

            if (order.Client != null)
            {
                AddLabel($"Клиент: {order.Client.LastName} {order.Client.FirstName} {order.Client.Patronymic}", flowLayoutPanel);
            }
            else
            {
                AddLabel("Клиент: Гость", flowLayoutPanel);
            }

            // Добавляем кнопку "Сохранить" для каждого заказа
            Button saveButton = new Button
            {
                Text = "Сохранить",
                Width = 100,
                Height = 30
            };
            saveButton.Click += (s, e) => SaveOrderChanges(order);
            flowLayoutPanel.Controls.Add(saveButton);

            // Добавляем разделитель между заказами
            flowLayoutPanel.Controls.Add(new Panel { Height = 20 });
        }

        private void AddLabel(string text, Control container)
        {
            Label label = new Label
            {
                Text = text,
                AutoSize = true
            };
            container.Controls.Add(label);
        }

        private void AddTextBox(string labelText, string value, Control container)
        {
            Label label = new Label
            {
                Text = labelText,
                AutoSize = true
            };
            TextBox textBox = new TextBox
            {
                Text = value,
                Width = 200
            };
            container.Controls.Add(label);
            container.Controls.Add(textBox);
        }

        private void AddComboBox(string labelText, string[] items, string selectedItem, Control container)
        {
            Label label = new Label
            {
                Text = labelText,
                AutoSize = true
            };
            ComboBox comboBox = new ComboBox
            {
                Width = 200
            };
            comboBox.Items.AddRange(items);
            comboBox.SelectedItem = selectedItem;
            container.Controls.Add(label);
            container.Controls.Add(comboBox);
        }

        private void SaveOrderChanges(Order order)
        {
            // Находим элементы управления для редактирования заказа
            var deliveryDateTextBox = (TextBox)flowLayoutPanel.Controls[flowLayoutPanel.Controls.Count - 3];
            var statusComboBox = (ComboBox)flowLayoutPanel.Controls[flowLayoutPanel.Controls.Count - 2];

            // Обновляем данные заказа
            order.DeliveryDate = DateTime.Parse(deliveryDateTextBox.Text);
            order.OrderStatus = Convert.ToInt32(statusComboBox.SelectedItem);

            // Сохраняем изменения в базе данных
            _orderService.UpdateOrder(order);

            // Сообщаем об успешном сохранении
            MessageBox.Show("Данные заказа успешно обновлены.");
        }
    }
}

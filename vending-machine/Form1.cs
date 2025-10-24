namespace vending_machine
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prodContainer_Click(object sender, EventArgs e)
        {

        }

        private void burgerBtn_Click(object sender, EventArgs e)
        {
            AddItem("Burger", "2.00");
        }
        private void AddItem(string prodName, string cost)
        {
            count++;
            Panel listPanel = new Panel
            {
                Name = "product" + count,
                Size = new Size(250, 40),
                BorderStyle = BorderStyle.FixedSingle,
            };
            Label listLabelName = new Label
            {
                Text = prodName,
                Location = new Point(10, 10),
                AutoSize = true,
                ForeColor = Color.White,
            };
            Label listLabelPrice = new Label
            {
                Text = cost,
                Location = new Point(100, 10),
                AutoSize = true,
                ForeColor = Color.White,
            };
            Button DeleteListItem = new Button
            {
                Text = "X",
                BackColor = Color.White,
                ForeColor = Color.Black,
                Size = new Size(25, 25),
                Location = new Point(150, 7)
            };
            DeleteListItem.Click += (s, e) =>
            {
                basketContainer.Controls.Remove(listPanel);
                listPanel.Dispose();
            };
            listPanel.Controls.Add(listLabelName);
            listPanel.Controls.Add(listLabelPrice);
            listPanel.Controls.Add(DeleteListItem);

            basketContainer.Controls.Add(listPanel);
        }

        private void pizzaBtn_Click(object sender, EventArgs e)
        {
            AddItem("Pizza", "3.00");
        }
    }
}

using CarClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        BindingSource carListBinding = new BindingSource();
        BindingSource cartListBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }

        private void SetBindings()
        {
            carListBinding.DataSource = store.CarList;
            inventoryListBox.DataSource = carListBinding;
            inventoryListBox.DisplayMember = "toString";

            cartListBinding.DataSource = store.ShoppingList;
            cartListBox.DataSource = cartListBinding;
            cartListBox.DisplayMember = "toString";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Car newCar = new Car();
            newCar.Make = makeTextBox.Text;
            newCar.Model = modelTextBox.Text;
            newCar.Price = Decimal.Parse(priceTextBox.Text);

            store.CarList.Add(newCar);
            carListBinding.ResetBindings(false);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)inventoryListBox.SelectedItem);
            cartListBinding.ResetBindings(false);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();
            totalValueLabel.Text = total.ToString();
        }
    }
}
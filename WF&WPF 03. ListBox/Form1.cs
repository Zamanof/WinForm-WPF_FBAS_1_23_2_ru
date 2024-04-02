namespace WF_WPF_03._ListBox
{
    public partial class Form1 : Form
    {
        List<string> cars = new List<string>{
            "Mazda", "Audi", "BMW", "Mercedes"
        };
        public Form1()
        {
            InitializeComponent();
            myListBox.DataSource = cars;
            //foreach (string car in cars)
            //{
            //    myListBox.Items.Add(car);
            //}
            //myListBox.Items.AddRange(cars.ToArray());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //myListBox.Items.Add(addTextBox.Text);
            cars.Add(addTextBox.Text);
            updateListSource();
            addTextBox.Clear();
        }

        private void myListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myListBox.SelectedIndex == 0)
            {
                myListBox.BackColor = Color.Red;
            }
            else if (myListBox.SelectedIndex == 1)
            {
                myListBox.BackColor = Color.Green;
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            //var selected = myListBox.SelectedItem;
            //MessageBox.Show(selected.ToString());

            var selectedElements = myListBox.SelectedItems;
            foreach (var element in selectedElements)
            {
                MessageBox.Show(element.ToString());
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Delete item without data source
            //myListBox.Items.Remove(myListBox.SelectedItem);
            cars.RemoveAt(myListBox.SelectedIndex);
            updateListSource();
        }
        private void updateListSource()
        {
            myListBox.DataSource = null;
            myListBox.DataSource = cars;
        }
    }
}
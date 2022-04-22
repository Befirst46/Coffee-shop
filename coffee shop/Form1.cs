namespace coffee_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namecombo.SelectedItem.ToString() == "Espresso")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 60).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 50).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Cappuccino")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 60).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 50).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Latee")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 60).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 50).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Mocca")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 60).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 50).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Americano")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 60).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 50).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Black Coffee")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 60).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 50).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Coffee")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 65).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 55).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Caramel")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 65).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 55).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Mocha")
            {
                if (typecombo.SelectedItem.ToString() == "Feappe")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 65).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 55).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
        }

        private void idtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecombo.Text = "";
            typecombo.Text = "";
            quanitycombo.Text = "";
            paytext.Text = "";            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
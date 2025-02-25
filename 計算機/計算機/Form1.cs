namespace 計算機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox3.Text = textBox1.Text + textBox2.Text;


            double num=0;
            if (label1.Text=="+") { num = double.Parse(textBox1.Text) + double.Parse(textBox2.Text); }
            if (label1.Text == "-") { num = double.Parse(textBox1.Text) - double.Parse(textBox2.Text); }
            if (label1.Text == "*") { num = double.Parse(textBox1.Text) * double.Parse(textBox2.Text); }
            if (label1.Text == "/") { num = double.Parse(textBox1.Text) / double.Parse(textBox2.Text); }
            //num = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            //num = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            //num = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            //num = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            textBox3.Text = num.ToString();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
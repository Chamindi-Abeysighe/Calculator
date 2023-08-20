namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string calTotal;
        int num1;
        int num2;
        string Option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button10.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Option = "+";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Option = "-";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Option = "*";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Option = "/";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(Display.Text);
            if (Option == "+")
            {
                result = num1 + num2;
            }
            if (Option == "-")
            {
                result = num1 - num2;
            }
            if (Option == "*")
            {
                result = num1 * num2;

            }
            if (Option == "/")
            {
                result = num1 / num2;
            }
            Display.Text = result + "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Display.Clear();
            
        }

    }
}
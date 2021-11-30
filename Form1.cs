namespace basic_calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double firstnum,secondnum;  
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);

            }
            else
            {
                txtDisplay.Text = "-" +txtDisplay.Text;
            }

        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;  
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if (b.Text ==".")
            {
                if(!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }

            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;

            s = Convert.ToString(secondnum);
            f = Convert.ToString(firstnum);

            s = "";
            f = "";
        }

        private void operational_function(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            { txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            secondnum  = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstnum + secondnum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(firstnum / secondnum);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
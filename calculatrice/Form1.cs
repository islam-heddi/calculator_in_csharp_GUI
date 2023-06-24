using System.Drawing.Printing;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number_clicked;
        int number_output;
        int previous_number;
        int result;
        bool onClick_equality;
        bool set_previous;
        char op = '=';

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            number_clicked = 1;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            number_clicked = 2;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            number_clicked = 3;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            number_clicked = 4;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            number_clicked = 5;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            number_clicked = 6;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            number_clicked = 7;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            number_clicked = 8;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            number_clicked = 9;
            number_output = number_output * 10 + number_clicked;
            num.Text = number_output.ToString();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            number_clicked = 0;
            number_output = number_output * 10;
            num.Text = number_output.ToString();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            number_output /= 10;
            num.Text = number_output.ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            number_output = 0;
            previous_number = 0;
            op = '=';
            num.Text = number_output.ToString();
            onClick_equality = false;
            set_previous = false;
        }

        private void sum_Click(object sender, EventArgs e)
        {
            op = '+';
            if (previous_number == 0)
            {
                previous_number = number_output;
                number_output = 0;
                num.Text = number_output.ToString();
            }
            else if (onClick_equality)
            {
                previous_number = result;
                number_output = 0;
                num.Text = number_output.ToString();
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':
                    result = previous_number + number_output;
                    num.Text = result.ToString();
                    break;
                case '-':
                    result = previous_number - number_output;
                    num.Text = result.ToString();
                    break;
                case '*':
                    result = previous_number * number_output;
                    num.Text = result.ToString();
                    break;
                case '/':
                    if (number_output == 0)
                    {
                        num.Text = "Impossible";
                    }
                    else
                    {
                        result = previous_number / number_output;
                        num.Text = result.ToString();
                    }
                    break;
            }
            op = '=';
            onClick_equality = true;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            op = '-';
            if (previous_number == 0)
            {
                previous_number = number_output;
                number_output = 0;
                num.Text = number_output.ToString();
            }

            if (onClick_equality)
            {
                previous_number = result;
                number_output = 0;
                num.Text = number_output.ToString();
            }
        }

        private void product_Click(object sender, EventArgs e)
        {
            op = '*';
            if (previous_number == 0)
            {
                previous_number = number_output;
                number_output = 0;
                num.Text = number_output.ToString();
            }

            if (onClick_equality)
            {
                previous_number = result;
                number_output = 0;
                num.Text = number_output.ToString();
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            op = '/';
            if (previous_number == 0)
            {
                previous_number = number_output;
                number_output = 0;
                num.Text = number_output.ToString();
            }

            if (onClick_equality)
            {
                previous_number = result;
                number_output = 0;
                num.Text = number_output.ToString();
            }
        }
    }
}
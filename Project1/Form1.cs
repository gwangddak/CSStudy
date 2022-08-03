namespace Project1
{
    public partial class Form1 : Form
    {

        private int savedNum = 0;   
        private int operate = 0; //1 : plus 2 : minus 3 : multi 4 :div
        private bool newInput = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            int finalNum = int.Parse(txtResult.Text);
            int result = 0;
            switch (operate)
            {
                case 1:
                    result = savedNum + finalNum;
                    break;
                case 2:
                    result = savedNum - finalNum;
                    break;
                case 3:
                    result = savedNum * finalNum;
                    break;
                case 4:
                    result = savedNum / finalNum;
                    break;
                default:
                    break;
            }
            txtResult.Text = result.ToString(); // 연산한 값 출력
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operate = int.Parse(btn.Tag.ToString());
            savedNum = int.Parse(txtResult.Text);
            newInput = true;

        }

        private void btnNum_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button; // 다형성
            string strNum = btn.Tag.ToString();
            if (newInput)
            {
                if (strNum !="0")
                {
                    txtResult.Text = strNum;
                    newInput = false;
                }
             
            }
            else
            {
                txtResult.Text += btn.Tag.ToString();
            }
            //Console.WriteLine("Tag : "+btn.Tag);
      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            newInput = true;
        }
    }
}
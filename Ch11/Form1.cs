namespace Ch11
{
    public partial class Form1 : Form // 이것은 폼창을 코드로 보는것이다. // 분할 클래스임 //하나 더있는데 그게 폼1디자이너 파일이다. // 폼창과 이것을 많이 건들것이다.
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기본 메세지 박스"); // 출력할때 사용하는 cw와 비슷한 기능
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지 박스" , "버튼 2 클릭");
          
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("두개의 버튼을 갖는 메시지 박스", "버튼 3 클릭",MessageBoxButtons.YesNo); // Bool과 같은 맥략
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("Yes 클릭!");
            }
            else
            {
                MessageBox.Show("No 클릭!");
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUid_Click(object sender, EventArgs e)
        {
           string uid = txtUid.Text; //set
           lbUid.Text = "결과 : " + uid; // set

        }

        private void btnname_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "결과 : " + name;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "결과 : " + hp;
            

        }

        private void btnchkFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chkFruits = { chkFruit1, chkFruit2, chkFruit3, chkFruit4, chkFruit5, };
            List<string> fruits = new List<string>();
            foreach (CheckBox chk in chkFruits)
            {
                if (chk.Checked == true)
                {
                    fruits.Add(chk.Text);
                }
            }
            lbFruitResult.Text = "결과 : " + String.Join(",", fruits);
        }

        private void btnChkColor_Click(object sender, EventArgs e)
        {
            CheckBox[] chkColors = {chkColor1, chkColor2, chkColor3, chkColor4, chkColor5 };
            List<string> colors = new List<string>();
            foreach (CheckBox chk in chkColors)
            {
                if (chk.Checked == true)
                {
                    colors.Add(chk.Text);
                }
                

            }
            lbColorResult.Text = "결과 : " + String.Join(",", colors);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}
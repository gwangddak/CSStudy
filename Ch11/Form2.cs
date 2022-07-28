using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{

    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //form2가 실행될때 
        private void Form2_Load(object sender, EventArgs e)
        {
            //콤보 바ㅓㄱ스 데이터 공급
            List<string> posData = new List<string> {"사원","대리","과장","차장","부장" };
            cbCity1.DataSource = posData;
            string[] citiData = { "서울", "대전", "대구", "부산", "광주" };
            cbCity2.DataSource = citiData;

            List<User> users = new List<User>();
            users.Add(new User("a101", "김유신", "010-1234-1001", 25));
            users.Add(new User("a102", "김춘추", "010-1234-1001", 23));
            users.Add(new User("a103", "장보고", "010-1234-1001", 35));
            users.Add(new User("a104", "강감찬", "010-1234-1001", 45));
            users.Add(new User("a105", "이순신", "010-1234-1001", 55));
            gridView.DataSource = users;

        }

        private void btCity1_Click(object sender, EventArgs e)
        {
           cbPos1.Text = "결과 : "+ cbCity1.Text;
        }

        private void btCity2_Click(object sender, EventArgs e)
        {
            cbPos2.Text = "결과 : " + cbCity2.Text;
        }

        private void cbPos1_Click(object sender, EventArgs e)
        {

        }

        private void cbCity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPos1.Text = "결과 : " + cbCity1.SelectedText;
        }

        private void cbCity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPos2.Text = "결과 : " + cbCity2.SelectedText;
        }
    }
}

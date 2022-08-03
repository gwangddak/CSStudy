using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = DBAccess.Instance.SelectUsers(); // 캡슐화
        



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            //입력 데이터 저장 
            string uid = txtNewId.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.InsertUser(uid, name, hp, age); // db엑세스 값 참조
            MessageBox.Show("데이터가 수정 되었습니다", "확인");
            ClearText();

    
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgv.DataSource = DBAccess.Instance.SelectUsers(); // 캡슐화
        }
        public void ClearText()
        {
            txtNewId.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
     
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow dataRow =  dgv.Rows[row];

          
            txtNewId.Text = dataRow.Cells[0].Value.ToString();
            txtName.Text = dataRow.Cells[1].Value.ToString();
            txtHp.Text = dataRow.Cells[2].Value.ToString();
            nAge.Text = dataRow.Cells[3].Value.ToString();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            string uid = txtNewId.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.UpdateUser(uid,name, hp, age); // db엑세스 값 참조


            MessageBox.Show("데이터가 수정 되었습니다", "확인");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string uid = txtNewId.Text;
            DialogResult result = MessageBox.Show("데이터가 삭제 하시겠습니까?", "확인",MessageBoxButtons.YesNo);

            
            if (result == DialogResult.Yes)
            {
                DBAccess.Instance.DeleteUser(uid);
                MessageBox.Show("데이터가 삭제 되었습니다", "확인");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
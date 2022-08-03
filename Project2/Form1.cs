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
            dgv.DataSource = DBAccess.Instance.SelectUsers(); // ĸ��ȭ
        



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            //�Է� ������ ���� 
            string uid = txtNewId.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.InsertUser(uid, name, hp, age); // db������ �� ����
            MessageBox.Show("�����Ͱ� ���� �Ǿ����ϴ�", "Ȯ��");
            ClearText();

    
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgv.DataSource = DBAccess.Instance.SelectUsers(); // ĸ��ȭ
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

            DBAccess.Instance.UpdateUser(uid,name, hp, age); // db������ �� ����


            MessageBox.Show("�����Ͱ� ���� �Ǿ����ϴ�", "Ȯ��");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string uid = txtNewId.Text;
            DialogResult result = MessageBox.Show("�����Ͱ� ���� �Ͻðڽ��ϱ�?", "Ȯ��",MessageBoxButtons.YesNo);

            
            if (result == DialogResult.Yes)
            {
                DBAccess.Instance.DeleteUser(uid);
                MessageBox.Show("�����Ͱ� ���� �Ǿ����ϴ�", "Ȯ��");
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
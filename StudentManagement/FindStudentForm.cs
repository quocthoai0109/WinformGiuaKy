using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class FindStudentForm : Form
    {
        Student student = new Student();
        My_DB db = new My_DB();
        public FindStudentForm()
        {
            InitializeComponent();
        }

        private void FindStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet3.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.qLSVDataSet3.Student);
            // TODO: This line of code loads data into the 'qLSVDataSet1.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.qLSVDataSet1.Student);

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            string id = textBoxID.Text;
            string name = textBoxName.Text;
            string adrs = textBoxAddress.Text;
            string town = textBoxPBirth.Text;
            if (textBoxID.Text != "")
            {
             
                SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE id =" +id + " AND lastname LIKE N'%"+ @name+"%'" + " AND address LIKE N'%" + @adrs + "%'" + " AND hometown LIKE N'%" + @town + "%'");

                DataTable table = student.getStudent(command);

                if (table.Rows.Count > 0)
                {
                    dataGridViewResult.ReadOnly = true;

                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridViewResult.RowTemplate.Height = 80;
                    dataGridViewResult.DataSource = student.getStudent(command);

                    picCol = (DataGridViewImageColumn)dataGridViewResult.Columns[8];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridViewResult.AllowUserToAddRows = false;
                }
                else
                {
                    dataGridViewResult.ReadOnly = true;

                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridViewResult.RowTemplate.Height = 80;
                    dataGridViewResult.DataSource = student.getStudent(command);

                    picCol = (DataGridViewImageColumn)dataGridViewResult.Columns[8];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridViewResult.AllowUserToAddRows = false;
                    MessageBox.Show("Khong tim thay SV nay!!", "Tim sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE lastname LIKE N'%" + @name + "%'" + " AND address LIKE N'%" + @adrs + "%'" + " AND hometown LIKE N'%" + @town + "%'");
          
                DataTable table = student.getStudent(command);

                if (table.Rows.Count > 0)
                {
                    dataGridViewResult.ReadOnly = true;

                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridViewResult.RowTemplate.Height = 80;
                    dataGridViewResult.DataSource = student.getStudent(command);

                    picCol = (DataGridViewImageColumn)dataGridViewResult.Columns[8];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridViewResult.AllowUserToAddRows = false;
                }
                else
                {
                    dataGridViewResult.ReadOnly = true;

                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridViewResult.RowTemplate.Height = 100;
                    dataGridViewResult.DataSource = student.getStudent(command);

                    picCol = (DataGridViewImageColumn)dataGridViewResult.Columns[8];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridViewResult.AllowUserToAddRows = false;
                    MessageBox.Show("Khong tim thay SV nay!!", "Tim sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            
        }

        bool checkDigit(string s) // neu co chu return false
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > '9' || s[i] < '0')
                    return false;
            }

            return true;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            string id = textBoxID.Text.ToString();
            if (!checkDigit(id))
            {
                MessageBox.Show("Vui long nhap so!!", "Tim sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Clear();
            }
            if (id.Length > 5)
            {
                MessageBox.Show("ID khong duoc qua 5 chu so!!", "Tim sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Clear();
            }
        }
    }
}

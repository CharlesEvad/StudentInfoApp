using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class Student_Page : Form
    {
        private string connectionString = "server=localhost;user id=root;database=StudentInfoDB"; // No password

        public Student_Page()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT studentId, CONCAT(firstName, ' ', middleName, ' ', lastName) AS fullName FROM StudentRecordTB";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                StudentDataGridView.DataSource = dataTable;

                // Add a "VIEW" button column
                DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
                viewButtonColumn.HeaderText = "";
                viewButtonColumn.Text = "VIEW";
                viewButtonColumn.Name = "ViewButtonColumn";
                viewButtonColumn.UseColumnTextForButtonValue = true;
                StudentDataGridView.Columns.Add(viewButtonColumn);
            }
        }

        private object GetSafeValue(DataGridViewCell cell)
        {
            return cell.Value == DBNull.Value ? null : cell.Value;
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StudentDataGridView.Columns["ViewButtonColumn"].Index)
            {
                var cellValue = GetSafeValue(StudentDataGridView.Rows[e.RowIndex].Cells["studentId"]);
                if (cellValue != null)
                {
                    int studentId = Convert.ToInt32(cellValue);
                    StudentPage_Individual studentPageIndividual = new StudentPage_Individual(studentId);
                    studentPageIndividual.Show();
                }
                else
                {
                    MessageBox.Show("The student ID is null or invalid.");
                }
            }
        }
    }
}
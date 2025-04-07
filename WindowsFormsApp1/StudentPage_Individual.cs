using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class StudentPage_Individual : Form
    {
        private int studentId;
        private string connectionString = "server=localhost;user id=root;database=StudentInfoDB"; // No password

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM StudentRecordTB WHERE studentId = @studentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblStudentInfo.Text = $"ID: {reader["studentId"]}\n" +
                                          $"Name: {reader["firstName"]} {reader["middleName"]} {reader["lastName"]}\n" +
                                          $"Address: {reader["houseNo"]} {reader["brgyName"]}, {reader["municipality"]}, {reader["province"]}, {reader["region"]}, {reader["country"]}\n" +
                                          $"Birthdate: {reader["birthdate"]}\n" +
                                          $"Age: {reader["age"]}\n" +
                                          $"Contact: {reader["studContactNo"]}\n" +
                                          $"Email: {reader["emailAddress"]}\n" +
                                          $"Guardian: {reader["guardianFirstName"]} {reader["guardianLastName"]}\n" +
                                          $"Hobbies: {reader["hobbies"]}\n" +
                                          $"Nickname: {reader["nickname"]}\n" +
                                          $"Course ID: {reader["courseId"]}\n" +
                                          $"Year ID: {reader["yearId"]}";
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SelectInsertUp
{
    internal class ClubRegistrationQuery
    {
        // Database connection and command objects
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        // Data handling objects
        public DataTable dataTable;
        public BindingSource bindingSource;

        // Connection string for the database
        private string conectionString;

        // Fields to store club member information
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;


        public ClubRegistrationQuery() // Constructor
        {
            // Initialize the connection string and database objects
            conectionString = "Data Source=DESKTOP-R0UDTTE\\SQLEXPRESS;Initial Catalog=ClubDB_Joson;Integrated Security=True;Trust Server Certificate=True";
            sqlConnect = new SqlConnection(conectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }
        // Method to display the list of club members
        public bool DisplayList()
        {
            // SQL query to select club member details
            string ViewClubMembers = "SELECT StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";

            // Create a data adapter to execute the query and fill the data table
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            // Clear existing data and fill the data table with new data
            dataTable.Clear();
            sqlAdapter.Fill(dataTable); // Fill the data table with the results of the query
            bindingSource.DataSource = dataTable; // Bind the data table to the binding source

            return true;
        }
        // Method to register a new student
        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            // SQL command to insert a new club member
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            // Execute the command to insert the new member
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

    }
}

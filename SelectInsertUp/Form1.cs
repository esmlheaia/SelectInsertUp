using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectInsertUp
{
    public partial class FrmClubRegistration : Form
    {
        // Declare variables
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, Count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentID;

        

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery(); // Initialize the ClubRegistrationQuery object
            RefreshListOfClubMembers(); // Refresh the list of club members on form load
        }
        // Method to refresh the list of club members
        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList(); // Call the method to display the list
            datalist.DataSource = clubRegistrationQuery.bindingSource; // Bind the data to the data list
        }
        // Method to generate a unique registration ID
        public int RegistrationID()
        {
            Count++; // Increment the count
            return Count; 
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            ID = RegistrationID(); // Generate a new registration ID

            StudentID = Convert.ToInt32(txtstudentid.Text); // Retrieve StudentID from text box
           
            FirstName = txtfirstname.Text; // Retrieve FirstName from text box
            MiddleName = txtmiddlename.Text; // Retrieve MiddleName from text box
            LastName = txtlastname.Text; // Retrieve LastName from text box

            Gender = cmbgender.Text; 
            Program = cmbprogram.Text;

            Age = Convert.ToInt32(txtage.Text); // Retrieve Age from text box


            // Retrieve input values from text boxes and combo box
            clubRegistrationQuery.RegisterStudent(ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program);
            RegistrationID();
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers(); // Refresh the list of club members when the refresh button is clicked
        }
        private void datalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember(); // Create a new instance of FrmUpdateMember
            frmUpdateMember.Show();
        }
    }
    }


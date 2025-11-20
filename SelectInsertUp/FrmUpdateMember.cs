using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectInsertUp
{
    public partial class FrmUpdateMember : Form
    {
        ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        
        public FrmUpdateMember()
        {
            InitializeComponent();

            clubRegistrationQuery.IdSelect(cmbStudentID); // Populate the StudentID combo box
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update student information using the values from the form controls
            clubRegistrationQuery.UpdateStudent(Convert.ToInt32(cmbStudentID.Text), txtFirstName.Text, txtLastName.Text, txtMiddlename.Text, Convert.ToInt32(txtAge.Text), cmbGender.Text, cmbProgram.Text);
            FrmClubRegistration frmClubRegistration = new FrmClubRegistration();
            frmClubRegistration.RefreshListOfClubMembers();

        }
        // Auto-fill student information when a StudentID is selected
        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Auto search for student information based on the selected StudentID
            clubRegistrationQuery.AutoSearch(txtFirstName, txtMiddlename, txtLastName, txtAge, cmbGender, cmbProgram, Convert.ToInt32(cmbStudentID.Text));
        }

        // Populate the StudentID combo box when the form loads
        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            // Populate the StudentID combo box when the form loads
            clubRegistrationQuery.IdSelect(cmbStudentID);
        }
    }
}

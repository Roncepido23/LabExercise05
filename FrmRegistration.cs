using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, tbStudentNo.Text + ".txt")))
            {
                var builder = new StringBuilder();
                builder.AppendLine("Student No.: " + tbStudentNo.Text);
                builder.AppendLine("Full Name: " + tbLastName.Text + ", " + tbFirstName.Text + " " + tbMiddle.Text);
                builder.AppendLine("Program: " + cbProgram.SelectedItem.ToString());
                builder.AppendLine("Gender: " + cbGender.SelectedItem.ToString());
                builder.AppendLine("Age: " + tbAge.Text);
                builder.AppendLine("Birthday: " + dtpBirthday.Value.ToShortDateString());
                builder.AppendLine("Contact No.: " + tbContactNo.Text);

                outputFile.Write(builder.ToString());
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            var programs = new List<string>
            {
                "Computer Science",
                "Information Technology",
                "Accountancy",
                "Business Administration",
                "Psychology",
                "Engineering"
            };

            foreach (var program in programs) cbProgram.Items.Add(program);

            var genders = new List<string>
            {
                "Male",
                "Female",
            };

            foreach (var gender in genders) cbGender.Items.Add(gender);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmStudentRecord().Show();
        }
    }
}

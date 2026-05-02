using System;
using System.Windows.Forms;

namespace ooptest1
{
    public partial class DoctorForm : Form
    {
        public Doctor DoctorData { get; private set; }
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtDoctorName.Text) &&
                !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                !string.IsNullOrWhiteSpace(txtClinic.Text) &&
                !string.IsNullOrWhiteSpace(dtpNextVisit.Text))

            {
                DoctorData = new Doctor
                {
                    Name = txtDoctorName.Text,
                    Phone = txtPhone.Text,
                    Clinic = txtClinic.Text,
                    NextVisit = dtpNextVisit.Value
                };

                MessageBox.Show("Doctor information saved successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

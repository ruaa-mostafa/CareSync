using System;
using System.Drawing;
using System.Windows.Forms;

namespace ooptest1
{
    public partial class AddMedicationForm : Form
    {
        string selectedImagePath = "";

        Medication med;
        public Medication MedicationData { get; set; }

        public AddMedicationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var newMed = new Medication();

            newMed.PrescriptionPath = selectedImagePath; 

            // validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a medication name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBoxes.Text, out int boxes))
            {
                MessageBox.Show("Enter a valid number for Boxes.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStrips.Text, out int strips))
            {
                MessageBox.Show("Enter a valid number for Strips.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPills.Text, out int pills))
            {
                MessageBox.Show("Enter a valid number for Pills.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please attach a prescription photo first!");
                return;
            }


           
            string fileName = System.IO.Path.GetFileName(selectedImagePath);
      
            string imagesFolder = System.IO.Path.Combine(Application.StartupPath, "Images");

            if (!System.IO.Directory.Exists(imagesFolder))
                System.IO.Directory.CreateDirectory(imagesFolder);

            string destPath = System.IO.Path.Combine(imagesFolder, fileName);

            System.IO.File.Copy(selectedImagePath, destPath, true);

            newMed.PrescriptionPath = destPath;

            newMed.Name = txtName.Text.Trim();
            newMed.Dosage = txtDosage.Text.Trim(); 
            newMed.ReminderTime = dtTime.Value; 
            newMed.Instructions = txtInstructions.Text.Trim();
            newMed.Boxes = boxes;  
            newMed.Strips = strips;
            newMed.Pills = pills;

            this.MedicationData = newMed;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                btnAddImage.Text = "Image Added!"; 
                btnAddImage.BackColor = Color.LightGreen;  
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ooptest1
{
    public partial class MainForm : Form
    {

        private BindingList<Medication> meds = new BindingList<Medication>();


        private string filePath = "medications.json";

        private Doctor doctor;

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeGrid();
            LoadData();
        }

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
        }


       
        private void AddButtonColumn()
        {
            if (!dataGridView1.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                btn.Name = "Action";
                btn.HeaderText = "Action";
                btn.Text = "Taken";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
            }

        }

       private void LoadData()
        {

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var list = JsonSerializer.Deserialize<List<Medication>>(json) ?? new List<Medication>();
                    meds = new BindingList<Medication>(list);
                }
                catch
                {
                    meds = new BindingList<Medication>();
                }
            }

            else
            {
                meds = new BindingList<Medication>();

            }
            //Array of object

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = meds.ToArray();
        }




        private void SaveMedications()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            // Filter out null entries before saving
            var listToSave = meds.Where(m => m != null).ToList();
            string json = JsonSerializer.Serialize(listToSave, options);
            File.WriteAllText(filePath, json);
        }

        //  ربط زر إضافة دواء بالكلاس
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMedicationForm form = new AddMedicationForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Medication med = form.MedicationData;
                meds.Add(med);
                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = meds.ToArray();

                SaveMedications();
            }
        }
        //  ربط زر إضافة طبيب بالكلاس
        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();

            if (doctorForm.ShowDialog() == DialogResult.OK)
            {
                doctor = doctorForm.DoctorData;

                lblDoctorName1.Text = "Doctor: " + doctor.Name;
                lblDocPhone.Text = "Phone: " + doctor.Phone;
                lblDocClinic.Text = "Clinic: " + doctor.Clinic;
                lblDoctorNextVisit.Text = " Next Visit: " + doctor.NextVisit.ToShortDateString();

            }

        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            foreach (Medication med in meds)
            {
                if (med == null) continue;

               
                DateTime medTime = med.ReminderTime;

                if (med.LastTakenDate.Date != now.Date && Math.Abs((now - medTime).TotalSeconds) <= 30)
                {
                    try
                    {
                     
                        string SoundPath = System.IO.Path.Combine(Application.StartupPath, "reminder.wav");
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundPath);
                        player.Load();
                        player.PlaySync();
                    }

                    catch (Exception ex)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        Console.WriteLine("Sound Error: " + ex.Message);
                    }

                    MessageBox.Show("Time to take: " + med.Name, "Medication Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    med.LastTakenDate = now.Date;

                    SaveMedications();
                }
                if (DateTime.Now > medTime.AddMinutes(2) && med.Status != MedStatus.Taken)
                {
                    med.Status = MedStatus.Missed;
                    MessageBox.Show(" you are about to miss out " + med.Name );

                   SaveMedications();
                }
            }

            dataGridView1.Refresh();
        }
      
        //test

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Action")
            {
                var selectedMed = dataGridView1.Rows[e.RowIndex].DataBoundItem as Medication;
                if (selectedMed != null)
                {
                    selectedMed.Status = MedStatus.Taken;
                    selectedMed.LastTakenDate = DateTime.Now;
                    SaveMedications();
                    dataGridView1.Refresh();
                }
                return;
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "mdName")
            {
                var selectedMed = dataGridView1.Rows[e.RowIndex].DataBoundItem as Medication;
                if (selectedMed != null)
                {
                    picPrescription.ImageLocation = selectedMed.PrescriptionPath;
                    picPrescription.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }



        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var med = dataGridView1.Rows[e.RowIndex].DataBoundItem as Medication;

            if (med == null) return;

            if (med.Status == MedStatus.Taken)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }

            else if ( med.Status == MedStatus.Missed)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }

            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void InitializeGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Medication",
                DataPropertyName = "Name",
                Name = "Name"

            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Dosage",     
                DataPropertyName = "Dosage", 
                Name = "Dosage"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Instructions",
                DataPropertyName = "Instructions",
                Name = "Instructions"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Time",
                DataPropertyName = "ReminderTime",
                Name = "ReminderTime",
                DefaultCellStyle = { Format = "hh:mm tt" }

            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "status",
                DataPropertyName = "Status",
                Name = "Status"
            });


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                Name = "Action",
                HeaderText = "Action",
                Text = "Taken",
                UseColumnTextForButtonValue = true
            };

            dataGridView1.Columns.Add(btnColumn);

        }


        private void lblDoctorName1_Click(object sender, EventArgs e)
        {
            lblDoctorName1.Text = "Doctor: " + doctor.Name;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; 

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            var selectedMed = dataGridView1.Rows[e.RowIndex].DataBoundItem as Medication;

            if (selectedMed == null) return;
            if (columnName == "Action")
            {
                selectedMed.Status = MedStatus.Taken; // Enum
                selectedMed.LastTakenDate = DateTime.Now;
                SaveMedications();
                dataGridView1.Refresh(); 
            }
            
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedMed = dataGridView1.Rows[e.RowIndex].DataBoundItem as Medication;

                if (selectedMed != null && !string.IsNullOrEmpty(selectedMed.PrescriptionPath))
                {
                   
                        picPrescription.Visible = true;
                        picPrescription.BringToFront();

                       
                        if (picPrescription.Image != null) picPrescription.Image.Dispose();

                        picPrescription.Image = Image.FromFile(selectedMed.PrescriptionPath);
                        picPrescription.SizeMode = PictureBoxSizeMode.Zoom;
                   
                }
            }
        }
    }

}

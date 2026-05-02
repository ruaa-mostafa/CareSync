namespace ooptest1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.reminderTimer = new System.Windows.Forms.Timer(this.components);
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDocClinic = new System.Windows.Forms.Label();
            this.lblDoctorName1 = new System.Windows.Forms.Label();
            this.lblDocPhone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDoctorNextVisit = new System.Windows.Forms.Label();
            this.picPrescription = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.LightCyan;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(998, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(239, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Medication";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoctor.BackColor = System.Drawing.Color.LightCyan;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(113, 706);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(263, 51);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Add Doctor Info";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // reminderTimer
            // 
            this.reminderTimer.Enabled = true;
            this.reminderTimer.Interval = 60000;
            this.reminderTimer.Tick += new System.EventHandler(this.reminderTimer_Tick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Teal;
            this.lblWelcome.Location = new System.Drawing.Point(409, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(385, 96);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mdName,
            this.mdTime,
            this.Status,
            this.Action});
            this.dataGridView1.Location = new System.Drawing.Point(36, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1201, 122);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mdName
            // 
            this.mdName.HeaderText = "Medicine";
            this.mdName.MinimumWidth = 8;
            this.mdName.Name = "mdName";
            // 
            // mdTime
            // 
            this.mdTime.HeaderText = "Time";
            this.mdTime.MinimumWidth = 8;
            this.mdTime.Name = "mdTime";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            // 
            // lblDocClinic
            // 
            this.lblDocClinic.AutoSize = true;
            this.lblDocClinic.BackColor = System.Drawing.Color.Lavender;
            this.lblDocClinic.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocClinic.Location = new System.Drawing.Point(12, 193);
            this.lblDocClinic.Name = "lblDocClinic";
            this.lblDocClinic.Size = new System.Drawing.Size(88, 38);
            this.lblDocClinic.TabIndex = 4;
            this.lblDocClinic.Text = "Clinic";
            // 
            // lblDoctorName1
            // 
            this.lblDoctorName1.AutoSize = true;
            this.lblDoctorName1.BackColor = System.Drawing.Color.Lavender;
            this.lblDoctorName1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName1.Location = new System.Drawing.Point(12, 61);
            this.lblDoctorName1.Name = "lblDoctorName1";
            this.lblDoctorName1.Size = new System.Drawing.Size(95, 38);
            this.lblDoctorName1.TabIndex = 6;
            this.lblDoctorName1.Text = "Name";
           
            // 
            // lblDocPhone
            // 
            this.lblDocPhone.AutoSize = true;
            this.lblDocPhone.BackColor = System.Drawing.Color.Lavender;
            this.lblDocPhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocPhone.Location = new System.Drawing.Point(12, 128);
            this.lblDocPhone.Name = "lblDocPhone";
            this.lblDocPhone.Size = new System.Drawing.Size(100, 38);
            this.lblDocPhone.TabIndex = 7;
            this.lblDocPhone.Text = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.lblDoctorNextVisit);
            this.groupBox1.Controls.Add(this.lblDoctorName1);
            this.groupBox1.Controls.Add(this.lblDocPhone);
            this.groupBox1.Controls.Add(this.lblDocClinic);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 344);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Info :";
            
            // 
            // lblDoctorNextVisit
            // 
            this.lblDoctorNextVisit.AutoSize = true;
            this.lblDoctorNextVisit.BackColor = System.Drawing.Color.Lavender;
            this.lblDoctorNextVisit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorNextVisit.Location = new System.Drawing.Point(6, 258);
            this.lblDoctorNextVisit.Name = "lblDoctorNextVisit";
            this.lblDoctorNextVisit.Size = new System.Drawing.Size(146, 38);
            this.lblDoctorNextVisit.TabIndex = 8;
            this.lblDoctorNextVisit.Text = "Next Visit";
            // 
            // picPrescription
            // 
            this.picPrescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPrescription.BackColor = System.Drawing.Color.LightCyan;
            this.picPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPrescription.Location = new System.Drawing.Point(783, 429);
            this.picPrescription.Name = "picPrescription";
            this.picPrescription.Size = new System.Drawing.Size(393, 309);
            this.picPrescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrescription.TabIndex = 10;
            this.picPrescription.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1262, 769);
            this.Controls.Add(this.picPrescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnAdd);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Timer reminderTimer;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDocClinic;
        private System.Windows.Forms.Label lblDoctorName1;
        private System.Windows.Forms.Label lblDocPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Label lblDoctorNextVisit;
        private System.Windows.Forms.PictureBox picPrescription;
    }
}
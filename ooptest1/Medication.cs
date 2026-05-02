using System;

namespace ooptest1
{
    // Enum to represent the status of medication:
    public enum MedStatus
    {
        Pending,
        Taken,
        Missed
    }

    public class Medication
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public DateTime StartDate { get; set; }
        public int Boxes { get; set; }
        public int Strips { get; set; }
        public int Pills { get; set; }

        public int CurrentStrips { get; set; }
        public int CurrentPills { get; set; }

        public string Instructions { get; set; }

        public DateTime ReminderTime { get; set; }
        public string Frequency { get; set; }
        public string Notes { get; set; }
        public string DoctorName { get; set; }
        public DateTime LastTakenDate { get; set; }
  
        public MedStatus Status { get; set; } = MedStatus.Pending;


        public Medication(string name, string dosage, DateTime reminderTime,
            int boxes, int strips, int pills, string instructions)
        {
            Name = name;
            Dosage = dosage;
            ReminderTime = reminderTime;

            Boxes = boxes;
            Strips = strips;
            Pills = pills;

            CurrentStrips = strips;
            CurrentPills = pills;

            Instructions = instructions;
        }


        public Medication()
        {

        }

        public string PrescriptionPath { get; set; }
    }

}

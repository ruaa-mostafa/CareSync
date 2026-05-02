using System;

namespace ooptest1
{
    // (Base Class)
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        //  (Polymorphism)
        public virtual string GetInfo()
        {
            return $"Name: {Name}, Phone: {Phone}";
        }
    }

    // Person (Inheritance)
    public class Doctor : Person
    {
        public string Clinic { get; set; }
        public DateTime NextVisit { get; set; }

        // (Polymorphism - Method Overriding)
        public override string GetInfo()
        {
            return $"Dr. {Name}, Clinic: {Clinic}, Contact: {Phone},Next Visit: {NextVisit.ToShortDateString()}";
        }
    }
}

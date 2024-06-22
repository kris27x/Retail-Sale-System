using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public string StaffFullName { get; set; }
        public int StaffID { get; set; }
        public bool Availability { get; set; }
        public string StaffRole { get; set; }
        public DateTime StartDate { get; set; }
        public int CustomerID { get; set; }
    }
}
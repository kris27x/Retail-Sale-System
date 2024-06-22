using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StaffTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff Staff = new clsStaff();

            Assert.IsNotNull(Staff);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "Alex Otl";
            Staff.StaffFullName = TestData;
            Assert.AreEqual(Staff.StaffFullName, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            int TestData = 1;
            Staff.StaffID = TestData;
            Assert.AreEqual(Staff.StaffID, TestData);
        }
        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean TestData = true;
            Staff.Availability = TestData;
            Assert.AreEqual(Staff.Availability, TestData);
        }
        [TestMethod]
        public void StaffRolePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "Admin";
            Staff.StaffRole = TestData;
            Assert.AreEqual(Staff.StaffRole, TestData);
        }
        [TestMethod]
        public void StartDatePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            Staff.StartDate = TestData;
            Assert.AreEqual(Staff.StartDate, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            int TestData = 1;
            Staff.CustomerID = TestData;
            Assert.AreEqual(Staff.CustomerID, TestData);
        }
    }
}

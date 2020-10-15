﻿using CaseStudy2.Service;
using CaseStudy2.ServiceImpl;
using CaseStudy2.Model;
using Moq;
using Xunit;

namespace AlertToCareTests.ServiceImplTests
{
    public class OccupancyServiceImplTest
    {
        private Mock<IOccupancyService> _mockRepo;

        private OccupancyServiceImpl occupancyServiceImpl=new OccupancyServiceImpl();
        

        public OccupancyServiceImplTest()
        {
            _mockRepo = new Mock<IOccupancyService>();
            // occupancyServiceImpl = new OccupancyServiceImpl(_mockRepo.Object);
            
        }
       /* [Fact]
        public void CheckBedStatusTest()
        {
            string s = "bedId";
            var result = occupancyServiceImpl.CheckBedStatus(s);
            Assert.True(result);
            Assert.IsType<bool>(result);
        }
        [Fact]
        public void DischargePatientTest()
        {
            var result = occupancyServiceImpl.DishchargePatient(1);
            Assert.False(result);
            Assert.IsType<bool>(result);
        }*/
        [Fact]
        public void AddPatientTest()
        {
            PatientData patientData = new PatientData();
            patientData.Id = 1;
            patientData.Name = "Cr";
            patientData.Address = "UP";
            patientData.Email = "Cr@gmail.com";
            patientData.RespRate = 90.0;
            patientData.Spo2 = 80.0;
            patientData.Bpm = 100.0;
            patientData.IcuId = 10;
            patientData.BedId = "B1";
            var result = occupancyServiceImpl.AddNewPatient(null);
            Assert.False(result);
            Assert.IsType<bool>(result);
        }
    }
}

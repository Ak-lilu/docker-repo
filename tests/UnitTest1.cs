using Xunit;
using myWebApp.Models;

namespace myWebApp.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Student_Constructor_Should_Set_Properties()
        {
            // Arrange
            int id = 1;
            string lastName = "Whale";
            string firstMidName = "Moby";
            DateTime enrollmentDate = new(2013, 3, 16);

            // Act
            Student student = new()
            {
                ID = id,
                LastName = lastName,
                FirstMidName = firstMidName,
                EnrollmentDate = enrollmentDate
            };

            // Assert
            Assert.Equal(id, student.ID);
            Assert.Equal(lastName, student.LastName);
            Assert.Equal(firstMidName, student.FirstMidName);
            Assert.Equal(enrollmentDate, student.EnrollmentDate);
        }
    }
}

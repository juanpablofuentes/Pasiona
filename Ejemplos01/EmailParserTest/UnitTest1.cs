using Parseadores;

namespace EmailParserTest
{
    public class UnitTest1
    {
        [Theory]
        [ClassData(typeof(EmailTestData))]
        public void EmailParser_Should_Return_Domain(string email, string expectedDomain)
        {
            // Arrange
            

            // Act
            var domain = EmailParser.GetDomain(email);

            // Assert
            Assert.Equal(domain, expectedDomain);
        }

        public class EmailTestData : TheoryData<string, string>
        {
            public EmailTestData()
            {
                Add("test@test.com", "test.com");
                Add("milan@milanjovanovic.tech", "milanjovanovic.tech");
                Add("pepe", "");
            }
        };
    }
}
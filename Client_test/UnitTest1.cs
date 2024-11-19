using User_Interface;
using NUnit.Framework;
using User_Interface.Old_content.Main_page;

namespace Client_test
{
    public class Tests
    {
        [SetUp]
        
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestFixture]
        
        public class ValidationTests
        {
            [Test]
            [TestCase("15.10.2024", true)]  // �������� ����
            [TestCase("31.02.2023", false)] // ���������� ���� � �������
            [TestCase("01.13.2023", false)] // ���������� �����
            [TestCase("01.10.abc", false)]  // ���������� ������� � ����
            [TestCase("32.01.2023", false)] // ���������� ����
            [TestCase("01-01-2023", false)] // ������������ ������
            public void IsValidDate_match_with_mask_Test(string input, bool expectedResult)
            {
                bool result = Validation_class.IsValidDate_match_with_mask(input);
                Assert.AreEqual(expectedResult, result);
            }

            [Test]
            [TestCase("15.10.2023", true)]  // �������� ����
            [TestCase("29.02.2023", false)] // ���������� ����
            [TestCase("01.13.2023", false)] // ���������� �����
            [TestCase("01.10.abc", false)]  // ���������� ������� � ����
            [TestCase("32.01.2023", false)] // ���������� ����
            [TestCase("01.01.2025", false)] // ���� � �������
            [TestCase("01.01.1919", false)] // ��� ��� ���������
            public void IsValidDate_match_good_date_Test(string input, bool expectedResult)
            {
                bool result = Validation_class.IsValidDate_match_good_date(input);
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}
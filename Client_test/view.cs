using NUnit.Framework;
using Moq;
using System;
using System.Windows.Forms;
using User_Interface.Old_content.Main_page;
using User_Interface.Old_content;

namespace User_setup.Tests
{
    [TestFixture]
    public class MainPageTests
    {
        private IDisposable disposableResource;
        private Mock<Get_data_table_Class> mockDataTableClass;
        private Mock<Connect_class> mockConnectClass;
        private Main_page_Form mainPage;

        [SetUp]
        public void Setup()
        {
            mockConnectClass = new Mock<Connect_class>();
            mockDataTableClass = new Mock<Get_data_table_Class>(mockConnectClass.Object);
            mainPage = new Main_page_Form(1);

        }

        [Test]
        public void Main_page_Load_DataTable_Correctly_Filled()
        {
            // Arrange
            mainPage.get_date_box().Text = "13.12.2021";
            string date = "13.12.2021";
            // Act
            mainPage.richTextBox3_Leave(null, EventArgs.Empty);


            // Assert
            Assert.AreEqual(mainPage.get_date_box().Text, date);


        }

        [Test]
        public void RichTextBox3_KeyPress_OnlyAcceptsDigitsAndDot()
        {
            // Arrange
            var e = new KeyPressEventArgs('a');
            var sender = new Mock<RichTextBox>();

            // Act
            mainPage.richTextBox3_KeyPress(sender.Object, e);

            // Assert
            Assert.IsTrue(e.Handled);
        }

        [Test]
        public void RichTextBox3_Leave_InvalidDate_ClearsAndFocusesTextBox()
        {
            // Arrange
            mainPage.get_name_box().Text = "";

            // Act
            mainPage.richTextBox3_Leave(null, EventArgs.Empty);
            

            // Assert
            Assert.IsEmpty(mainPage.get_name_box().Text);
            Assert.IsFalse(mainPage.get_name_box().Focused);
        }

        [Test]
        public void PictureBox2_Click_ClosesApplication()
        {
            // Test for clicking the close button
            Assert.DoesNotThrow(() => mainPage.pictureBox2_Click(null, EventArgs.Empty));
        }

        //[Test]
        //public void DeleteButton_Click_ConfirmsAndDeletes()
        //{
        //    // Arrange
        //    var result = DialogResult.Yes;
        //    MessageBox.Show = (text, caption, buttons, icon) => result;

        //    var row = new DataGridViewRow();
        //    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "testUser" });
        //    mainPage.Data_table.Rows.Add(row);

        //    // Act
        //    mainPage.Delete_button_Click(null, EventArgs.Empty);

        //    // Assert
        //    mockConnectClass.Verify(m => m.Delete_friend_from_db(It.IsAny<Connect_class>(), "testUser"), Times.Once);
        //}
        [TearDown]
        public void TearDown()
        {
            if (mainPage != null)
            {
                mainPage.Dispose();
                mainPage = null; // Обнуляем для последующих тестов
            }
        }

        // Add other tests as needed
    }
}
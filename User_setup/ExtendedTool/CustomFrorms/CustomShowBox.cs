using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using User_Interface.ExtendedTool.Connect_and_query;

namespace User_Interface.ExtendedTool
{
    public partial class CustomShowBox : Form
    {
        
        public string FilePath { get; private set; }
        private DBdata? DBdata { get; set; }

        public CustomShowBox()
        {
            InitializeComponent();
        }

        

        private void guna2ButtonOk_Click(object sender, EventArgs e)
        {
            FilePath = guna2TextBoxFilePath.Text;
            if (File.Exists(FilePath) )
            {
                try
                {
                    DBdata = JsonSerializer.Deserialize<DBdata>(FilePath);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    guna2TextBoxFilePath.Clear();

                }
                catch (JsonException ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    guna2TextBoxFilePath.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    guna2TextBoxFilePath.Clear();
                }
                
                
            }
            else
            {
                guna2TextBoxFilePath.Clear();
                label1.ForeColor = Color.Red;
                label1.Text = "Enter exist Json";
            }
        }

        private void guna2TextBoxFilePath_Enter(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Text = "Enter Json Fpath";
        }

        private void guna2TextBoxFilePath_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Text = "Enter Json Fpath";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

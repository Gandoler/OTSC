
using Guna.UI2.WinForms;
using User_Interface;
using User_Interface.Main_page;


namespace User_setup
{
    public partial class Main_page_Form : Form
    {
        public Get_data_table_Class get_Data_Table_Class;
        public long ID = 0;
        Connect_class connec_Class = new Connect_class();


        public Main_page_Form(long iD)
        {
            get_Data_Table_Class = new Get_data_table_Class(connec_Class);
            InitializeComponent();
            ID = iD;
        }



        public void Main_page_Load(object sender, EventArgs e)
        {

            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }

        public void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
        }
        public System.Data.DataTable GetData()
        {
            return get_Data_Table_Class.get_dataTable(this.ID);
        }
        public RichTextBox get_name_box()
        {
            return UserName_TextBox;
        }


        public RichTextBox get_date_box()
        {
            return Date_TextBox;
        }


        public void richTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void richTextBox3_Leave(object sender, EventArgs e)
        {
            string input = Date_TextBox.Text;
            if (input == "") { return; }
            if (!Validation_class.IsValidDate_match_with_mask(input))
            {
                Date_TextBox.Clear();
                Date_TextBox.Focus(); // Возвращаем фокус на RichTextBox
            }
            if (!Validation_class.IsValidDate_match_good_date(input))
            {
                Date_TextBox.Clear();
                Date_TextBox.Focus(); // Возвращаем фокус на RichTextBox
            }

        }


        public void Data_table_Click(object sender, EventArgs e)
        {
            UserName_TextBox.Text = Data_table.SelectedRows[0].Cells[0].Value.ToString();
            Name_TextBox.Text = Data_table.SelectedRows[0].Cells[1].Value.ToString();

            string dateValue = Data_table.SelectedRows[0].Cells[2].Value.ToString();
            Date_TextBox.Text = dateValue.Length >= 10 ? dateValue.Substring(0, 10) : dateValue;

            Interests_TextBox.Text = Data_table.SelectedRows[0].Cells[3].Value.ToString();
        }

        public void Delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить этот элемент?",
                                                    "Подтверждение удаления",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (Data_table.SelectedRows.Count > 0 &&
                    Data_table.SelectedRows[0].Cells[0].Value != null &&
                    !string.IsNullOrEmpty(Data_table.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    string UserName = Data_table.SelectedRows[0].Cells[0].Value.ToString();
                    Query_class.Delete_friend_from_db(connec_Class, UserName);
                    MessageBox.Show("Элемент успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Выделенная строка пуста или содержит недопустимое значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Удаление отменено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);
        }

        public void Add_button_Click_1(object sender, EventArgs e)
        {
            Query_class.Add_friend_to_db(connec_Class, UserName_TextBox.Text, Name_TextBox.Text, Date_TextBox.Text, Interests_TextBox.Text, ID);
            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);
        }

        public void UserName_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                Only_english.Visible = true;
                UserName_TextBox.ForeColor = Color.White;
                e.Handled = true;

            }
            else
            {
                Only_english.Visible = false;
                UserName_TextBox.ForeColor = Color.Black;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Only_english.Visible = true;
            }

        }

        public void Name_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                e.Handled = true;
                Name_ne_dayet.Visible = true;
                Name_TextBox.ForeColor = Color.White;
            }
            else
            {
                Name_ne_dayet.Visible = false;
                Name_TextBox.ForeColor = Color.Black;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Name_ne_dayet.Visible = true;
            }
        }

        public void Interests_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                e.Handled = true;
                interest_ne_daet.Visible = true;
                Interests_TextBox.ForeColor = Color.White;

            }
            else
            {
                interest_ne_daet.Visible = false;
                Interests_TextBox.ForeColor = Color.Black;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                interest_ne_daet.Visible = true;

            }
        }

        public void Update_button_Click(object sender, EventArgs e)
        {
            Query_class.Update_friend_in_db(connec_Class, UserName_TextBox.Text, Name_TextBox.Text, Date_TextBox.Text, Interests_TextBox.Text, ID);
            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);

        }

        public void clear_int_Click(object sender, EventArgs e)
        {
            Interests_TextBox.Clear();
        }

        public void Date_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void clear_date_Click(object sender, EventArgs e)
        {
            Date_TextBox.Clear();
        }

        public void clear_name_Click(object sender, EventArgs e)
        {
            Name_TextBox.Clear();
        }

        public void clear_usrname_Click(object sender, EventArgs e)
        {
            UserName_TextBox.Clear();
        }



        public void Only_english_Click(object sender, EventArgs e)
        {

        }

        public void UserName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void UserName_TextBox_Leave(object sender, EventArgs e)
        {
            Only_english.Visible = false;
        }

        public void Only_english_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        public void Name_TextBox_Leave(object sender, EventArgs e)
        {
            interest_ne_daet.Visible = false;
        }

        public void interest_ne_daet_Leave(object sender, EventArgs e)
        {
            interest_ne_daet.Visible = false;
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void Date_TextBox_Enter(object sender, EventArgs e)
        {
            date_label_type.Visible = false;
        }

        public void date_label_type_Leave(object sender, EventArgs e)
        {
            if (Date_TextBox.Text == "")
            {
                date_label_type.Visible = true;
            }

        }
    }
}

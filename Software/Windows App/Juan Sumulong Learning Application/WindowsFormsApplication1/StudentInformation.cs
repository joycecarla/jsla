using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace juan_sumulong_learning_app
{
    public partial class StudentInformation : Form
    {
        private List<ListViewItem> _items = new List<ListViewItem>();
        private Database _database;
        private string _avatarpath;
        private string _avatarfilename;

        public StudentInformation(Database database)
        {
            InitializeComponent();
            _database = database;
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            scanRecords();
            cbxYear.Items.Clear();
            string[,] result = _database.ExecuteQuery("select distinct year from tbl_sections;");
            for (int i = 0; i < result.GetLength(0); i++)
                cbxYear.Items.Add(result[i, 0]);



        }
        

        private void scanRecords()
        {
            _items.Clear();
            
            //mysql
            Database d = new Database("jsla", "localhost");
            string[,] result = d.ExecuteQuery("select Stud_ID, LastName, FirstName, MiddleName, Year, Name from tbl_student, tbl_sections where tbl_student.Section_ID = tbl_sections.Section_ID");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(result[i, 0]);
                item.SubItems.Add(result[i, 1]);
                item.SubItems.Add(result[i, 2]);
                item.SubItems.Add(result[i, 3]);
                item.SubItems.Add(result[i, 4]);
                item.SubItems.Add(result[i, 5]);

                _items.Add(item);
            }

            filterItems();
        }

        private void filterItems()
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(_items.ToArray());
            for (int i = 0; i < _items.Count; i++)
            {
                bool n1 = txtSearch.Text == String.Empty;
                bool n2 = _items[i].Text.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower());
                bool n3 = _items[i].SubItems[1].Text.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower());
                bool n4 = _items[i].SubItems[2].Text.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower());
                bool n5 = _items[i].SubItems[3].Text.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower());
                bool n6 = _items[i].SubItems[4].Text.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower());
                bool n7 = _items[i].SubItems[5].Text.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower());

                if (n1)
                    continue;
                else if (!(n2 || n3 || n4 || n5 || n6 || n7))
                    listView1.Items.Remove(_items[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterItems();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterItems();
        }

        private void cbxYear_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxYear.SelectedItem != null)
            {
                cbxSection.Items.Clear();
                string[,] result = _database.ExecuteQuery("select distinct name from tbl_sections where year = '" + cbxYear.Text + "'");
                for (int i = 0; i < result.GetLength(0); i++)
                    cbxSection.Items.Add(result[i, 0]); 
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[,] sectionid = _database.ScanRecords("tbl_sections", new string[] { "Section_ID" },  "Name = '" + cbxSection.Text + '\'');

            if (_avatarpath != String.Empty)
                if (_database.InsertRecord("tbl_student",
                    lblStudentNumber.Text,
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtMiddleName.Text,
                    sectionid[0, 0],
                    "avatars/" + _avatarfilename))
                    using (System.Net.WebClient client = new System.Net.WebClient())
                        client.UploadFile("localhost/ITS/avatar/" + lblStudentNumber.Text, _avatarpath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "*.jpg, *.jpeg, *.png, *.img | Image Files | *.* | All Files"
            };
            if (avatar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _avatarpath = avatar.FileName;
                _avatarfilename = avatar.SafeFileName;
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

        }

        private void StudentInformation_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCancel.Text = "Clear";
        }
    }
}

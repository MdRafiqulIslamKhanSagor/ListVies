using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string nameList;
        string contactList;
        string emaiList;
        ListViewItem row = new ListViewItem();
        private void addAllButton_Click(object sender, EventArgs e)
        {

            nameList = nameTextBox.Text;
            contactList = contactTextBox.Text;
            emaiList = emailTextBox.Text;


            addUserInfoToList();
            clearTextBox();

        }

        private void addUserInfoToList()
        {


            row.Text = nameList.ToString();
            row.SubItems.Add(contactList.ToString());
            row.SubItems.Add(emaiList.ToString());

            allInfoListView.Items.Add(row);
            //allInfoListView.Items.Add(contactList.ToString());
        }

        private void clearTextBox()
        {
            nameTextBox.Clear();
            contactTextBox.Clear();
            emailTextBox.Clear();
        }

        private void clearAllFromTable_Click(object sender, EventArgs e)
        {
            allInfoListView.Items.Clear();
        }

        private void allInfoListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = allInfoListView.Items[0];
            string name = item.Text;
            string contactNumber = item.SubItems[1].Text;
            string email = item.SubItems[2].Text;

            MessageBox.Show("name :" + name + "Contact NUmber" +contactNumber +"Email" +email);
        }
    }
}

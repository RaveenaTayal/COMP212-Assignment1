using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment01
{
    public partial class ManagerForm : Form
    {
        //List to hold email addresses of subscribers
        List<string> emailList = new List<string>();

        //List to hold mobile phones of subscribers
        List<string> mobileList = new List<string>();
       
        public ManagerForm()
        {
            InitializeComponent();
        }

        //Event handler for click event of exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Application.Exit();
        }

        private void subscriptionButton_Click(object sender, EventArgs e)
        {
            SubscribeForm subscribeForm = new SubscribeForm();
            subscribeForm.Show();
            this.Hide();
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            PublishForm publishForm = new PublishForm();
            publishForm.Show();
            filterLists();
            publishForm.getLists(emailList, mobileList);
        }

        public void filterLists()
        {
            emailList = emailList.Distinct().ToList();
            mobileList = mobileList.Distinct().ToList();
        }
        public void addToEmailList(string email)
        {
            emailList.Add(email);
        }

        public void addToMobileList(string mobile)
        {
            mobileList.Add(mobile);
        }

        public void removeFromEmailList(string email)
        {
            emailList.Remove(email);
        }

        public void removeFromMobileList(string mobile)
        {
            mobileList.Remove(mobile);
        }
    }
}

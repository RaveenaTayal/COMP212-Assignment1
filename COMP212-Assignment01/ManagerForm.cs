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
        public static List<string> emailList = new List<string>();

        //List to hold mobile phones of subscribers
        public static List<string> mobileList = new List<string>();
       
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
            emailList.Clear();
            mobileList.Clear();
            SubscribeForm subForm = new SubscribeForm();
            subForm.Show();
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            filterLists();
            PublishForm pubForm = new PublishForm();
            pubForm.Show();
            
        }

        public void filterLists()
        {
            emailList = emailList.Distinct().ToList();
            mobileList = mobileList.Distinct().ToList();
        }
    }
}

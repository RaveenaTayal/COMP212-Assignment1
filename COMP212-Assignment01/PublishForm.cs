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
    public partial class PublishForm : Form
    {

        //List to hold email addresses of subscribers
        List<string> emailList = new List<string>();

        //List to hold mobile phones of subscribers
        List<string> mobileList = new List<string>();

        //Declare Delegate
        public delegate void PublishMessageDel();

        //Declare an instance variable which is a Delegate object 
        public static event PublishMessageDel publishmsg=null;
       
        public PublishForm()
        {
            InitializeComponent();
            populateLists();
        }

        public void populateLists()
        {
            this.emailList = ManagerForm.emailList;
            this.mobileList = ManagerForm.mobileList;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            string text="";
            message = message.Trim();
            if(message=="")
            {
                MessageBox.Show("Please enter a message to publish!!!");
            }
            else
            {
                PublishMessage();
                text += "The message \"" + message + "\" has been sent to following: \n";
                text += "Email addresses: \n";
                foreach(var email in emailList)
                {
                    text += email + "\n";
                }
                text += "Mobile numbers: \n";
                foreach (var mobile in mobileList)
                {
                    text += mobile + "\n";
                }
                MessageBox.Show(text);
            }
        }

        public void PublishMessage()
        {
            //Invoke Delegate
            publishmsg.Invoke();
        }
    }
}

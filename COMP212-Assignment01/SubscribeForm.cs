using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace COMP212_Assignment01
{
    public partial class SubscribeForm : Form
    {
        static string email="", mobile="";
        static bool emailChecked = false, mobileChecked = false;
        static bool isValidEmail = false, isValidMobile = false;

        ManagerForm managerForm = new ManagerForm();

        private delegate void DelSendInfo(string info);
        DelSendInfo sendInfoDel= null;

        public SubscribeForm()
        {
            InitializeComponent();
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enable email textbox only if the email checkbox is checked
            emailTextBox.Enabled = emailChecked=(emailCheckBox.Checked) ? true : false;

        }

        private void mobileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enable mobile textbox only if the mobile checkbox is checked
            mobileTextBox.Enabled = mobileChecked=(mobileCheckBox.Checked) ? true : false;
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            string message="";
            sendEmailMobile("Subscription");
            if (emailChecked && mobileChecked) 
            {
                if(isValidEmail&&isValidMobile)
                {                   
                    sendInfoDel = managerForm.addToEmailList;
                    sendInfoDel(email);
                    sendInfoDel = managerForm.addToMobileList;
                    sendInfoDel(mobile);
                    message="Subscription successful!!!";
                }
                else
                {
                    message="Please check your mobile/ email address";
                }

            }
            else if(emailChecked && !mobileChecked)
            {
                if(isValidEmail)
                {
                    message = "Subscription successful!!!";
                    sendInfoDel = managerForm.addToEmailList;
                    sendInfoDel(email);
                }
                else
                {
                    message="Please check your email address";
                }
            }
            else if(mobileChecked && !emailChecked)
            {
                if (isValidMobile)
                {
                    message = "Subscription successful!!!";
                    sendInfoDel = managerForm.addToMobileList;
                    sendInfoDel(mobile);
                }
                else
                {
                    message="Please check your mobile number";
                }
            }
            else
            {
                message="Please check your mobile/ email address";
            }
            MessageBox.Show(message);
        }

        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            sendEmailMobile("Unsubscription");
            if (emailChecked && mobileChecked)
            {
                if (isValidEmail && isValidMobile)
                {
                    MessageBox.Show("Unsubscription successful!!!");
                    sendInfoDel = managerForm.removeFromEmailList;
                    sendInfoDel(email);
                    sendInfoDel = managerForm.removeFromMobileList;
                    sendInfoDel(mobile);
                }
                else
                {
                    MessageBox.Show("Please check your mobile/ email address");
                }

            }
            else if (emailChecked && !mobileChecked)
            {
                if (isValidEmail)
                {
                    sendInfoDel = managerForm.removeFromEmailList;
                    sendInfoDel(email);
                }
                else
                {
                    MessageBox.Show("Please check your email address");
                }
            }
            else if (mobileChecked && !emailChecked)
            {
                if (isValidMobile)
                {
                    sendInfoDel = managerForm.removeFromMobileList;
                    sendInfoDel(mobile);
                }
                else
                {
                    MessageBox.Show("Please check your mobile number");
                }
            }
            else
            {
                MessageBox.Show("Please check your mobile/ email address");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            managerForm.Show();

        }

        private void sendEmailMobile(string subscribe)
        {            
            if (emailChecked)
            {
                email = emailTextBox.Text;
                isValidEmail = validateEmail(email);
            }
            if (mobileChecked)
            {
                mobile = mobileTextBox.Text;
                isValidMobile = validateMobile(mobile);
            }
            if(!emailChecked && !mobileChecked)
            {
                MessageBox.Show("Enter atleast an email or mobile number for " + subscribe);
            }
        }

        private bool validateEmail(string email)
        {

            string pattern=@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if(Regex.IsMatch(email,pattern,RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        private bool validateMobile(string mobile)
        {
            string pattern=@"(\d{3}[-]){2}\d{4}";
            if(Regex.IsMatch(mobile,pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

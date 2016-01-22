using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_Assignment01
{
    class SendViaEmail
    {
        private String emailAddr;
        PublishForm publishForm = new PublishForm();

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        public void addToEmailList(string email)
        {
           
        }

        public void removeFromEmailList(string email)
        {

        }
        public void Subscribe(PublishForm pubForm)
        {
             //pubForm.publishmsg += sendEmail;
            publishForm = pubForm;
        }

        public void Unsubscribe(PublishForm pubForm)
        {
            //pubForm.publishmsg+=
        }
    }
}

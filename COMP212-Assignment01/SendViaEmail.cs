using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment01
{
    class SendViaEmail
    {
        private String email;
        PublishForm publishForm = new PublishForm();

        public SendViaEmail() { }

        public SendViaEmail(String email)
        {
            this.email = email;
        }

        public void setEmailAddr(String email)
        {
            this.email = email;
        }

        public String getEmailAddr()
        {
            return email;
        }

        public void addToEmailList()
        {
            ManagerForm.emailList.Add(this.email);
            MessageBox.Show(this.email);
        }
        public void removeFromEmailList()
        {
            ManagerForm.emailList.Remove(this.email);
            MessageBox.Show(this.email);
        }

        public void Subscribe(PublishForm pubForm)
        {
            PublishForm.publishmsg += addToEmailList;
        }

        public void Unsubscribe(PublishForm pubForm)
        {
            PublishForm.publishmsg += removeFromEmailList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment01
{
    class SendViaMobile
    {
        private String cellPhone;

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            cellPhone = phone;
        }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        public void addToMobileList()
        {
            ManagerForm.mobileList.Add(this.cellPhone);
            MessageBox.Show(this.cellPhone);
        }
        public void removeFromMobileList()
        {
            ManagerForm.emailList.Remove(this.cellPhone);
            MessageBox.Show(this.cellPhone);
        }

        public void Subscribe(PublishForm pubForm)
        {
            PublishForm.publishmsg += addToMobileList;
        }

        public void Unsubscribe(PublishForm pubForm)
        {
            PublishForm.publishmsg += removeFromMobileList;
        }
    }
}

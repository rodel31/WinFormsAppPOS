using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppPOS
{
    public class Util
    {
        private string userName = "noLoad";
        public string getUserName()
        {
            return userName;
        }
        public void setUserName(string _userName)
        {
            this.userName = _userName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.dto
{
    public class Phone
    {
        private string phoneNumber;
        private string ext;
        private string phonetype;

        public Phone(string phoneNumber,string ext,string phoneType)
        {
            this.phoneNumber = phoneNumber;
            this.ext = ext;
            this.phonetype = phoneType;
        }

        public override string ToString()
        {
            return $"Phone(phoneNumber={phoneNumber}, ext={ext} , phoneType={phonetype})";
        }
    }
}

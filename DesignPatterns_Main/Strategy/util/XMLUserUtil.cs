using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Strategy.util
{
    public class XMLUserUtil
    {
        public static string getRolByPrincipal(string user, string pwd)
        {

            XmlTextReader reader = new XmlTextReader("Usersfile.xml");

            XmlDocument doc = new XmlDocument();
            XmlNode node = doc.ReadNode(reader);

            foreach (XmlNode chldNode in node.ChildNodes)
            {

                if (chldNode.Attributes["userName"].Value.Equals(user) &&
                    chldNode.Attributes["password"].Value.Equals(pwd))
                {
                    return chldNode.Attributes["rol"].Value;
                }
            }
            return null;
        }
    }
}

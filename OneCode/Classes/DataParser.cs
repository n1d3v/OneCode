// A simple parser and reader for a custom XML file created by the app
// This is used to store the data for authentication codes.
using System.Collections.Generic;
using System.Xml;

namespace OneCode.Classes
{
    public class AccountData
    {
        public string Issuer { get; set; }
        public string Secret { get; set; }
        public string Name { get; set; }
    }

    public class DataParser
    {
        public static List<AccountData> ParseXml(string xmlString)
        {
            var accounts = new List<AccountData>();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);

            XmlNodeList nodes = doc.GetElementsByTagName("account");
            foreach (XmlNode node in nodes)
            {
                var account = new AccountData();

                XmlNode issuerNode = node.SelectSingleNode("issuer");
                if (issuerNode != null)
                    account.Issuer = issuerNode.InnerText;

                XmlNode codeNode = node.SelectSingleNode("secret");
                if (codeNode != null)
                    account.Secret = codeNode.InnerText;

                XmlNode nameNode = node.SelectSingleNode("name");
                if (nameNode != null)
                    account.Name = nameNode.InnerText;

                accounts.Add(account);
            }

            return accounts;
        }

        public static string CreateXml(List<AccountData> accounts)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement root = doc.CreateElement("accounts");
            doc.AppendChild(root);

            foreach (var acc in accounts)
            {
                XmlElement accountElem = doc.CreateElement("account");

                XmlElement issuerElem = doc.CreateElement("issuer");
                issuerElem.InnerText = acc.Issuer ?? "";
                accountElem.AppendChild(issuerElem);

                XmlElement codeElem = doc.CreateElement("secret");
                codeElem.InnerText = acc.Secret ?? "";
                accountElem.AppendChild(codeElem);

                XmlElement nameElem = doc.CreateElement("name");
                nameElem.InnerText = acc.Name ?? "";
                accountElem.AppendChild(nameElem);

                root.AppendChild(accountElem);
            }

            return doc.OuterXml;
        }
    }
}
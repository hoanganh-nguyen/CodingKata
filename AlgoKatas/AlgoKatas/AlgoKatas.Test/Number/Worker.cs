using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using FluentAssertions;
using FluentAssertions.Xml;
using NUnit.Framework;

namespace AlgoKatas.Number
{
    public class Trojan
    {
        public int CountCompromised(string xml, string infectedFileId)
        {

            List<string> compromisedList = new List<string>();
            XDocument doc = XDocument.Parse(xml);
            var list = doc.Descendants("file").Where(x=>x.Attribute("fileId").Value.Equals(infectedFileId));
            foreach (var element in list)
            {
                foreach (var fileElement in element.Parent.Elements())
                {
                    var att = fileElement.Attribute("fileId");
                    if(att== null)
                        continue;

                    var fileId = att.Value;
                    if (!System.String.IsNullOrEmpty(fileId) && !compromisedList.Contains(fileId) && !fileId.Equals(infectedFileId))
                    {
                        compromisedList.Add(fileId);
                    }
                }
             
            }

            return compromisedList.Count;
        }
    }

    [TestFixture]
    public class TrojanTest
    {
        [Test]
        public void Main()
        {
            Trojan trojan = new Trojan();
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<root>" +
                "   <snapshot>" +
                "      <folder>" +
                "         <file fileId=\"1\"/>" +
                "         <file fileId=\"2\"/>" +
                "         <folder>" +
                "            <file fileId=\"3\"/>" +
                "            <file fileId=\"4\"/>" +
                "         </folder>" +
                "      </folder>" +
                "   </snapshot>" +
                "   <snapshot>" +
                "      <file fileId=\"1\"/>" +
                "      <file fileId=\"3\"/>" +
                "      <folder>" +
                "         <file fileId=\"2\"/>" +
                "         <file fileId=\"4\"/>" +
                "         <folder>" +
                "            <file fileId=\"3\"/>" +
                "            <file fileId=\"4\"/>" +
                "         </folder>" +
                "      </folder>" +
                "   </snapshot>" +
                "</root>";

            trojan.CountCompromised(xml, "3").Should().Be(2);
        }
    }
}
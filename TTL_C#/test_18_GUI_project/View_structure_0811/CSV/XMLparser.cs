using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace View_structure_0811.Adapter
{
    class XMLparser
    {
        public static void wirteXML()
        {
            XmlDocument data = new XmlDocument(); // xml파일 생성
            data.LoadXml("<Customers></Customer>"); // 첫번쨰 태그 생성(상위)

            XmlElement newElem = data.CreateElement("Customer"); // Customers 내 customer 요소 생성
            XmlAttribute newAttr = data.CreateAttribute("Number"); // Customers 내 customer 내 Numver 요소 생성
            newAttr.Value = "1";
            newElem.Attributes.Append(newAttr);

            newAttr.OwnerDocument.CreateAttribute("Name"); // Customers 내 customer 내 Name 요소 생성
            newAttr.Value = "홍길동";
            newElem.Attributes.Append(newAttr);
            data.DocumentElement.AppendChild(newElem);

            XmlElement subNode = data.CreateElement("Info");
            XmlElement info = data.CreateElement("전화");
            info.InnerText = "01012345677";
            subNode.AppendChild(info);

            info = data.CreateElement("주소");
            info.InnerText = "대구시 동구 신천4동";
            subNode.AppendChild(info);

            info = data.CreateElement("날짜");
            info.InnerText = "2021-08-12";
            subNode.AppendChild(info);

            info = data.CreateElement("생일");
            info.InnerText = "1980-06-24";
            subNode.AppendChild(info);

            info = data.CreateElement("성별");
            info.InnerText = "남자";
            subNode.AppendChild(info);

            //////////////////////////////////////////////////////////
            info = data.CreateElement("Hobby");
            XmlElement hobby = data.CreateElement("취미");
            hobby.InnerText = "놀고먹기";
            info.AppendChild(hobby);

            hobby = data.CreateElement("성별");
            hobby.InnerText = "잠자기";
            info.AppendChild(hobby);

            hobby = data.CreateElement("성별");
            hobby.InnerText = "가만히 있기";
            info.AppendChild(hobby);
            /////////////////////////////////////////////////////////////


            subNode.AppendChild(info);
            newElem.AppendChild(subNode);

            using (XmlTextWriter writer = new XmlTextWriter(@"C:\\c#_work\\test_18_GUI_project\\test.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                data.Save(writer);
            }
        }

        public static void writeXML_customer(string name, string member_digit, string digit, string addr, string gender, string date, List<string> serial_num)
        {
            int index = 1;
            XmlDocument data = new XmlDocument();
            data.LoadXml("<Customers></Cusotmers>");

            XmlElement newElement = data.CreateElement("Customer");
            XmlAttribute newAttribute = data.CreateAttribute("Number");
            newAttribute.Value = index.ToString();

            newAttribute.OwnerDocument.CreateAttribute("Memeber_digit");
            newAttribute.Value = member_digit;
            newElement.Attributes.Append(newAttribute);
            data.DocumentElement.AppendChild(newElement);

            XmlElement subNode = data.CreateElement("Info");
            XmlElement info = data.CreateElement("이름");
            info.InnerText = name;
            subNode.AppendChild(info);

            info = data.CreateElement("전화번호");
            info.InnerText = digit;
            subNode.AppendChild(info);

            info = data.CreateElement("주소");
            info.InnerText = addr;
            subNode.AppendChild(info);

            info = data.CreateElement("성별");
            info.InnerText = "남자";
            subNode.AppendChild(info);

            info = data.CreateElement("가입날짜");
            info.InnerText = date;
            subNode.AppendChild(info);


            info = data.CreateElement("Serial_number");
            XmlElement serial_list = data.CreateElement("구입물품 시리얼 넘버");
            serial_list.InnerText = serial_num[0];
            info.AppendChild(serial_list);

            for (int serial_index = 1; serial_index < serial_num.Count; serial_index++)
            {
                serial_list = data.CreateElement("구입물품 시리얼 넘버");
                serial_list.InnerText = serial_num[serial_index];
                info.AppendChild(serial_list);
            }

            subNode.AppendChild(info);
            newElement.AppendChild(subNode);



            using (XmlTextWriter writer = new XmlTextWriter(@"C:\\c#_work\\test_18_GUI_project\\test.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                data.Save(writer);
            }

            index++;
        }

        public static void wirteXML_person_info()
        {

        }

        public static void readXML_customer()
        {
            XmlDocument data = new XmlDocument();
            data.Load(@"C:\\c#_work\\test_18_GUI_project\\test.xml");
            XmlNodeList customer_nodes = data.SelectNodes("Customers/Customers");

            foreach (XmlElement customer_nodes_ele in customer_nodes)
            {
                Console.WriteLine("번호 : {0}", customer_nodes_ele.Attributes["Number"].Value);
                Console.WriteLine("고객번호 : {0}", customer_nodes_ele.Attributes["Memeber_digit"].Value);

                foreach (XmlElement info_nodes_ele in customer_nodes_ele.ChildNodes)
                {
                    Console.WriteLine("이름 : {0}", info_nodes_ele["이름"].InnerText);
                    Console.WriteLine("전화번호 : {0}", info_nodes_ele["전화번호"].InnerText);
                    Console.WriteLine("주소 : {0}", info_nodes_ele["주소"].InnerText);
                    Console.WriteLine("성별 : {0}", info_nodes_ele["성별"].InnerText);
                    Console.WriteLine("가입날짜 : {0}", info_nodes_ele["가입날짜"].InnerText);

                    // 노드 제거
                    /*if (info_nodes_ele["성별"].Name == "성별")
                    {
                        info_nodes_ele.RemoveChild(info_nodes_ele["성별"]);
                    }

                    // 노드 내 값 변경
                    if (info_nodes_ele["성별"].Name == "성별")
                    {
                        info_nodes_ele["성별"].InnerText = "여";
                    }*/

                    foreach (XmlElement serial_nodes_ele in info_nodes_ele)
                    {
                        Console.WriteLine("구매품목 관리번호 : {0}", serial_nodes_ele["구입물품 시리얼 넘버"].InnerText);
                    }
                }
           
                #region
                if (customer_nodes_ele.Attributes["Name"].Value == "홀길동")
                {
                    XmlNode delNode = data.SelectSingleNode("Customer/Customer");
                    XmlNode parantNode = delNode.ParentNode;
                    parantNode.RemoveChild(delNode);
                }
                #endregion // 삭제
            }



            data.Save(@"C:\\c#_work\\test_18_GUI_project\\test.xml");
        }
    }
}

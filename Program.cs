using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            Console.WriteLine("Введите Ф.И.О");
            person.FIO = Console.ReadLine();
            Console.WriteLine("Ведите номер мобильного телефона");
            person.MobilePhone = Console.ReadLine();
            Console.WriteLine("Введите городской номер телефона");
            person.FlatPhone = Console.ReadLine();
            Console.WriteLine("Введите название улицы");
            person.Street = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            person.HouseNumber = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры");
            person.FlatNumber = Console.ReadLine();


            XElement xPERSON = new XElement("Person");
            XElement xADDRESS = new XElement("Address");
            XElement xULICA = new XElement("Ulica");
            XElement xDOM = new XElement("Dom");
            XElement xKVART = new XElement("Kvart");
            XElement xPHONES = new XElement("Phones");
            XElement xMOBILN = new XElement("Mobiln");
            XElement xDOMASHN = new XElement("Domashn");

            XAttribute xAtPerson = new XAttribute("Ф.И.О", person.FIO);

            XAttribute xMobilePhone = new XAttribute("Мобильный", person.MobilePhone);
            XAttribute xFlatPhone = new XAttribute("Домашний", person.FlatPhone);
            xMOBILN.Add(xMobilePhone);
            xDOMASHN.Add(xFlatPhone);

            XAttribute xAtUlica = new XAttribute("Улица", person.Street);
            XAttribute xAtDom = new XAttribute("Номер_дома", person.HouseNumber);
            XAttribute xAtKvartira = new XAttribute("Номер_квартиры", person.FlatNumber);
            xULICA.Add(xAtUlica);
            xDOM.Add(xAtDom);
            xKVART.Add(xAtKvartira);


            xPERSON.Add(xADDRESS, xPHONES, xAtPerson);
            xADDRESS.Add(xULICA, xDOM, xKVART);
            xPHONES.Add(xMOBILN, xDOMASHN);



            xPERSON.Save("_Person.xml");

            List<XElement> PERSONS_List = new List<XElement>(3);
            PERSONS_List.Add(xPERSON);
            xPERSON.Save("_Person.xml");
                                                
            Console.ReadKey();

        }
    }
}

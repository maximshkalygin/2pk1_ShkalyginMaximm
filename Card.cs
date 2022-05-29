using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shkalygin
{
    internal class Card
    {
        static int ExpaierdCards = 0;
        static  int Count = 0;
        private int number;
        private string clientFIO;
        private DateTime validity;
        private int secureCode;
        private string type;
        public int Number { get { return number; } set {if (value.ToString().Length==20) number = value; } } 
        public string ClientFIO { get { return clientFIO; } set {if (!string.IsNullOrEmpty(value)) clientFIO = value; } }
        public DateTime Validity { get => validity; set {
                if (value >= DateTime.Parse("01.01.2022") && value <= DateTime.Parse(".01.01.2026")) 
                {
                    validity = value; 
                    if (value.Date==DateTime.Now.Date)
                        ExpaierdCards++;
                } 
            }
        }
        public int SecureCode { get => secureCode; set { if (value.ToString().Length==3) secureCode = value; } }
        public string Type { get => type; set {if (!string.IsNullOrEmpty(value)) type = value; } }

        public string GetInfo()
        {
            string info = $"Ваш номер карты {number}, Ваше ФИО {clientFIO},Срок действия {Validity}, Код безопасности {SecureCode},Карта {Type}";
            return info;
        }
        public static int getCount()
        {
            return Count;
        }
        public static int getExpaierdCards()
        {
            return ExpaierdCards;
        }
        public Card() 
        {
            Count++;
        }
        public Card(string FIO):this()
        {
            clientFIO = FIO;

        }
        public Card(string FIO, int number):this()
        {
            this.number = number;
            clientFIO = FIO;
        }
        public Card(int secureCode, string type = "visa"):this()
        {
            this.SecureCode = secureCode;
            this.Type = type;
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class String
        {
           public string text;

            public String(string str)
            {
                text = str;
            }
            public int L()
            {
                  return text.Length;
            }

            public void toUpper()
            {
                text.ToUpper();
            }
            public void toLower()
            {
                text.ToLower();
            }
        }

        class StringTwo : String
        {

            public StringTwo(string text2) : base(text2)
            {
                foreach(char c in text)
                {
                    if(c!= '0' && c != '1')
                    {
                        text = null;
                        break;
                    }
                    text = text2;                     
                 }
            }          

            public bool IsPolyndrom()
            {
                char[] chars= this.text.ToCharArray();
                Array.Reverse(chars);
                string ReversString = new string(chars);
                return text == ReversString;
            }

            public string TakeReversString()
            {
                char[] chars = text.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
            public string ToDes()
            {
                int decimalNumber = 0;
                int power = 0;
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    int bit = text[i] - '0';
                    decimalNumber += bit * (int)Math.Pow(2, power);
                    power++;
                }
                return decimalNumber.ToString();
            }
        }

        class DesString : String
        {

            public DesString(string text2) : base(text2)
            {
                string pattern = @"^-?\d+(\.\d+)?$";
                if(Regex.IsMatch(text2, pattern) == true)
                    {
                    text = text2;   
                }


            }

            public string print()
            {
                return "\nВывод строки: " + text;
            }

            public int takePointIndex()
            {
                return text.IndexOf('.');
            }

            public bool ContentPoint()
            {
                return text.Contains(".");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Загрузка файла XML
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Univers\\visprog\\LAB3\\file.xml");

            // Получение списка объектов из файла
            XmlNodeList objectList = xmlDoc.SelectNodes("//object");

            // Создание списка объектов и выполнение операций
            List<String> objects = new List<String>();

            foreach (XmlNode objectNode in objectList)
            {
                    string type = objectNode.SelectSingleNode("type").InnerText;
                    string value = objectNode.SelectSingleNode("value").InnerText;
                    XmlNodeList methodList = objectNode.SelectNodes("methods/method");
                    tb1.AppendText("Значение: " + value + Environment.NewLine);
                    switch (type)
                    {
                        case "Строка":
                            String str = new String(value);
                            objects.Add(str);
                             
                            foreach (XmlNode methodNode in methodList)
                            {
                                string methodName = methodNode.InnerText;
                         
                            switch (methodName)
                                {
                                    case "Длина":
                                    tb1.AppendText("Длина строки: " + str.L() + Environment.NewLine);
                                        break;
                                    case "Увеличить регистр":
                                    str.toUpper();
                                    tb1.AppendText("Строка с увеличенным регистром: " + str.text + Environment.NewLine);
                                        break;
                                    case "Уменьшить регистр":
                                    str.toLower();
                                    tb1.AppendText("Строка с уменьшенном регистром: " + str.text + Environment.NewLine);
                                        break;
                                    default:
                                    tb1.AppendText(methodName+" недопустимый метод для класса Строка!" + Environment.NewLine);
                                        break;
                                }
                            }

                            break;

                        case "Двоичная строка":
                        StringTwo binaryStr = new StringTwo(value);
                            objects.Add(binaryStr);

                            foreach (XmlNode methodNode in methodList)
                            {
                                string methodName = methodNode.InnerText;

                                switch (methodName)
                                {
                                    case "Это полидром?":

                                    tb1.AppendText("Строка - полидром: " + binaryStr.IsPolyndrom() + Environment.NewLine);
                                        break;
                                    case "Обратная строка":
                                    tb1.AppendText("Обратная строка: " + binaryStr.TakeReversString() + Environment.NewLine);
                                        break;
                                    case "Перевести в десятичную":
                                    tb1.AppendText("Перевод в десятичную: " + binaryStr.ToDes() + Environment.NewLine);
                                        break;
                                    default:
                                    tb1.AppendText(methodName +" недопустимый метод для класса Двоичная строка!" + Environment.NewLine);                                 
                                    break;
                                }
                            }
                            break;

                        case "Десятичная строка":
                        DesString decimalStr = new DesString(value);
                            objects.Add(decimalStr);

                            foreach (XmlNode methodNode in methodList)
                            {
                                string methodName = methodNode.InnerText;

                                switch (methodName)
                                {
                                    case "Вывод значения":
                                    tb1.AppendText(decimalStr.print() + Environment.NewLine);
                                        break;
                                    case "Индекс точки":
                                    tb1.AppendText("Индекс точки в строке: " + decimalStr.takePointIndex() + Environment.NewLine);
                                        break;
                                    case "Содержание точки":
                                    tb1.AppendText("Результат сравнения десятичных строк: " + decimalStr.ContentPoint() + Environment.NewLine);
                                        break;
                                    default:
                                    tb1.AppendText(methodName+" недопустимый метод для класса Десятичная строка!"+ Environment.NewLine);
                                        break;
                                }
                            }

                            break;

                        default:
                        tb1.AppendText("Недопустимый тип объекта!" + Environment.NewLine);
                            break;
                    
                }
            }

        }
    }
}

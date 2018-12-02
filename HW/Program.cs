using System;

namespace HW
{
    public class Program
    {
        static void ShowSeason(int monthNumber)
        {
            if (monthNumber >= 3 && monthNumber <= 5)
            {
                Console.WriteLine("Spring");
            }
        }

        public static void Main(string[] args)
        {
            // Test
            var xml = XmlHelper.CreateXml(@"Data\XmlTestFile.xml");
            var node = XmlHelper.GetNodeByTagName("Node1", xml);
            var nodeText = XmlHelper.GetNodeText("Node2");
            Console.WriteLine(nodeText);
              
            Console.ReadKey();

            int a = 8;
        }
    }
}

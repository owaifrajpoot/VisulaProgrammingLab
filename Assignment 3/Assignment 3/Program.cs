using System;
using System.IO;
using System.Xml;

namespace XMLWriterReaderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "GPS_Log.xml";
            CreateXmlFile(filePath);
            Console.WriteLine("\nReading and displaying the XML file:\n");
            ReadAndDisplayXmlFile(filePath);
        }

        static void CreateXmlFile(string filePath)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("GPS_Log");
                writer.WriteStartElement("Position");
                writer.WriteAttributeString("DateTime", "1/26/2017 5:08:59 PM");
                writer.WriteElementString("x", "65.8973342");
                writer.WriteElementString("y", "72.3452346");
                writer.WriteStartElement("SatteliteInfo");
                writer.WriteElementString("Speed", "40");
                writer.WriteElementString("NoSatt", "7");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteStartElement("Image");
                writer.WriteAttributeString("Resolution", "1024x800");
                writer.WriteElementString("Path", @"\images\1.jpg");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            Console.WriteLine($"XML file '{filePath}' has been created successfully.");
        }

        static void ReadAndDisplayXmlFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The XML file does not exist.");
                return;
            }

            using (XmlReader reader = XmlReader.Create(filePath))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.Write($"<{reader.Name}");
                            if (reader.HasAttributes)
                            {
                                while (reader.MoveToNextAttribute())
                                {
                                    Console.Write($" {reader.Name}=\"{reader.Value}\"");
                                }
                                reader.MoveToElement();
                            }
                            Console.Write(">");
                            break;

                        case XmlNodeType.Text:
                            Console.Write(reader.Value);
                            break;

                        case XmlNodeType.EndElement:
                            Console.Write($"</{reader.Name}>");
                            break;
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

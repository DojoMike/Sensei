using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace Sensei
{
    class Settings
    {
        /// <summary>
        /// Reads data from the settings file
        /// </summary>
        /// <param name="voice">The voice</param>
        /// <param name="rate">The rate</param>
        /// <param name="volume">The volume</param>
        public static void Read(out string voice, out decimal rate, out decimal volume)
        {
            // If the file doesn't exist, leave everything with its default settings
            if (!File.Exists("settings.xml"))
            {
                voice = "";
                rate = 0;
                volume = 100;
                return;
            }

            // Jump through some LINQ hoops
            var xd = XDocument.Load("settings.xml");
            var data = from e in xd.Descendants("speaker")
                       select new
                       {
                           Voice = e.Element("voice").Value,
                           Rate = Convert.ToDecimal(e.Element("rate").Value),
                           Volume = Convert.ToDecimal(e.Element("volume").Value)
                       };

            // The code above apparently returns an IEnumerable interface,
            // which apparently can be looped through using a foreach loop,
            // so even though there's only one item, we need to do:
            voice = "not set yet";
            rate = 0;
            volume = 0;
            foreach (var d in data)
            {
                voice = d.Voice.ToString();
                rate = d.Rate;
                volume = d.Volume;
            }
        }

        /// <summary>
        /// Saves the voice settings to a file
        /// </summary>
        /// <param name="voice">The voice</param>
        /// <param name="rate">The rate</param>
        /// <param name="volume">The volume</param>
        public static void Save(string voice, decimal rate, decimal volume)
        {
            // Create an "XDocument" object with all the data
            var xd = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("speaker",
                    new XElement("voice", voice),
                    new XElement("rate", rate),
                    new XElement("volume", volume)
                )
            );

            // Now write the data to the file
            xd.Save("settings.xml");
        }
    }
}

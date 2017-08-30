using System.Collections.Generic;
using SpeechLib;

namespace Sensei
{
    class Speaker
    {
        private static SpVoice sapi = new SpVoice();
        
        /// <summary>
        /// Uses Microsoft Speech API ("SAPI") to speak a string of text
        /// </summary>
        /// <param name="text">The text to speak</param>
        public static void Say(string text)
        {
            sapi.Speak(text);
        }

        /// <summary>
        /// Gets the list of installed voices
        /// </summary>
        /// <returns>The list of voices</returns>
        public static string[] GetVoices()
        {
            var data = new List<string>();
            var voices = sapi.GetVoices();
            for (int i=0; i<voices.Count; i++)
                data.Add(voices.Item(i).GetDescription());
            return data.ToArray();
        }

        /// <summary>
        /// Volume (0 to 100)
        /// </summary>
        public static int Volume
        {
            get
            {
                return sapi.Volume;
            }
            set
            {
                sapi.Volume = value;
            }
        }

        /// <summary>
        /// Rate (-10 to 10, 10 being the fastest)
        /// </summary>
        public static int Rate
        {
            get
            {
                return sapi.Rate;
            }
            set
            {
                sapi.Rate = value;
            }
        }

        /// <summary>
        /// Sets the voice to use when speaking
        /// </summary>
        /// <param name="voice">The "name" of the voice (Zira, David etc.)</param>
        public static void SetVoice(string voice)
        {
            var voices = sapi.GetVoices();
            for (int i = 0; i < voices.Count; i++)
                if (voices.Item(i).GetDescription().Equals(voice))
                {
                    sapi.Voice = voices.Item(i);
                    return;
                }
        }
    }
}

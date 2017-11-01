using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Speech.Synthesis;

namespace AI
{
    class Tts
    {
        public static SpeechSynthesizer Ss = new SpeechSynthesizer();
        public static List<string> voices = new List<string>();
        public static void TextToSpeech()
        {
            Ss.Volume = 100;
            Ss.Rate = 1;
            int i = 1;
            Console.WriteLine("Installed TTS voices\r\n");

            

            foreach( InstalledVoice voice in Ss.GetInstalledVoices())
            {
                Console.WriteLine(i + ".)\t" + voice.VoiceInfo.Name);
                voices.Add(voice.VoiceInfo.Name);
                i++;
            }
            int voicenumber = Input();
            Ss.SelectVoice(voices[voicenumber]);
            Console.ReadKey();
        }
        public static void Speech(string i)
        {
            Ss.SpeakAsyncCancelAll();
            Ss.SpeakAsync(i);
        }
        public static void Speechsync(string i)
        {
            Ss.Speak(i);
        }

        public static int Input()
        {
            int i = 0;
            switch (Console.ReadKey().Key.ToString())
            {
                case "NumPad1":
                case "D1":
                    {
                        i = 0;
                        break;
                    }
                case "NumPad2":
                case "D2":
                    {
                        i = 1;
                        break;
                    }
                case "NumPad3":
                case "D3":
                    {
                        i = 2;
                        break;
                    }
            }
            return i;
        }
    }
}

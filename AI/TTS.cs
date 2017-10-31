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
    class TTS
    {
        public static SpeechSynthesizer _ss = new SpeechSynthesizer();
        //public static List<string> voices;
        public static void TextToSpeech()
        {
            _ss.Volume = 100;
            _ss.Rate = 1;
            int i = 1;
            Console.WriteLine("Installed TTS voices\r\n");

            

            foreach( object obj in _ss.GetInstalledVoices())
            {
                InstalledVoice voice = (InstalledVoice) obj;
                Console.WriteLine(i + ".)\t" + voice.VoiceInfo.Name);
                //voices.Add(voice.VoiceInfo.Name);
                i++;
            }
            //int voicenumber = input();
            //_ss.SelectVoice(voices[voicenumber]);
            Console.ReadKey();
        }
        public static void speech(string i)
        {
            _ss.SpeakAsyncCancelAll();
            _ss.SpeakAsync(i);
        }
        public static void speechsync(string i)
        {
            _ss.Speak(i);
        }

        public static int input()
        {
            int i = 0;
            switch (Console.ReadKey().Key.ToString())
            {
                case "NumPad1":
                case "D1":
                    {
                        i = 1;
                        break;
                    }
                case "NumPad2":
                case "D2":
                    {
                        i = 2;
                        break;
                    }
                case "NumPad3":
                case "D3":
                    {
                        i = 3;
                        break;
                    }
                case "NumPad4":
                case "D4":
                    {
                        i = 4;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return i;
        }
    }
}

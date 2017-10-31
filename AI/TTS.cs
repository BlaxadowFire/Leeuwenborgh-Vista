using System;
using System.Speech.Synthesis;

namespace AI
{
    class Tts
    {
        public static SpeechSynthesizer Ss = new SpeechSynthesizer();
        //public static List<string> voices;
        public static void TextToSpeech()
        {
            Ss.Volume = 100;
            Ss.Rate = 1;
            int i = 1;
            Console.WriteLine("Installed TTS voices\r\n");

            

            foreach( InstalledVoice voice in Ss.GetInstalledVoices())
            {
                Console.WriteLine(i + ".)\t" + voice.VoiceInfo.Name);
                //voices.Add(voice.VoiceInfo.Name);
                i++;
            }
            //int voicenumber = input();
            //_ss.SelectVoice(voices[voicenumber]);
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
            }
            return i;
        }
    }
}

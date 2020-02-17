using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayingChuckNorrisJokes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Your awesome web site is starting!!");
        }
    }
}

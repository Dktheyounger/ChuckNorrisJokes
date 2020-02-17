using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DemoApi;

namespace DemoApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApiHelper.InitializeClient();

            System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("How many Chuck Norris jokes do you want!");
            Console.WriteLine("How many Chuck Norris jokes do you want!");

            int howManyChuckNorrisJokes = 0;
            howManyChuckNorrisJokes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyChuckNorrisJokes; i++)
            {
                await LoadJokeToScreen();
            }
            
        }

        private static async Task LoadJokeToScreen(int jokeNumber = 0)
        {
            var joke = await JokeProccessor.LoadJoke();

            System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            
            synth.Speak(joke.value.Joke);
            Console.WriteLine(joke.value.Joke);

        }
    }
}

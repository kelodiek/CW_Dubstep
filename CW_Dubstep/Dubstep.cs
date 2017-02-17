using System;

namespace CW_Dubstep
{
    class Dubstep
    {
        static void Main(string[] args)
        {

        }
        public static string SongDecoder(string input)
        {
            string response = "";
            Array.ForEach(input.Replace("WUB", " ").Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), x => { response = response + x + " ";  });
            return response.Trim();
        }
    }
}

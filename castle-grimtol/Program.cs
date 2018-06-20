using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var playing = true;
            Game textGame = new Game();
            textGame.Setup();
            while(playing)
            {
                textGame.Play();
            }
        }
    }
}

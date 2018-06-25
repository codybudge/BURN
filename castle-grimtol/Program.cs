using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game textGame = new Game();
            textGame.Setup();
            while(textGame.Playing)
            {
                textGame.Play();
            }
        }
    }
}

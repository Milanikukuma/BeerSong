using System;

namespace CreateABeerSong
{
    public class BeerSong
    {
        public void SingBeerSong()
        {
            for (int bottles = 99; bottles > 1; bottles--)
            {
                Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
                Console.WriteLine("Take one down and pass it around,");
                if (bottles - 1 > 1)
                {
                    Console.WriteLine($"{bottles - 1} bottles of beer on the wall.\n");
                }
                else if (bottles - 1 == 1)
                {
                    Console.WriteLine($"{bottles - 1} bottle of beer on the wall, {bottles - 1} bottle of beer.\n");
                }
            }
        }
    }
}

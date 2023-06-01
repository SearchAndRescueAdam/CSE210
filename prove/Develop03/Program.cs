using System;

class Program
{
    static void Main(string[] args)
    {

        var Scripture = new Scripture("And it came to pass that I Nephi said unto my father I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them");
        
        Console.Clear();
        
        while (true) {
            
            Scripture.displayWords();

            string exit = Console.ReadLine();

            Console.Clear();

            Scripture.hideWord();

            if (exit == "quit" || Scripture.CheckHidden() ) {
                break;
            }


        }
    }
}

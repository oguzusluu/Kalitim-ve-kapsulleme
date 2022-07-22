namespace Kalıtım


{


    class program
    {


        static void Main(string[]args)
        {
            Oyun oyun=new Oyun();
            oyun.oyunadi = "World Of Warcraft";
            oyun.oyuntürü = "MMORPG";
            oyun.verigoster();
            Console.ReadKey();



        }

    }
}
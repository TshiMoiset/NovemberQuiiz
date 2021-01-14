using System;

namespace NovemberQuiiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar1 = "";
            string svar2 = "";
            string svar3 = "";
            string svar4 = "";
            string svar5 = "";

            string score = "5";         //Hur mycket poäng man får
            int points = int.Parse(score);           //Int.Parse gör om stringen till en int 

            Console.Title = "November Quiiz";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hej och välkommen till min frågesport.\nDu får 2 poängavdrag om du svarar fel på någon fråga.\nÄr du redo?\n\nPS: Svara med Ja eller Nej!");


            while (svar1 != "ja" && svar1 != "nej")           //Man måste svara ja eller nej för att programmet ska fortsätta.
            {
                svar1 = Console.ReadLine().ToLower();        //Låter använderen fylla i med stora bokstäver.

                if (svar1 == "ja")           //Vad som händer om man svara ja.
                {
                    Console.WriteLine("Bra! Vi sätter igång.");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 1: " + score + " poäng");          //Score visar villket värde jag har valt att läga i string score.
                    Question1();           //Konsolen hoppar till rad 337 för att sedan fortsätta från rad 51.
                }

                else if (svar1 == "nej")         //Vad som händer om man svara nej.
                {
                    Console.WriteLine("Mmmm........Vi sätter igång ändå.");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 1: " + score + " poäng");          //Score visar villket värde jag har valt att läga i string score.
                    Question1();           //Konsolen hoppar till rad 337 för att sedan fortsätta från rad 51.
                }
            }

            //Svars alternativen till fråga 1 i quiz:en.

            while (svar1 != "1" && svar1 != "x" && svar1 != "2")
            {
                svar1 = Console.ReadLine().ToLower();

                if (svar1 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    points += 0;         //Konsolen behåller de 5 poängen man redan har. 
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 2: " + score + " poäng");          //Score visar hur mycket poäng jag har valt att stingen ska ge.
                    Question2();
                }

                if (svar1 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 7;         //Konsolen drar bort 7 poäng för att man ska ha -2 då den redan har gett 5 poäng utan att man har svarat. 
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 2: " + score + " poäng");          //Score visar hur mycket poäng jag har valt att stingen ska ge.
                    Question2();
                }

                if (svar1 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 7;          //Konsolen drar bort 7 poäng för att man ska ha -2 då den redan har gett 5 poäng utan att man har svarat. 
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 2: " + score + " poäng");          //Score visar hur mycket poäng jag har valt att stingen ska ge.
                    Question2();
                }
            }

            //Svars alternativen till fråga 2 i quiz:en.

            while (svar2 != "1" && svar2 != "x" && svar2 != "2")
            {
                svar2 = Console.ReadLine().ToLower();

                if (svar2 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;         //Konsolen drar bort 2 poäng om man svara 1. 
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 3: " + score + " poäng");
                    Question3();
                }

                if (svar2 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;          //Konsolen drar bort 2 poäng om man svara x. 
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 3: " + score + " poäng");
                    Question3();
                }

                if (svar2 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    points += 5;          //Konsolen ger 5 poäng om man svara 2. 
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 3: " + score + " poäng");
                    Question3();
                }
            }

            //Svars alternativen till fråga 3 i quiz:en.

            while (svar3 != "1" && svar3 != "x" && svar3 != "2")
            {
                svar3 = Console.ReadLine().ToLower();

                if (svar3 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 4: " + score + " poäng");
                    Question4();

                }

                if (svar3 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    points += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 4: " + score + " poäng");
                    Question4();
                }

                if (svar3 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 4: " + score + " poäng");
                    Question4();
                }
            }

            //Svars alternativen till fråga 4 i quiz:en.

            while (svar4 != "1" && svar4 != "x" && svar4 != "2")
            {
                svar4 = Console.ReadLine().ToLower();

                if (svar4 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 5: " + score + " poäng");
                    Question5();
                }

                if (svar4 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    points += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 5: " + score + " poäng");
                    Question5();
                }

                if (svar4 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 5: " + score + " poäng");
                    Question5();
                }
            }

            //Svars alternativen till fråga 5 i quiz:en.

            while (svar5 != "1" && svar5 != "x" && svar5 != "2")
            {
                svar5 = Console.ReadLine().ToLower();

                if (svar5 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;
                    Console.WriteLine("Dina poäng: ***");
                }

                if (svar5 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    points -= 2;
                    Console.WriteLine("Dina poäng: ***");
                }

                if (svar5 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    points += 5;
                    Console.WriteLine("Dina poäng: ***");
                }
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tryck [ENTER] för att beräkna ditt resultat:)");
            Console.ReadLine();

            if (points < 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Bra försök:/");
                Console.WriteLine("Bättre lycka nästa gång:)");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Resultat: " + points + "/25 Poäng");
            }

            if (points > 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Mycket bra jobbat :)");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Resultat: " + points + "/25 Poäng");
            }

            Console.ReadLine();
        }

        static void Question1()            //Konsolen läser vad som är skriven här
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vem var Nikola Tesla?\n1. Uppfinnare\nX. Fysiker\n2. Astronom\n\nSvara med 1, X ELLER 2");
        }

        static void Question2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"I vilken mytologi existerar Guden [Ares]?\n1. Nordiska mytologin\nX. Mesopotamisk mytologi\n2. Grekiska mytologin");
        }

        static void Question3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mellan vilka år var Napoleon kejsare över Frankrike?\n1. Mellan, 1683 - 1760\nX. Mellan, 1805 - 1814\n2. Mellan, 1765 - 1790");
        }

        static void Question4()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Avsluta låttexten: Feeling my way through the darkness......\n1. When I'm wiser and I'm older\nX. Guided by a beating heart\n2. But I know where to start");
        }

        static void Question5()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vilken låt på youtube har flest visningar mellan dessa 3\n1. Uptown Funk: Mark Ronson ft. Bruno Mars\nX. See You Again: Wiz Khalifa ft. Charlie Puth\n2. Shape Of You: Ed Sheeran");
        }
    }
}

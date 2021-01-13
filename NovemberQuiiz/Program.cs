using System;

namespace NovemberQuiiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            string svar2 = "";
            string svar3 = "";
            string svar4 = "";
            string svar5 = "";
            string svar6 = "";
            string svar7 = "";
            string svar8 = "";
            string svar9 = "";
            string svar10 = "";

            string score = "5";
            int i = int.Parse(score);

            Console.Title = "November Quiiz";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hej och välkommen till min frågesport.");
            Console.WriteLine("Du får 3 poängavdrag om du svarar fel på någon fråga.");
            Console.WriteLine("Är du redo?");
            Console.WriteLine();
            Console.WriteLine("PS: Svara med Ja eller Nej!");


            while (svar != "ja" && svar != "nej")
            {
                svar = Console.ReadLine().ToLower();

                if (svar == "ja")
                {
                    Console.WriteLine("Bra! Vi sätter igång.");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 1: " + score + " poäng");
                    fråga1();
                }

                else if (svar == "nej")
                {
                    Console.WriteLine("Mmmm........Vi sätter igång ändå.");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 1: " + score + " poäng");
                    fråga1();
                }
            }

            //Svars alternativen till fråga 1 i quiz:en.

            while (svar != "1" && svar != "x" && svar != "2")
            {
                svar = Console.ReadLine().ToLower();

                if (svar == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 0;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 2: " + score + " poäng");
                    fråga2();
                }

                if (svar == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 8;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 2: " + score + " poäng");
                    fråga2();
                }

                if (svar == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 8;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 2: " + score + " poäng");
                    fråga2();
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
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 3: " + score + " poäng");
                    fråga3();
                }

                if (svar2 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 3: " + score + " poäng");
                    fråga3();
                }

                if (svar2 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 3: " + score + " poäng");
                    fråga3();
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
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 4: " + score + " poäng");
                    fråga4();

                }

                if (svar3 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 4: " + score + " poäng");
                    fråga4();
                }

                if (svar3 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 4: " + score + " poäng");
                    fråga4();
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
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 5: " + score + " poäng");
                    fråga5();
                }

                if (svar4 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 5: " + score + " poäng");
                    fråga5();
                }

                if (svar4 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 5: " + score + " poäng");
                    fråga5();
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
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 6: " + score + " poäng");
                    fråga6();
                }

                if (svar5 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 6: " + score + " poäng");
                    fråga6();
                }

                if (svar5 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 6: " + score + " poäng");
                    fråga6();
                }
            }

            //Svars alternativen till fråga 6 i quiz:en.

            while (svar6 != "1" && svar6 != "x" && svar6 != "2")
            {
                svar6 = Console.ReadLine().ToLower();

                if (svar6 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 7: " + score + " poäng");
                    fråga7();
                }

                if (svar6 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 7: " + score + " poäng");
                    fråga7();
                }

                if (svar6 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 7: " + score + " poäng");
                    fråga7();
                }
            }

            //Svars alternativen till fråga 7 i quiz:en.

            while (svar7 != "1" && svar7 != "x" && svar7 != "2")
            {
                svar7 = Console.ReadLine().ToLower();

                if (svar7 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 8: " + score + " poäng");
                    fråga8();
                }

                if (svar7 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 8: " + score + " poäng");
                    fråga8();
                }

                if (svar7 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 8: " + score + " poäng");
                    fråga8();
                }
            }

            //Svars alternativen till fråga 8 i quiz:en.

            while (svar8 != "1" && svar8 != "x" && svar8 != "2")
            {
                svar8 = Console.ReadLine().ToLower();

                if (svar8 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 9: " + score + " poäng");
                    fråga9();
                }

                if (svar8 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 9: " + score + " poäng");
                    fråga9();
                }

                if (svar8 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 9: " + score + " poäng");
                    fråga9();
                }
            }

            //Svars alternativen till fråga 9 i quiz:en.

            while (svar9 != "1" && svar9 != "x" && svar9 != "2")
            {
                svar9 = Console.ReadLine().ToLower();

                if (svar9 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 10: " + score + " poäng");
                    fråga10();
                }

                if (svar9 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 10: " + score + " poäng");
                    fråga10();
                }

                if (svar9 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("Fråga 10: " + score + " poäng");
                    fråga10();
                }
            }

            //Svars alternativen till fråga 10 i quiz:en.

            while (svar10 != "1" && svar10 != "x" && svar10 != "2")
            {
                svar10 = Console.ReadLine().ToLower();

                if (svar10 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");
                }

                if (svar10 == "x")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Felaktigt svar");
                    i -= 3;
                    Console.WriteLine("Dina poäng: ***");
                }

                if (svar10 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Korrekt svar");
                    i += 5;
                    Console.WriteLine("Dina poäng: ***");
                }
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tryck [ENTER] för att beräkna ditt resultat:)");
            Console.ReadLine();

            /* if (i < 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Bra försök:/");
                Console.WriteLine("Bättre lycka nästa gång:)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
            }

            if (i > 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Mycket bra jobbat :)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
            }  */

            if (i == 50)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Mycket bra jobbat :)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Betyg: A");
            }

            if (i > 37.5 && i < 50)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Mycket bra jobbat :)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Betyg: B");
            }

            if (i > 25 && i < 37.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Mycket bra jobbat :)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Betyg: C");
            }

            if (i > 12.5 && i < 25)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Mycket bra jobbat :)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Betyg: D");
            }

            if (i > 6 && i < 12.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Mycket bra jobbat :)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Betyg: E");
            }

            if (i < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Bra försök:/");
                Console.WriteLine("Bättre lycka nästa gång:)");
                Console.WriteLine("Resultat: " + i + "/50 Poäng");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Betyg: F");
            }

            Console.ReadLine();
        }

        static void fråga1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vem var Nikola Tesla?");
            Console.WriteLine("1. Uppfinnare");
            Console.WriteLine("X. Fysiker");
            Console.WriteLine("2. Astronom");
            Console.WriteLine("Svara med 1, X ELLER 2");
        }

        static void fråga2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I vilken mytologi existerar Guden [Ares]?");
            Console.WriteLine("1. Nordiska mytologin");
            Console.WriteLine("X. Mesopotamisk mytologi");
            Console.WriteLine("2. Grekiska mytologin");
        }

        static void fråga3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mellan vilka år var Napoleon kejsare över Frankrike?");
            Console.WriteLine("1. Mellan, 1683 - 1760");
            Console.WriteLine("X. Mellan, 1805 - 1814");
            Console.WriteLine("2. Mellan, 1765 - 1790");
        }

        static void fråga4()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Avsluta låttexten: Feeling my way through the darkness......");
            Console.WriteLine("1. When I'm wiser and I'm older");
            Console.WriteLine("X. Guided by a beating heart");
            Console.WriteLine("2. But I know where to start");
        }

        static void fråga5()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vilken låt på youtube har flest visningar mellan dessa 3");
            Console.WriteLine("1. Uptown Funk: Mark Ronson ft. Bruno Mars");
            Console.WriteLine("X. See You Again: Wiz Khalifa ft. Charlie Puth");
            Console.WriteLine("2. Shape Of You: Ed Sheeran");
        }

        static void fråga6()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vem skrev låten I Don't Care?");
            Console.WriteLine("1. Ed Sheeran & Justin Biber");
            Console.WriteLine("X. Ed Sheeran & James Arthur");
            Console.WriteLine("2. Ed Sheeran & Jonas Brothers");
        }

        static void fråga7()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vilken film har tjänat in mest pengar?");
            Console.WriteLine("1. Avatar: $2.***B");
            Console.WriteLine("X. Avengers Endgame: $2.***B ");
            Console.WriteLine("2. Titanic: $2.***B");
        }

        static void fråga8()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I vilken av följande filmer har Johnny Christopher Depp II medverkat i?");
            Console.WriteLine("1. Ocean's 8");
            Console.WriteLine("X. The Revenant");
            Console.WriteLine("2. Edward Scissorhands");
        }

        static void fråga9()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vilken av dessa filmer har högst betyg av [imdb]?");
            Console.WriteLine("1. Gudfadern");
            Console.WriteLine("X. The Dark Knight");
            Console.WriteLine("2. Schindler's List");
        }

        static void fråga10()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vilken youtube kanal är störst just nu?");
            Console.WriteLine("1. PewDiePie ");
            Console.WriteLine("X. 5-Minute Crafts ");
            Console.WriteLine("2. T-Series");
        }
    }
}

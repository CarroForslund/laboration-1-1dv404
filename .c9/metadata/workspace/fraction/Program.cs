{"filter":false,"title":"Program.cs","tooltip":"/fraction/Program.cs","undoManager":{"mark":3,"position":3,"stack":[[{"group":"doc","deltas":[{"start":{"row":0,"column":0},"end":{"row":51,"column":0},"action":"insert","lines":["using System;","using System.Collections.Generic;","using System.Linq;","using System.Text;","using System.Threading.Tasks;","","namespace fraction","{","    class Program","    {","        static void Main(string[] args)","        {","            Console.WriteLine(\"Skriv in två bråktal\\n\");","","","            Fraction frac1 = new Fraction(ReadInt(\"Ange täljare för tal 1: \"), ReadInt(\"Ange nämnare för tal 1: \"));","            Fraction frac2 = new Fraction(ReadInt(\"Ange täljare för tal 2: \"), ReadInt(\"Ange nämnare för tal 2: \"));","","            Fraction frac3 = new Fraction();","            Console.WriteLine(\"Bråktal 1: {0}/{1}\\nBråktal 2: {2}/{3}\", frac1.getNumerator, frac1.getDenominator, frac2.getNumerator, frac2.getDenominator);","            Console.Write(\"De två talen adderade blir: \");","            Console.WriteLine(frac3.add(frac1, frac2));","            Console.Write(\"De två talen multiplicerade blir: \");","            Console.WriteLine(frac3.multiply(frac1, frac2));","           ","        }","","        public static int ReadInt(string prompt)","        {","            //Metod för att läsa in heltal","            //Skriv ut felmeddelande om värdet inte kan tolkas som ett heltal","            int input;","            while (true)","            {","                Console.Write(prompt);","                try","                {","                    input = int.Parse(Console.ReadLine());","                    break;","                }","                catch","                {","                    Console.BackgroundColor = ConsoleColor.Red;","                    Console.WriteLine(\"Du måste mata in ett heltal med siffertangenterna\");","                    Console.ResetColor();","                }","            }","            return input;","        }","    }","}",""]}]}],[{"group":"doc","deltas":[{"start":{"row":50,"column":1},"end":{"row":51,"column":0},"action":"remove","lines":["",""]}]}],[{"group":"doc","deltas":[{"start":{"row":0,"column":0},"end":{"row":50,"column":1},"action":"remove","lines":["using System;","using System.Collections.Generic;","using System.Linq;","using System.Text;","using System.Threading.Tasks;","","namespace fraction","{","    class Program","    {","        static void Main(string[] args)","        {","            Console.WriteLine(\"Skriv in två bråktal\\n\");","","","            Fraction frac1 = new Fraction(ReadInt(\"Ange täljare för tal 1: \"), ReadInt(\"Ange nämnare för tal 1: \"));","            Fraction frac2 = new Fraction(ReadInt(\"Ange täljare för tal 2: \"), ReadInt(\"Ange nämnare för tal 2: \"));","","            Fraction frac3 = new Fraction();","            Console.WriteLine(\"Bråktal 1: {0}/{1}\\nBråktal 2: {2}/{3}\", frac1.getNumerator, frac1.getDenominator, frac2.getNumerator, frac2.getDenominator);","            Console.Write(\"De två talen adderade blir: \");","            Console.WriteLine(frac3.add(frac1, frac2));","            Console.Write(\"De två talen multiplicerade blir: \");","            Console.WriteLine(frac3.multiply(frac1, frac2));","           ","        }","","        public static int ReadInt(string prompt)","        {","            //Metod för att läsa in heltal","            //Skriv ut felmeddelande om värdet inte kan tolkas som ett heltal","            int input;","            while (true)","            {","                Console.Write(prompt);","                try","                {","                    input = int.Parse(Console.ReadLine());","                    break;","                }","                catch","                {","                    Console.BackgroundColor = ConsoleColor.Red;","                    Console.WriteLine(\"Du måste mata in ett heltal med siffertangenterna\");","                    Console.ResetColor();","                }","            }","            return input;","        }","    }","}"]},{"start":{"row":0,"column":0},"end":{"row":51,"column":0},"action":"insert","lines":["using System;","using System.Collections.Generic;","using System.Linq;","using System.Text;","using System.Threading.Tasks;","","namespace fraction","{","    class Program","    {","        static void Main(string[] args)","        {","            Console.WriteLine(\"Skriv in två bråktal\\n\");","","","            Fraction frac1 = new Fraction(ReadInt(\"Ange täljare för tal 1: \"), ReadInt(\"Ange nämnare för tal 1: \"));","            Fraction frac2 = new Fraction(ReadInt(\"Ange täljare för tal 2: \"), ReadInt(\"Ange nämnare för tal 2: \"));","","            Fraction frac3 = new Fraction();","            Console.WriteLine(\"Bråktal 1: {0}/{1}\\nBråktal 2: {2}/{3}\", frac1.getNumerator, frac1.getDenominator, frac2.getNumerator, frac2.getDenominator);","            Console.Write(\"De två talen adderade blir: \");","            Console.WriteLine(frac3.add(frac1, frac2));","            Console.Write(\"De två talen multiplicerade blir: \");","            Console.WriteLine(frac3.multiply(frac1, frac2));","            Console.ReadKey();","        }","","        public static int ReadInt(string prompt)","        {","            //Metod för att läsa in heltal","            //Skriv ut felmeddelande om värdet inte kan tolkas som ett heltal","            int input;","            while (true)","            {","                Console.Write(prompt);","                try","                {","                    input = int.Parse(Console.ReadLine());","                    break;","                }","                catch","                {","                    Console.BackgroundColor = ConsoleColor.Red;","                    Console.WriteLine(\"Du måste mata in ett heltal med siffertangenterna\");","                    Console.ResetColor();","                }","            }","            return input;","        }","    }","}",""]}]}],[{"group":"doc","deltas":[{"start":{"row":50,"column":1},"end":{"row":51,"column":0},"action":"remove","lines":["",""]}]}]]},"ace":{"folds":[],"scrolltop":138.59999999999997,"scrollleft":16.8,"selection":{"start":{"row":50,"column":1},"end":{"row":50,"column":1},"isBackwards":false},"options":{"guessTabSize":true,"useWrapMode":false,"wrapToView":true},"firstLineState":{"row":5,"state":"start","mode":"ace/mode/csharp"}},"timestamp":1416861534071,"hash":"e4b04da8dd58017b8a1d74795ffd20f6c8e7110a"}
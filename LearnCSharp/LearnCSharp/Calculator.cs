using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class Calculator
    {
        //Property fields her:
        //En property er bare en variable, som man kan tilgå efter, at man har oprettet et objekt af den tilhørende type.
        //De eneste variabler man kan tilgå i et objekt er properties. Dvs. skal noget 'gemmes' til senere så skal der laves en property
        public string[] methods = { "Addition", "Multiplication", "Subtraction", "division" };

        //Eksempel
            /* 
             * Oprettelse af objekt af typen Calculator
             * 
             *  Type          variable navn       instantiering af ny objekt            constructor
             *  Calculator    calculatorObjekt  =            new                         Calculator()
             *
             *
             *  Calculator calculatorObjekt = new Calculator();
             *
             *
             *
             *
             *  
             *  
             *  for at tilgå en property:
             *                         
             *                         0 repræsentærer den første plads i vores array methods. I dette tilfælde vil det være Addition
             *  string x = calculatorObjekt.methods[0];
             *  
             *  x er nu = Addition
             *  
             *  
             *  
             *  
             *  
             *  Udskrivning af variabler og properties:
             *                  
             *                  For at kunne udskrive variabler direkte i en string skal vi angive $ før " og {} omkring objektet
             *  Console.Writeline($"Den første metode er {x}");
             *  
             *                  I stedet for at skulle igennem en variable kan man tilgå propertien direkte og gør i stedet
             *                  Vær opmærksom på at arrays, lister og alle former for samling af data starter i 0. Dvs. at det første element/værdi er på plads 0.
             *                  Skal man tilgå plads #2 skrives der 1 i stedet.
             *  Console.Writeline($"Den anden metode er {calculatorObjekt.methods[1]");
             *  
             *
             *  
             *  
             *
             *
             *
             */


            //Constructor. En constructor er en hjælpefunktion, som bliver kørt, når man opretter et nyt objekt af typen Calculator. En constructor kan indeholde 0 eller flere parametre
            //Denne funktion bliver kaldt hver gang man 'laver' en Calculator og kan være super lækker at bruge, hvis man ved, at noget skal ske, hver man man ønsker et objekt af klassen.
            // Constructoren behøver dog ikke lave noget og man kan lade den være blank / tom, hvis man ikke har noget brug for den. Det gør vi her.
        public Calculator()
        {

        }


        /* Når man laver en funktion/metode skal man bare følge opskriften:
         * 
         * Protection ReturType Funktionsnavn()
         * 
         * Protection: protection skal enten være public eller private. I starten kan du bare lave alt public.
         * Returtype: Dette er den type værdi vi forventer at få tilbage fra funktionen
         *        Et par forskellige typer man bruger ofte:      
         *            string      : normal tekst som er angivet mellem " "
         *            int         : hele tal. 1 2 3 4 5 6
         *            double      : komma tal. 1,4 2,5 3,8
         *            void        : vi ønsker ikke noget retur
         *            KlasseNavn  : Returnere et objekt af den ønskede type.
         */

                          //parametre til funktionen - Data man giver med, når man kalder en funktion
                          //Type sigendeNavn
        public int Addition(int tal1, int tal2)
        {
            //simpelt regnestykke, tal 1 + tal 2, hvor vi gemmer svaret i sum
            int sum = tal1 + tal2;

            //for at fortælle funktionen, hvilke værdi man ønsker at sende tilbage bruges keyworded return.
            //Vi returnerer her sum
            return sum;
        }

        /* Opret nu et objekt af Calculator i filen Program.cs
         * Kald metoden Addition (objekt.Addition(et tal, et anden tal)
         * Udskriv resultatet af metoden til brugeren ved brug af en Console.Writeline.
         * 
         */
    }
}

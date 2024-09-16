namespace scope_klasser_objekter_forelesning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        

        // Legger kalkulatoren med brukerinput i en egen metode, slik at den kan kalles når man ønsker, istedenfor å bare kjøre.
        void KalkulatorMedBrukerInput() {
            // Lager en while-løkke som gjør det mulig for brukeren å foreta flere utregninger på rappen, uten å starte programmet på nytt hver gang.
            bool betingelse = true;
            while (betingelse != false)
            {
                 // Lager et Calculator-objekt innenfor metoden, hvis funksjoner brukes for utregningene senere.
            Calculator calculator = new Calculator();

             Console.WriteLine("Velkommen til konsoll-kalkulatoren. Hvilken operasjon vil du utføre? Tast inn 'addere', 'subtrahere', 'multiplisere' eller 'dividere', eller '+', '-', '*' eller '/'");
            string? brukerInput = Console.ReadLine();
            Console.WriteLine(brukerInput);

        switch (brukerInput)
        {
            case "addere":
            case "+":
                Console.WriteLine("Tast inn det første tallet du vil addere med:");
                string? x = Console.ReadLine();
                Console.WriteLine("Tast inn tall nummer to:");
                string? y = Console.ReadLine();
                Console.WriteLine(calculator.AddNumbers(double.Parse(x), double.Parse(y)));
                break;
            case "subtrahere":
            case "-":
                Console.WriteLine("Tast inn tallet du vil subtrahere fra:");
                string? minuend = Console.ReadLine();
                Console.WriteLine("Tast inn tallet du vil subtrahere med:");
                string? subtrahend = Console.ReadLine();
                Console.WriteLine(calculator.SubtractNumbers(double.Parse(minuend), double.Parse(subtrahend)));
                break;

            case "multiplisere":
            case "*":
                Console.WriteLine("Tast inn den første faktoren du vil multiplisere:");
                string? faktorEn = Console.ReadLine();
                Console.WriteLine("Tast inn faktor nummer to:");
                string? faktorTo = Console.ReadLine();
                Console.WriteLine(calculator.MultiplyNumbers(double.Parse(faktorEn), double.Parse(faktorTo)));
                break;
            case "dividere":
            case "/":
                Console.WriteLine("Tast inn telleren:");
                string? teller = Console.ReadLine();
                Console.WriteLine("Tast inn nevneren:");
                string? nevner = Console.ReadLine();
                Console.WriteLine(calculator.DivideNumbers(double.Parse(teller), double.Parse(nevner)));
                break;

            default:
                Console.WriteLine("Du må velge en gyldig operasjon.");
                break;
        }

        // Spør brukeren om han vil gjøre en ny utregning, og setter while-løkkens betingelse til 'true' hvis svaret er ja, og 'false' hvis det er nei.
            Console.WriteLine("Vil du foreta en ny utregning? Skriv 'ja' eller 'nei'");
            string? fortsett = Console.ReadLine();
            if (fortsett == "ja") {
                betingelse = true;
            } else if (fortsett == "nei") {
                betingelse = false;
            } else {
                Console.WriteLine("Du ga ikke et gyldig svar. Programmet leser det som et 'nei'.");
                betingelse = false;
            }
            }

            
           
        }

        KalkulatorMedBrukerInput();


    }
}

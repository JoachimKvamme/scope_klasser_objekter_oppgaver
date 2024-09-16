namespace scope_klasser_objekter_forelesning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        

        // Legger kalkulatoren med brukerinput i en egen metode, slik at den kan kalles når man ønsker, istedenfor å bare kjøre.
        void KalkulatorMedBrukerInput() {

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
        }

        KalkulatorMedBrukerInput();


    }
}

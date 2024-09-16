using System.Security.Cryptography.X509Certificates;

interface ICalculator
{
    /// <summary>
    /// Denne funksjonen tar to parametre av typen double, og legger dem sammen.
    /// </summary>
    /// <param name="x">Første tall</param>
    /// <param name="y">Andre tall</param>
    /// <returns></returns>
    double AddNumbers(double x, double y);
    /// <summary>
    /// Denne funksjonen tar to tall av typen dobbel, og trekker det siste tallet fra det første.
    /// </summary>
    /// <param name="x">Minuend, mengden man subtraherer fra.</param>
    /// <param name="y">Subtrahend, mengden man trekker fra minuenden.</param>
    /// <returns></returns>
    double SubtractNumbers(double minuend, double subtrahend);

    /// <summary>
    /// Denne metoden dividerer et tall (telleren) på et annet (nevneren).
    /// </summary>
    /// <param name="teller">Telleren</param>
    /// <param name="nevner">Nevneren</param>
    /// <returns></returns>
    double DivideNumbers(double teller, double nevner);
    /// <summary>
    /// Multipliserer et tall med et annet
    /// </summary>
    /// <param name="x">Første tall</param>
    /// <param name="y">Andre tall</param>
    /// <returns></returns>
    double MultiplyNumbers(double x, double y);
}
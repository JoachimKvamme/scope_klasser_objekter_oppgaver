using System.Security.Cryptography.X509Certificates;

public class Calculator : ICalculator
 {
    public double AddNumbers(double x, double y) {
        return x + y;
    }
    public double SubtractNumbers(double x, double y) {
        return x - y;
    }
    public double DivideNumbers(double teller, double nevner) {
        return teller / nevner;
    }   
    public double MultiplyNumbers(double x, double y) {
        return x * y;
    }
    
}
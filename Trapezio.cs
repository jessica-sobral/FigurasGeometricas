public class Trapezio {
    public double BaseMaior { get; set; }
    public double BaseMenor { get; set; }
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Altura { get; set; }

    public Trapezio(double baseMaior, double baseMenor, double lado1, double lado2, double altura)
    {
        BaseMaior = baseMaior;
        BaseMenor = baseMenor;
        Lado1 = lado1;
        Lado2 = lado2;
        Altura = altura;
    }

    public double CalcularArea()
    {
        double area = ((BaseMaior + BaseMenor) * Altura) / 2;

        return area;
    }

    public double CalcularPerimetro()
    {
        double perimetro = BaseMaior + BaseMenor + Lado1 + Lado2;

        return perimetro;
    }

    //private double calculoAltura()
    //{
        //double cateto = (BaseMenor - BaseMaior) / 2;

        //double altura = (Lado2 * Lado2) + (cateto * cateto);

        //altura = Math.Sqrt(altura);

        //return altura;
    //}
}
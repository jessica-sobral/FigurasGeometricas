Quadrado q1 = new Quadrado(25.00);

Console.WriteLine("Área q1: " + q1.Area);
Console.WriteLine("Perímetro q1: " + q1.Perimetro);

Retangulo r1 = new Retangulo(14.5, 7.5);

Console.WriteLine("\nÁrea r1: " + r1.Area);
Console.WriteLine("Perímetro r1: " + r1.Perimetro);

Console.WriteLine("Entre com a base maior do trapézio: ");
double baseMaior = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com a base menor do trapézio: ");
double baseMenor = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com o lado 1 do trapézio: ");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com o lado 2 do trapézio: ");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com a altura do trapézio: ");
double altura = Convert.ToDouble(Console.ReadLine());

Trapezio t = new Trapezio(baseMaior, baseMenor, lado1, lado2, altura);

Console.WriteLine("Trapézio: área {0}, perímetro {1}", t.Area, t.Perimetro);

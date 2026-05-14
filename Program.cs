using calculadora;

calculadora_met_sobrecarga calculadora = new calculadora_met_sobrecarga();

Console.WriteLine("Multiplicación de 2 números enteros: " + calculadora.calcular(98, 4));
Console.WriteLine("división de 2 números decimales: " + calculadora.calcular(10.5, 2.5));
Console.WriteLine("potencia de 2 números enteros: " + calculadora.calcular(3, 4, true));
Console.WriteLine("potencia de 2 decimales: " + calculadora.calcular(2.5, 3.0, true));
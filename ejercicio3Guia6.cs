using System;
namespace Guia6_1
{
  class main2 {
    public static void Main (string[] args) {
      Double l1, l2, l3, equilatero = 0, isosceles = 0, escaleno = 0, triangulos = 0;

      Console.WriteLine("Escriba el número de triangulos");
      triangulos = Double.Parse(Console.ReadLine());

      for(int cont=0; cont < triangulos; cont++){
        Console.WriteLine("Escriba la longitud de los lados del triangulo #" + (cont + 1));

        Console.WriteLine("Escriba la longitud del lado 1");
        l1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Escriba la longitud del lado 2");
        l2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Escriba la longitud del lado 3");
        l3 = Double.Parse(Console.ReadLine());

        if(l1 == l2 && l2 == l3){
          equilatero++;
        }else{
          if(l1 == l2 || l2 == l3 || l3 == l1){
            isosceles++;
          }else{
            escaleno++;
          }
        }
      }

      Console.WriteLine("Cantidad de triangulos equilateros: " + equilatero);
      Console.WriteLine("Cantidad de triangulos isosceles: " + isosceles);
      Console.WriteLine("Cantidad de triangulos escalenos: " + escaleno);

      if(equilatero < isosceles && equilatero < escaleno){
        Console.WriteLine("El Tipo de triangulo que posee menor cantidad es el equilatero");
      }else{
        if(isosceles < equilatero && isosceles < escaleno){
          Console.WriteLine("El Tipo de triangulo que posee menor cantidad es el isosceles");
        }else{
          if(escaleno < equilatero && escaleno < isosceles){
            Console.WriteLine("El Tipo de triangulo que posee menor cantidad es el escaleno");
          }
        }
      }
    }
  }
}
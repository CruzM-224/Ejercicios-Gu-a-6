using System;
namespace Guia6_1
{
  class main2 {
    public static void Main (string[] args) {
      int negativos = 0, positivos = 0, multiplos15 = 0, contpares = 0, temp;

      Console.WriteLine("Ingrese 10 numeros");

      for(int cont = 0; cont<10; cont++){
        temp = int.Parse(Console.ReadLine());
        if(temp % 2 == 0){
          contpares+=temp;
        }
        if(temp % 15 == 0){
          multiplos15++;
        }
        if(temp > 0){
          positivos++;
        }
        if(temp < 0){
          negativos++;
        }
      }

      Console.WriteLine("Cantidad de numeros negativos: " + negativos);
      Console.WriteLine("Cantidad de numeros positivos: " + positivos);
      Console.WriteLine("Cantidad de multiplos de 15: " + multiplos15);
      Console.WriteLine("Valor acumulado de los números ingresados que son pares: " + contpares);

    }
  }
}
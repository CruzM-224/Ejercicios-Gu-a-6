using System;
namespace Guia6_1
{
  class main2 {
    public static void Main (string[] args) {
      Double coordenadax, coordenaday, cuadrante1 = 0, cuadrante2 = 0, cuadrante3 = 0, cuadrante4 = 0, ncoordenadas;
      Console.WriteLine("Escribe el numero de coordenadas a ingresar");
      ncoordenadas = Double.Parse(Console.ReadLine());
      for(int cont = 1; cont <= ncoordenadas; cont++){
        Console.WriteLine("Ingrese una coordenada");

        Console.WriteLine("Escriba la coordenada en x");
        coordenadax = Double.Parse(Console.ReadLine());

        Console.WriteLine("Escriba la coordenada en y");
        coordenaday = Double.Parse(Console.ReadLine());

        if(coordenadax > 0){
          if(coordenaday > 0){
            cuadrante1++;
          }
          if(coordenaday < 0){
            cuadrante4++;
          }
        }

        if(coordenadax < 0){
          if(coordenaday > 0){
            cuadrante2++;
          }
          if(coordenaday < 0){
            cuadrante3++;
          }
        }
      }

      Console.WriteLine("Puntos en el primer cuadrante: " + cuadrante1);
      Console.WriteLine("Puntos en el segundo cuadrante: " + cuadrante2);
      Console.WriteLine("Puntos en el tercer cuadrante: " + cuadrante3);
      Console.WriteLine("Puntos en el cuarto cuadrante: " + cuadrante4);

    }
  }
}
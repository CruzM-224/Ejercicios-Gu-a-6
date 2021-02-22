using System;
namespace Guia6_1
{
  class main1 {
    public static void Main (string[] args) {
      Double numero, multiplo, multiplicador;
      Console.WriteLine("Escribe un numero");
      numero = Double.Parse(Console.ReadLine());
      Console.WriteLine("Su tabla de multiplicar es:");
      for(multiplicador = 1; multiplicador<=10; multiplicador++){
        multiplo = numero * multiplicador;
        Console.WriteLine(numero + " * " + multiplicador + " = " + multiplo);
      }
    }
  }
}
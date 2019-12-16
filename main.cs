using System;

class MainClass {
  public static void Main (string[] args) {
    Bola B = new Bola();

    Console.WriteLine ("Informe a cor da bola: ");
    B.setCor (Console.ReadLine());

    Console.WriteLine ("Informe a circunferência da bola: ");
    B.setCircunferencia(double.Parse (Console.ReadLine()));

    Console.WriteLine ("Informe o material da bola: ");
    B.setMaterial (Console.ReadLine());
  }
}
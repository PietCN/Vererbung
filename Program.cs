using System;

class Program
{
  static void Main()
  {
    Stack<Figur> figurenStack = new Stack<Figur>();

    Figur[] figuren = new Figur[10];

    figuren[0] = new Kreis("blau", 3.0);
    figuren[1] = new Kreis("rot", 7.3);
    figuren[2] = new Rechteck("lila", 20.5, 30.7);
    figuren[3] = new Ring("blau", 20.9, 19.3);
    figuren[4] = new Rechteck("grün", 10.2, 4.9);
    figuren[5] = new Parallelogram("grau", 70.0, 20.4, 67.0);
    figuren[6] = new Ring("magenta", 20.0, 17.2);
    figuren[7] = new Rechteck("schwarz", 90.3, 73.5);
    figuren[8] = new Kreis("gelb", 34.4);
    figuren[9] = new Parallelogram("blau", 44.2, 19.9, 22.6);


    foreach (Figur fig in figuren)
      figurenStack.Push(fig);

    Figur.zeigeZaehler();
    Console.WriteLine("Momentane Stackgröße: " + figurenStack.Count);
    Console.WriteLine("Ausgabe: ");
    
    for (uint i = figurenStack.Count; i != 0; --i )
    {
      Console.Write(i + ") ");
      figurenStack.Pop().Show();
    }

    Figur.zeigeZaehler();
    Console.WriteLine("Momentane Stackgröße: " + figurenStack.Count);

    Console.ReadKey();
  }
}
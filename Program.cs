using System;

class Program
{
  static void Main()
  {
    Kreis kreis = new Kreis("blau", 10.0);
    Rechteck rechteck = new Rechteck("grün", 5.0, 2.3);
    Ring ring = new Ring("lila", 30.0, 15.0);

    kreis.Show();
    rechteck.Show();
    ring.Show();

    Console.ReadKey();
  }
}
using System;

public class Kreis : Figur
{
  protected double radius;

  public Kreis(string Farbe, double Radius) : base(Farbe)
  {
    this.radius = Radius;
  }

  public override void Show()
  {
    Console.WriteLine("Kreis-Objekt");
    Console.WriteLine("Farbe: " + Farbe);
    Console.WriteLine("Radius: " + radius);
  }
}
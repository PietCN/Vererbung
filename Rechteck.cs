using System;

public class Rechteck : Figur
{
  protected double laenge;
  protected double breite;

  public Rechteck(string farbe, double laenge, double breite) : base(farbe)
  {
    this.laenge = laenge;
    this.breite = breite;
  }

  public override void Show()
  {
    Console.WriteLine("Rechteck-Objekt");
    Console.WriteLine("Farbe: " + Farbe);
    Console.WriteLine("Größe: " +  breite + " x " + laenge);
  }
}
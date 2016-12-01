using System;

public class Parallelogram : Rechteck
{
  protected double winkel;

  public Parallelogram(string farbe, double laenge, double breite, double winkel) : base(farbe, laenge, breite)
  {
    if (winkel > 0 && winkel <= 90)
      this.winkel = winkel;
    else
      this.winkel = 90; //Rechteck
  }

  public override void Show()
  {
    Console.WriteLine("Parallelogram-Objekt");
    Console.WriteLine("Farbe: " + Farbe);
    Console.WriteLine("Größe: " + breite + " x " + laenge + "  Winkel: " + winkel + "°");
  }
}
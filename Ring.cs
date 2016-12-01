using System;

public class Ring : Kreis
{
  protected double innenRadius;

  public Ring(string farbe, double aussenRadius, double innenRadius) : base(farbe, aussenRadius)
  {
    if (innenRadius < radius)
      this.innenRadius = innenRadius;
    else
      this.innenRadius = radius;
  }

  public override void Show()
  {
    Console.WriteLine("Ring-Objekt");
    Console.WriteLine("Farbe :" + Farbe);
    Console.WriteLine("InnenRadius: " + innenRadius + ", AussenRadius :" + radius);
  }
}
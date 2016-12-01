using System;
public abstract class Figur
{
  //Felder
  protected string Farbe;
  static public int zaehler;

  public Figur(string Farbe)
  {
    this.Farbe = Farbe;
    zaehler++;
  }

  
  public abstract void Show();
  static public void zeigeZaehler()
  {
    Console.WriteLine("Es gibt momentan " + zaehler + " Objekte.");
  }

}


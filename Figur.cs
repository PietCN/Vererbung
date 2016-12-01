using System;
public abstract class Figur
{
  //Felder
  string Farbe;

  public Figur(string Farbe)
  {
    this.Farbe = Farbe;
  }

  public abstract void Show();
}


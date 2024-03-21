using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
       //Storm windStorm = new Storm("wind", false, "Zul'rajas");  

       //Console.WriteLine(windStorm.Announce());   

      // Pupil mezi = new Pupil("Mezil-kree");

      // Storm pupilStorm = mezi.CastWindStorm();

      // Console.WriteLine(pupilStorm.Announce());

      //Mage Guldan = new Mage("Gul'dan");

     // Storm GulStorm = Guldan.CastRainStorm();
      //Console.WriteLine(GulStorm.Announce());

      Archmage nielas = new Archmage("Nielas Aran");

      Storm nieRain = nielas.CastRainStorm();
      Storm nieLight = nielas.CastLightningStorm();

      Console.WriteLine(nieRain.Announce());
      Console.WriteLine(nieLight.Announce());


    }
  }
}
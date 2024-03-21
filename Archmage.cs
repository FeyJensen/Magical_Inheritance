// Archmage.cs
using System;

namespace MagicalInheritance
{
   class Archmage : Mage {
      public Archmage(string string2) : base(string2) {

      }

      public override Storm CastRainStorm() {
        Storm ArchStorm = new Storm("rain", true, Title);
        return ArchStorm;
      }

      public Storm CastLightningStorm(){
        Storm lightStorm = new Storm("lightning", true, Title);
        return lightStorm;
      }
   }
}

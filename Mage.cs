// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil {
    //constructor
    public Mage(string mageString) : base(mageString) {

    }

    public virtual Storm CastRainStorm(){
      Storm mageStorm = new Storm("rain", false, Title);
      return mageStorm;
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Planet
{
    class TerrestrialPlanet:Planet ,IHasMoons,IHabitable
    {
        private bool _oxygen;
        //constructor
        public TerrestrialPlanet(string name,double mass,double diameter,bool Oxygen) :
            base(name,mass,diameter )
        {
            this._oxygen = Oxygen;
 
        }
        //implement the interface
        public bool HasMoons()
        {
            return this.MoonCount > 0 ? true : false;
        }

        public bool Habitable()
        {
            if (this._oxygen == true)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}

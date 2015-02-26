using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Planet
{
    class GiantPlanet:Planet,IHasMoons,IHasRings
    {
        //private instance variables 
        private string _type;//will describes the type of giant planet like gas or fire

        //Constuctor

        public GiantPlanet(string name, double mass,double diameter,string type) :
            base(name,mass,diameter)
        {
            this._type = type;
        }


        public bool HasMoons()
        {
            return this.MoonCount >0 ? true:false ;
        }

        public bool HasRings()
        {
            return this.RingCount > 0 ? true : false;
        }
    }
}

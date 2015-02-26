using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Planet
{
    abstract class Planet
    {
        //private instance variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        //public properties
        public double Diameter
        {
            get
            {
                return this._diameter;//read only
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;//read only
            }
        }
        public string Name
        {
            get
            {
                return this._name;//read only
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;//read only
            }
        }
        public double OrbitalPeriod
        {
            get 
            {
                return this._orbitalPeriod;
            }
            set 
            {
                this._orbitalPeriod = value;
            }
           
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }

        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }

        }
        //constructor
        public Planet(string name,double mass,double diameter)
        {
            this._diameter = diameter;
            this._mass = mass;
            this._name = name;
        }

        public override string ToString()
        {
            return String.Format ("The Planet  {0} has diameter of {1} km and mass of {2} kg",this.Name,this.Diameter, this.Mass);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Figuras
{
    class CCirculo : CFigura
    {
        private float radio;
        public CCirculo(float r) : base(1)
        {
            this.radio = r;
        }
        public CCirculo() : this(10.0F)
        {
        }
        public override float darPerimetro()
        {
            return this.radio * (float)System.Math.PI * 2;
        }
        public override string darDatos()
        {
            return "\n Datos circulo..." + base.darDatos()
                 + "\n El radio mide: " + this.radio +
                 "\n El perimetro mide: " + darPerimetro();
        }
    }
}

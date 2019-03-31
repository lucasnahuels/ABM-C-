using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Figuras
{
    class CTriangulo : CFigura
    {
        private float lado1;
        private float lado2;
        private float lado3;

        public CTriangulo(float l1, float l2, float l3) : base(3)
        {
            this.lado1 = l1;
            this.lado2 = l2;
            this.lado3 = l3;
        }
        public CTriangulo() : this(1.0F, 2.0F, 3.0F)
        {
        }
        public override float darPerimetro()
        {
            return this.lado1 + this.lado2 + this.lado3;
        }
        public override string darDatos()
        {
            return "\n Datos triangulo..."
                 + base.darDatos() +
                 "\n Lado 1: " + this.lado1 + "\n Lado 2: " + this.lado2 + "\n Lado 3: " + this.lado3 +
                 "\n El perimetro mide: " + darPerimetro();
        }
    }
}

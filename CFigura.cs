using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Figuras
{
    class CFigura : IComparable
    {
        private ushort cantLados;
        public CFigura(ushort cL)
        {
            this.cantLados = cL;
        }
        public CFigura() : this(0)
        {
        }
        public virtual float darPerimetro()
        {
            return 0.0F;
        }
        public virtual string darDatos()
        {
            return "\n Cantidad de lados: " + this.cantLados;
        }
        public int CompareTo(object obj)
        {
            if(obj is CFigura)
            {
                if (this.darPerimetro() < ((CFigura)obj).darPerimetro())
                    return -1;
                if (this.darPerimetro() > ((CFigura)obj).darPerimetro())
                    return 1;
                if (this.darPerimetro() == ((CFigura)obj).darPerimetro())
                    return 0;
            }
            return int.MaxValue;
        }
    }
}

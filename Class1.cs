using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaNEW
{
    public class ThreeSided
    {
        private float sideA;
        private float sideB;
        private float sideC;

        public float SideA
        {
            get {return sideA;}
            set {sideA = value;}
        }
        public float SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public float SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public virtual float CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
    public class FourSided : ThreeSided
    {
        private float sideD;
        public float SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }

        public override float CalculatePerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
    }
}

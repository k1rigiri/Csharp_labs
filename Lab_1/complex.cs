using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public void Add(complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }

        public void Substract(complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }

        public void Multiply(complex x)
        {
            Real = Real * x.Real - Imag * x.Imag;
            Imag = Real * x.Imag + Imag * x.Real;
        }

        public void Divide(complex x)
        {
            Real = (Real * Imag + x.Real * x.Imag) / (Math.Pow(Imag, 2) + Math.Pow(x.Imag, 2));
            Imag = (Imag * x.Real - Real * x.Imag) / (Math.Pow(Imag, 2) + Math.Pow(x.Imag, 2));
        }
    }
}

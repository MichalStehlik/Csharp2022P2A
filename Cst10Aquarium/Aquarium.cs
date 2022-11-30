using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst10Aquarium
{
    internal class Aquarium
    {
        private const double MAX_SIDE = 100; // v cm
        private const double MIN_SIDE = 10; // v cm
        private const double MAX_VOLUME = 500000;
        private const double PRICE_GLUE = 1; // na 1cm
        private const double PRICE_CUT = 10; // na tabulku skla
        private const double PRICE_GLASS = 100; // na m2
        private const double DEFAULT_VAT = 1.21;

        private double _width;
        private double _length;
        private double _height;

        public Aquarium(double width, double length, double height)
        {
            _width = width;
            _length = length;
            _height = height;
            if (!VerifyValues(width, length, height))
            {
                throw new ArgumentException("Nesprávné rozměry");
            }
        }

        public double Width 
        { 
            get { return _width; } 
            set {
                if (!VerifyValues(value, Length, Height))
                {
                    throw new ArgumentException("Nesprávná šířka");
                }
                _width = value; 
            } 
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (!VerifyValues(Height, Length, value))
                {
                    throw new ArgumentException("Nesprávná výška");
                }
                _height = value;
            }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (!VerifyValues(Height, value, Width))
                {
                    throw new ArgumentException("Nesprávná délka");
                }
                _length = value;
            }
        }

        public static bool VerifyValues(double w, double l, double h)
        {
            if (w > MAX_SIDE || w < MIN_SIDE) return false;
            if (l > MAX_SIDE || l < MIN_SIDE) return false;
            if (h > MAX_SIDE || h < MIN_SIDE) return false;
            if (w * l * h < MAX_VOLUME) return false;
            return true;
        }

        public double Volume 
        { 
            get 
            { 
                return Width * Height * Length; 
            } 
        }

        public double Edges
        {
            get
            {
                return (4 * Height + 2 * Width + 2 * Length);
            }
        }

        public double Area
        {
            get
            {
                return ((Width * Length) + (Width * Height) * 2 + (Height * Length) * 2);
            }
        }

        public void Resize(double nw, double nl, double nh)
        {
            Width = nw;
            Height = nl;
            Length = nh;
            //Width *= nw;
            //Height *= nl;
            //Length *= nh;
        }

        public void Resize(double nv)
        {
            //Width = nv;
            //Height = nv;
            //Length = nv;
            Resize(nv,nv,nv);
        }

        public double Price()
        {
            return (
                5 * PRICE_CUT
                + PRICE_GLUE * Edges
                + PRICE_GLASS * Area / 100
            );
        }

        public double PriceVAT(double vat = DEFAULT_VAT)
        {
            return Price() * vat;
        }
    }
}

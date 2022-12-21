using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T1
{
    internal class Product : Money
    {
        public string ProductName { get; set; }
        public Product(string productName, int major, string majorName, int minor, string minorName) : base(major, majorName, minor, minorName)
        {
            this.ProductName = productName;
        }

        public Product(string productName, Money price)
        {
            ProductName = productName;
            this.Major = price.Major;
            this.Minor = price.Minor;
            this.MajorName = price.MajorName;
            this.MinorName = price.MinorName;
        }

        public static Product operator + (Product p, double d)
        {
            d *= 100;
            int dMinor = Convert.ToInt32(d) % 100;
            int dMajor = Convert.ToInt32(d) / 100;            
            return new Product(p.ProductName, (p.Major + dMajor), p.MajorName, (p.Minor + dMinor), p.MinorName);
        }

        public static Product operator - (Product p, double d)
        {
            d *= 100;
            int dMinor = Convert.ToInt32(d) % 100;
            int dMajor = Convert.ToInt32(d) / 100;
            
            
            return new Product(p.ProductName, (p.Major - dMajor), p.MajorName, (p.Minor - dMinor), p.MinorName);
        }

        public override string ToString()
        {
            return $"{ProductName} {base.ToString()}";
        }
    }
}

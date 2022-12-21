using System;
using System.Windows.Markup;

namespace HW6_T1
{
    internal class Money
    {
        private int minor;
        public int Major { get; set; }
        public int Minor
        {
            get { return minor; }
            set
            {
                if (value >= 100)
                {                    
                    Major += 1;
                    minor = -100 + value;                    
                }
                else if(value < 0)
                { 
                    Major -= 1;
                    minor = 100 + value;
                }
                else
                {
                    minor = value;
                }
            }
        }
        public string MajorName { get; set; }
        public string MinorName { get; set; }

        public Money(int major, string majorName, int minor, string minorName)
        {
            Major = major;
            Minor = minor;
            MajorName = majorName;
            MinorName = minorName;
        }

        public Money() : this(0, " ", 0, " ") { }
        public override string ToString()
        {
            return $"{Major} {MajorName} {Minor}  {MinorName}";
        }

        public static Money operator + (Money m1, Money m2)
        {
            Money result = new Money(0, m1.MajorName, 0, m1.MinorName);
            if (m1.MajorName == m2.MajorName && m1.MinorName == m2.MinorName)
            {                
                result.Major = m1.Major + m2.Major;
                result.Minor = m1.Minor + m2.Minor;
                return result;
            }
            else
            {
                throw new Exception("Валюты не могут быть сложены");
            }
        }

        public static Money operator - (Money m1, Money m2)
        {
            Money result = new Money();
            if (m1.MajorName == m2.MajorName && m1.MinorName == m2.MinorName)
            {               
                result.Major = m1.Major - m2.Major;
                result.Minor = m1.Minor - m2.Minor;
                return result;
            }
            else
            {
                throw new Exception("Валюты не могут быть вычтены");
            }
        }
    }
}

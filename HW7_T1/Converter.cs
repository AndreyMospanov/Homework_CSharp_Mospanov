using System;
using System.Windows.Forms;

namespace HW7_T1
{
    public class Converter
    {
        public Converter() { }        

        private bool correctInt(string num)
        {
            return int.TryParse(num, out int result);
        }

        private bool correctBinary(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '1')
                {
                    if (num[i] != '0')
                        return false;
                }
            }
            return true;
        }

        private bool correctHex(string num)
        {
            if (num[0] == '0')
            {
                if (num[1] == 'x')
                {
                    for (int i = 2; i < num.Length; i++)
                    {
                        if ((int)num[i] > 70)
                            return false;
                        if ((int)num[i] < 65 && (int)num[i] > 57)
                            return false;
                        if ((int)num[i] < 48)
                            return false; 
                    }
                    return true;
                }
            }
            return false;
        }

        private int bitDepth(int num)
        {
            if (num < 256)
                return 8;
            else if (num < 65536)
                return 16;
            else 
                return 32;
        }

        private int hexDepth(int num)
        {
            int depth;
            for (depth = 0; depth < 9; depth++)
            {
                if (num < Math.Pow(16.0, depth))
                    break;
            }

            return depth;
        }

        public string DecToBinary(string num)
        {
            int dec;            
            string result = string.Empty;
            if(correctInt(num))
            {
                dec = int.Parse(num);
                
                for (int i = bitDepth(dec) - 1; i >= 0; i--)
                {
                    int temp = (int)Math.Pow(2, i);
                    if (dec >= temp)
                    {
                        result += "1";
                        dec -= temp;
                    }
                    else
                    {
                        result += "0";
                    }
                    
                }
                return result;
            }
            else
            {
                MessageBox.Show("Некорректное число");
                return "Error. Incorrect input";
            }
        }

        public string DecToHex(string num)
        {
            int dec;
            string result = "0x";
            if (correctInt(num))
            {
                dec = int.Parse(num);

                for (int i = hexDepth(dec) - 1; i >= 0; i--)
                {
                    int add;
                    int temp = (int)Math.Pow(16, i);
                    if (dec > 16)
                        add = dec / temp;
                    else
                        add = dec;
                    if (add > 0)
                    {
                        if (add < 10)
                            result += (dec / temp).ToString();
                        else
                            result += (char)(55 + add);   //65 по ascii - это А и далее по порядку
                    }                        
                    else
                        result += "0";

                    dec %= temp;                                          
                }
                return result;
            }
            else
            {
                MessageBox.Show("Некорректное число");
                return "Error. Incorrect input";
            }
        }

        public int BinaryToDec(string num)
        {
            int result = 0;
            int power = 0;
            if(correctBinary(num))
            {
                for (int i = num.Length - 1; i >= 0; i--, power ++)
                {
                    if (num[i] == '1')
                        result += (int)(Math.Pow(2, power));
                }
            }
            else
            {
                MessageBox.Show("Некорректное число");
            }
            return result;
        }

        public int HexToDec(string num)
        {
            int result = 0;
            int power = 0;
            if(correctHex(num))
            {
                for (int i = num.Length - 1; i > 1; i--, power++)
                {
                    int asciiCode = (int)num[i];
                    if (asciiCode > 47 && asciiCode < 58)
                    {
                        result += (asciiCode - 48) * (int)Math.Pow(16, power);
                    }
                    else if(asciiCode > 64 && asciiCode < 71)
                    {
                        result += (asciiCode - 55) * (int)Math.Pow(16, power);
                    }                    
                }
            }
            else
            {
                MessageBox.Show("Некорректное число");
            }
            return result;
        }
    }
}

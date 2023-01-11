using System;

namespace HW7_T3
{
    internal class ForeignPassport
    {
        private string name;
        private string surname;
        private string fathersName;
        private string serial;
        private string number;
        private string dateInit;
        private string depInit;
        private bool isAWord(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int ascii = (int)input[i];
                if (ascii < 65 || ascii > 90 && ascii < 97 || ascii > 122 && ascii < 192)
                    return false;
            }
            return true;
        }
        private bool isANumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int ascii = (int)input[i];
                if (ascii < 48 && ascii > 57)
                    return false;
            }
            return true;
        }
        public string Name
        {
            get => name;
            set
            {
                try
                {
                    if (isAWord(value))
                        name = value;
                    else
                        throw new Exception("Недопустимые символы в имени");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
            
        public string Surname 
        { 
            get => surname; 
            set
            {
                try
                {
                    if (isAWord(value))
                        surname = value;
                    else
                        throw new Exception("Недопустимые символы в фамилии");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string FathersName 
        { 
            get => fathersName; 
            set
            {
                try
                {
                    if (isAWord(value))
                        fathersName = value;
                    else
                        throw new Exception($"Недопустимые символы в отчестве");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string Serial 
        { 
            get => serial;
            set
            {
                try
                {
                    if (isANumber(value))
                        serial = value;
                    else
                        throw new Exception("Недопустимое значение в номере");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
            }
        }
        public string Number
        {
            get => number;
            set
            {
                try
                {
                    if (isANumber(value))
                        number = value;
                    else
                        throw new Exception("Недопустимое значение в номере");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string DateInit 
        { 
            get => dateInit;
            set
            {
                try
                {
                    if (value.Length != 10)
                        throw new Exception("Неверное количество символов в дате");
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (i == 2 || i == 5)
                            i++;
                        if (!isANumber(value[i].ToString()))
                            throw new Exception("Неверный формат даты");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string DepInit { get => depInit; set => depInit = value; }

        public ForeignPassport(string Name, string Surname, string FathersName, string Serial, string Number, string DateInit, string DepInit)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.FathersName = FathersName;
            this.Serial = Serial;
            this.Number = Number;
            this.DateInit = DateInit;
            this.DepInit = DepInit;             
        }
    }
}

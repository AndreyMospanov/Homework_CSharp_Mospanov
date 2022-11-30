/*Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать 
его результат. Необходимо поддерживать только две операции: + и –.*/
namespace HW2_T5
{
    internal class Program
    {
        static int ArithmeticAct(int num1, int num2, char sign)
        {
            if (sign == '+')
                return num1 + num2;
            else if (sign == '-')
                return num1 - num2;
            else
                throw new ArgumentException("Ошибка ввода!");
        }
        static void Main(string[] args)
        {
            int tempInt;
            string input = string.Empty;
            string temp = string.Empty; 
            List<int> nums = new List<int>();
            List<char> signs = new List<char>();
            Console.WriteLine("Запишите арифметический пример для расчёта");
            input = Console.ReadLine();
            if(input != null)
            {
                input?.Replace(" ", "");
                if (int.TryParse(input[0].ToString(), out tempInt))
                    signs.Add('+');

                for (int i = 0; i < input.Length; i++)
                {
                    if (int.TryParse(input[i].ToString(), out tempInt))
                    {
                        temp += input[i];
                        if (i == input.Length - 1 || !int.TryParse(input[i + 1].ToString(), out tempInt))
                        {
                            nums.Add(int.Parse(temp));
                            temp = string.Empty;                            
                        }
                    }
                    else if (input[i] == '-' || input[i] == '+')
                    {
                        signs.Add(input[i]);
                    }
                }

                tempInt = 0;
                for (int i = 0; i < nums.Count; i++)
                {
                    tempInt = ArithmeticAct(tempInt, nums[i], signs[i]);
                }

                Console.WriteLine($"Результат вычислений {tempInt}");
            }
            else
            {
                Console.WriteLine("Вы ничего не ввели");
            }
        }
            
    }
}
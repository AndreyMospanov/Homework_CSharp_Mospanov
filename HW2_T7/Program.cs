/*Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно 
должно быть заменено на набор символов *. По итогам работы приложения необходимо показать статистику 
действий.*/
using System.Text;
namespace HW2_T7
{
    internal class Program
    {
        static string Censor(string inputText, string[] forbidden)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(inputText.ToLower());
            for (int i = 0; i < forbidden.Length; i++)
            {
                sb.Replace(forbidden[i], new string('*', forbidden[i].Length));
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string inputText = "To be, or not to be, that is the question,\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\nNo more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep";
            string[] forbidden = new string[] { "to", "die", "sleep" };
            Console.WriteLine(Censor(inputText, forbidden));
        }
    }
}
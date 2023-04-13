using System.Reflection.Metadata;
using System.Threading.Channels;


namespace DZ_CS_11
{
    using Dict = DictEngFrench;
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Enter how much words you want add:\t");
            int count = Convert.ToInt32(Console.ReadLine());
            do
            {
                Dict.AddWord();
                count--;
            } while (count > 0);
            Console.WriteLine();
            Console.WriteLine();
            Dict.ShowDict();
            Dict.RemoveWordFromDict();
            Dict.ShowDict();
            Dict.RemoveWordFromTranslation();
            Dict.ShowDict();
            Dict.ChangeEngWord();
            Dict.ShowDict();
            Dict.ChangeFrenchWord();
            Dict.ShowDict();
            Dict.SearchTranslate();


        }
        
        static void Ex1()
        {
            Personal personal = new Personal();
            personal.AddPersonToDataBase(new Person());
            personal.AddPersonToDataBase(new Person());
            personal.AddPersonToDataBase(new Person("QQQ", "WWW"));
            personal.AddPersonToDataBase(new Person("WWW", "QQQ"));
            personal.PrintData();
            personal.RemovePersonData("QQQ");
            Console.WriteLine();
            Console.WriteLine();
            personal.PrintData();
            personal.ChangeLoginAndPassword();
            Console.WriteLine();
            Console.WriteLine();
            personal.PrintData();
            Console.WriteLine();
            Console.WriteLine();
            personal.TakeInfoByLogin();
        }
    }
    
}
using System.Reflection.Metadata;
using System.Threading.Channels;


namespace DZ_CS_11
{
    using Dict = DictEngFrench;
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();


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
        static void Ex2()
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
        static void Ex3()
        {
            Queue queue = new Queue();
            queue.tables.Add(new Table());
            queue.tables.Add(new Table());
            queue.tables.Add(new Table());

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Client arrival");
                Console.WriteLine("2. Freeing the table");
                Console.WriteLine("3. Table reservation");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");

                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        queue.AddClient();
                        break;
                    case 2:
                        queue.TableFree();
                        break;
                    case 3:
                        queue.TableReservation();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Incorrect option, try again!!!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
    
}
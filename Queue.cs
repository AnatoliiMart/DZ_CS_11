using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CS_11
{
    internal class Queue
    {
        public  Queue<Client> queue = new Queue<Client>();
        public  List<Table> tables = new List<Table>();

        public void AddClient()
        {
            Console.WriteLine("Enter client's name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter the time for which the client wants to reserve a table:");
            DateTime reservationTime = Convert.ToDateTime(Console.ReadLine());

            Client client = new Client(name, reservationTime);
            queue.Enqueue(client);

            Console.WriteLine($"Client {client.Name} added to the queue.");
        }

        public void TableFree()
        {
            if (tables.Count > 0)
            {
                Table table = tables[0];
                tables.RemoveAt(0);

                if (queue.Count > 0)
                {
                    Client client = queue.Dequeue();
                    Console.WriteLine($"The table is free. Client {client.Name} occupies a table.");

                    table.Client = client;
                }
                else
                {
                    Console.WriteLine("The table is free. Queue is empty.");

                    table.Client = null;
                }
            }
            else
                Console.WriteLine("No free tables.");
        }

        public  void TableReservation()
        {
            Console.WriteLine("Enter client name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter the time for which the client wants to reserve a table:");
            DateTime reservationTime = Convert.ToDateTime(Console.ReadLine());

            Client client = new Client(name, reservationTime);
            Table? reservedTable = tables.Find(t => t.Client == null && t.ReservationTime == reservationTime);

            if (reservedTable != null)
            {
                reservedTable.Client = client;

                Console.WriteLine($"Table reserved for a client {client.Name} on time {client.ReservationTime}.");
            }
            else
                Console.WriteLine("There are no free tables at the indicated time.");
        }
    }

    class Client
    {
        public string? Name { get; set; }
        public DateTime ReservationTime { get; set; }

        public Client(string? name, DateTime reservationTime)
        {
            Name = name;
            ReservationTime = reservationTime;
        }
    }

    class Table
    {
        public Client? Client { get; set; }
        public DateTime ReservationTime { get; set; }

        public Table()
        {
            Client = null;
            ReservationTime = DateTime.MinValue;
        }
    }

}


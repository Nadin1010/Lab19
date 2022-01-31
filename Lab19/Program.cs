using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computer = new List<Computer>()
            {
                new Computer(){Num=1, Name="Westmere", Tipe = "DDR3-1333", ProcessorFreqency="32nm", RAM = 4, HardDiskCapacity="320Гб", VideoCardMemory="HD Graphics 2000 (3000)", Price=5000, QuantityInStock = 10},
                new Computer(){Num=2, Name="Sandy Bridge", Tipe = "DDR3-1600", ProcessorFreqency="32nm", RAM = 32, HardDiskCapacity="320Гб", VideoCardMemory="HD Graphics 4000 ",  Price=5500, QuantityInStock = 20},
                new Computer(){Num=3, Name="Ivy Bridge", Tipe = "DDR3-1600", ProcessorFreqency="22nm", RAM = 32, HardDiskCapacity="256Гб", VideoCardMemory="HD Graphics 4000 (5200)", Price=8000, QuantityInStock = 30},
                new Computer(){Num=4, Name="Haswell", Tipe = "DDR3-1600", ProcessorFreqency="22nm", RAM = 128, HardDiskCapacity="256Гб", VideoCardMemory="HD Graphics 2000 (3000)",  Price=10000, QuantityInStock = 35},
                new Computer(){Num=5, Name="Broadwell", Tipe = "DDR3-1600", ProcessorFreqency="14nm", RAM = 4, HardDiskCapacity="320Гб", VideoCardMemory="HD Graphics 2000 (3000)", Price=12000, QuantityInStock = 5},
                new Computer(){Num=6, Name="Sky lake", Tipe = "DDR3-1600/DDR4", ProcessorFreqency="14nm", RAM = 128, HardDiskCapacity="256Гб", VideoCardMemory="HD Graphics 6200",  Price=5000, QuantityInStock = 20},
                new Computer(){Num=7, Name="Kaby Lake", Tipe = "DDR3-1600/DDR4", ProcessorFreqency="14nm", RAM = 64, HardDiskCapacity="256Гб", VideoCardMemory="HD Graphics 520-580)" , Price=7000, QuantityInStock = 35},
                new Computer(){Num=8, Name="Coffee Lake", Tipe = "DDR4", ProcessorFreqency="14nm", RAM = 64, HardDiskCapacity="320Гб", VideoCardMemory="HD Graphics 2000 (3000)",  Price=4000, QuantityInStock = 40 },
            };

            Console.WriteLine("Тип процессора");
            string tipe = Console.ReadLine();
            List<Computer> computer1 = computer.Where(x => x.Tipe == tipe).ToList();
            Print(computer1);

            Console.WriteLine("Объем ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computer2 = computer.Where(x => x.RAM >= ram).ToList();
            Print(computer2);

            List<Computer> computer3 = computer.OrderBy(x => x.Price).ToList();
            Print(computer3);

            IEnumerable<IGrouping<string, Computer>> computer4 = computer.GroupBy(x => x.Type);
            foreach (IGrouping<string, Computer> gr in computer4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"{e.Num} {e.Name} {e.Tipe} {e.ProcessorFreqency} {e.RAM} {e.HardDiskCapacity} {e.VideoCardMemory}  {e.Price} {e.QuantityInStock}");
                }
            }

            Computer computer5 = computer.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Num} {computer5.Name} {computer5.Tipe} {computer5.ProcessorFreqency} {computer5.RAM} {computer5.HardDiskCapacity} {computer5.VideoCardMemory} {computer5.Price} {computer5.QuantityInStock}");


            Computer computer6 = computer.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer6.Num} {computer6.Name} {computer6.Tipe} {computer6.ProcessorFreqency} {computer6.RAM} {computer6.HardDiskCapacity} {computer6.VideoCardMemory} {computer6.Price} {computer6.QuantityInStock}");
           

            Console.WriteLine(computer.Any(x => x.QuantityInStock > 30));

            Console.ReadKey();

        }

        static void Print(List<Computer> computer)
        {
            foreach (Computer e in computer)
            {
                Console.WriteLine($"{e.Num} {e.Name} {e.Tipe} {e.ProcessorFreqency} {e.RAM} {e.HardDiskCapacity} {e.VideoCardMemory}  {e.Price} {e.QuantityInStock} ");
            }
            Console.WriteLine();
        }
    } 
}
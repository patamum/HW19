namespace Task19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() { Id = 1, Brand = "DEXP Atlas", Cpu = "AMD Rysen 5", CpuFreq = 4.4, HD = 512, Ram = 16, Vram = 6, Cost = 34999, Kol = 5 },
                new Computer() { Id = 2, Brand = "DEXP Atlas", Cpu = "AMD Rysen 5", CpuFreq = 4.4, HD = 256, Ram = 16, Vram = 4, Cost = 28999, Kol = 10 },
                new Computer() { Id = 3, Brand = "DEXP MINI SMART", Cpu = "Intel Core i3-10105", CpuFreq = 3.7, HD = 256, Ram = 8, Vram = 6, Cost = 30900, Kol = 8 },
                new Computer() { Id = 4, Brand = "Apple Mac Pro M2 Ultra", Cpu = "Apple M2 Ultra", CpuFreq = 3.5, HD = 1000, Ram = 64, Vram = 8, Cost = 1119999, Kol = 2 },
                new Computer() { Id = 5, Brand = "Ardor Gaming neo M136", Cpu = "Intel Core i3-12100F", CpuFreq = 3.3, HD = 512, Ram = 16, Vram = 4, Cost = 50290, Kol = 8 },
                new Computer() { Id = 6, Brand = "Acer Nitro N50-650", Cpu = "Intel Core i5-13400F", CpuFreq = 2.5, HD = 512, Ram = 16, Vram = 4, Cost = 103499, Kol = 80 },
                new Computer() { Id = 7, Brand = "Acer Nitro N50-650", Cpu = "Intel Core i5-13400F", CpuFreq = 3.5, HD = 512, Ram = 16, Vram = 4, Cost = 113499, Kol = 40 },
                new Computer() { Id = 8, Brand = "Raskat Strike 520", Cpu = "Intel Core i5-10400", CpuFreq = 2.9, HD = 512, Ram = 16, Vram = 12, Cost = 112400, Kol = 4 },
                new Computer() { Id = 9, Brand = "DEXP Atlas", Cpu = "AMD Rysen 5", CpuFreq = 3.4, HD = 512, Ram = 16, Vram = 4, Cost = 38999, Kol = 35 },
            };

            // Все компьютеры с указанным процессором.
            //Console.WriteLine("Введите процессор");
            //string cpu = Console.ReadLine();
            //List<Computer> computers1 = computers.Where(x => x.Cpu == cpu).ToList();
            //Print(computers1);

            //Все компьютеры с объемом ОЗУ не ниже, чем указано.
            //Console.WriteLine("Введите ОЗУ");
            //double rum = Convert.ToDouble(Console.ReadLine());
            //List<Computer> computers2 = computers.Where(x => x.Ram <= rum).ToList();
            //Print(computers2);

            //Список, отсоритрованный по увеличению стоимости.
            //List<Computer> computers3 = computers.OrderBy(x => x.Cost).ToList();
            //Print(computers3);

            //Список сгруппированный по типу процессора
            //IEnumerable<IGrouping<string, Computer>> computers4  = computers.GroupBy(x => x.Cpu);
            //foreach(IGrouping<string, Computer> gr in computers4)
            //{
            //    Console.WriteLine(gr.Key);
            //    foreach(Computer c in gr)
            //    {
            //        Console.WriteLine($"{c.Id} {c.Brand} процессор {c.Cpu} {c.CpuFreq} Стоимость {c.Cost}");
            //    }
            //}
            
            //Самый дорогой компьютер.
            //Computer computers5 = computers.OrderByDescending(x => x.Cost).FirstOrDefault();
            //Console.WriteLine("Самый дорогой компьютер");
            //Console.WriteLine($"{computers5.Id} {computers5.Brand} процессор {computers5.Cpu} частота {computers5.CpuFreq} ГГц Стоимость {computers5.Cost} руб.");

            //Самый бюджетный компьютер.
            //Computer computers6 = computers.OrderBy(x => x.Cost).FirstOrDefault();
            //Console.WriteLine("Самый бюджетный компьютер");
            //Console.WriteLine($"{computers6.Id} {computers6.Brand} процессор {computers6.Cpu} частота {computers6.CpuFreq} ГГц Стоимость {computers6.Cost} руб.");

            //Есть ли хотя бы один компьютер не менее 30 шт.
            Console.WriteLine(computers.Any(x => x.Kol >= 30) );

        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers) 
            { 
                Console.WriteLine($"{c.Id} {c.Brand} процессор {c.Cpu} частота {c.CpuFreq} ГГц, ОЗУ {c.Ram} Гб, SSD {c.HD} Гб, Стоимость {c.Cost}, Кол-во {c.Kol}  ");
                Console.WriteLine();
            }
        }
    }
}
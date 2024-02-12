namespace ConsoleAppS3L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> menu = new Dictionary<int, string>()
        {
            {1, "Coca Cola 150 ml (€ 2.50)"},
            {2, "Insalata di pollo (€ 5.20)"},
            {3, "Pizza Margherita (€ 10.00)"},
            {4, "Pizza 4 Formaggi (€ 12.50)"},
            {5, "Pz patatine fritte (€ 3.50)"},
            {6, "Insalata di riso (€ 8.00)"},
            {7, "Frutta di stagione (€ 5.00)"},
            {8, "Pizza fritta (€ 5.00)"},
            {9, "Piadina vegetariana (€ 6.00)"},
            {10, "Panino Hamburger (€ 7.90)"},
        };

            List<string> selectedItems = new List<string>();

            while (true)
            {
                Console.WriteLine("==============MENU==============");
                foreach (var item in menu)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("==============MENU==============");

                Console.Write("Inserisci il numero del cibo desiderato: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && menu.ContainsKey(choice))
                {
                    selectedItems.Add(menu[choice]);
                    Console.WriteLine($"Hai aggiunto: {menu[choice]}");
                }
                else if (choice == 11)
                {
                    PrintFinalBill(selectedItems);
                    break;
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Riprova.");
                }
            }
        }

        static void PrintFinalBill(List<string> items)
        {
            Console.WriteLine("\n==========CONTO FINALE==========");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            double totalCost = CalculateTotalCost(items);
            Console.WriteLine($"\nCosto finale (compreso servizio al tavolo di € 3.00): € {totalCost + 3.00}");
            Console.WriteLine("Grazie per l'ordine!");
        }

        static double CalculateTotalCost(List<string> items)
        {
            double totalCost = 0.0;
            foreach (var item in items)
            {
                string[] parts = item.Split('€');
                if (parts.Length == 2 && double.TryParse(parts[1], out double price))
                {
                    totalCost += price;
                }
            }
            return totalCost;
        }
    }
}

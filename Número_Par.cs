//Imprimir Números Pares.

for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    continue;

                Console.WriteLine(i);
            }
// Otra Manera
            
            Console.Write($"{(i % 2 == 0 ? i.ToString() : "\n")}");

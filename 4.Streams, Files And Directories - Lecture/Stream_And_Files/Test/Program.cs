using System;
using System.IO;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("input"))
            {
                int counter = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("output"))
                {
                    while (reader.EndOfStream)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

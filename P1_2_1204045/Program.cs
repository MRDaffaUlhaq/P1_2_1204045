using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204045
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("Aplikasi penentuan indeks prestasi mahasiswa\n============================================");
                Console.Write("\nMasukkan nama mahasiswa: ");

                String nama = Console.ReadLine();

                Console.WriteLine("Masukkan salah satu nilai mata kuliah: ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);

                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.Write("\nMasukkan indeks yang ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks prestasi {0} adalah ", nama);

                prestasi(indeks);

                Console.Write("\nIngin mengulang kembali (y/t) ? ");
            }

            while (Console.ReadLine() == "y");
        }
                
                private static void prestasi(char indeks)
                {
                    switch (indeks)
                    {
                        case 'A':
                            Console.WriteLine("Sangat Baik");
                            break;
                        case 'B':
                            Console.WriteLine("Baik");
                            break;
                        case 'C':
                            Console.WriteLine("Cukup Baik");
                            break;
                        case 'D':
                            Console.WriteLine("Kurang Baik");
                            break;
                        default:
                            Console.WriteLine("Invalid indeks prestasi");
                            break;

                    }
                }
          
        
    }
}

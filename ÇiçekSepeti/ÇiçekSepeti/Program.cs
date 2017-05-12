using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiçekSepeti
{
    class Program
    {
        static void Main(string[] args)
        {
            
            loadData();  // sabit verilerin class yapıları içerisine yüklenmesi
            
            Console.ReadLine();

        }

        private static void print(List<Bouquet> bouquetListP) {
            
            foreach (Bouquet bouquets in bouquetListP)
            {
                Console.Write(bouquets.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }

        private static void loadData() {

            string[] arrayBouquetName = new string[] { "Gül Bahçesi", "Gelinlikli Güller", "Orkide Buketi" };  // buket çeşit array'ı
            int[] arrayBouquetPrice = new int[] { 10, 15, 20, 12, 16, 20, 20, 25, 30 };  // fiyat array'ı
            int[] arrayContentValue = new int[] { 10, 5, 25, 10, 50, 15, 5, 20, 5, 7, 20, 10, 10, 20, 15, 1, 2, 5 }; // adet array'ı

            List<Bouquet> bouquetList = new List<Bouquet>();

            Bouquet bouquet;
            ContentList contentlist;
            List<Content> contents;
            

            int priceCounter = 0; // fiyat array sayacı
            int valueCounter = 0;  // adet array sayacı

            for (int i = 0; i < 3; i++)
            {
                bouquet = new Bouquet();
                bouquet.bouquetName = arrayBouquetName[i];

                for (int j = 0; j < 3; j++)
                {
                    contents = new List<Content>();

                    if (i == 0) // i döngüsü ile içerik tipleri arasında ilişki kuruldu
                    {  
                        contents.Add(rose(arrayContentValue[valueCounter]));
                        contents.Add(decorations(arrayContentValue[++valueCounter]));
                    }
                    else if (i == 1)
                    {
                        contents.Add(rose(arrayContentValue[valueCounter]));
                        contents.Add(camomile(arrayContentValue[++valueCounter]));
                        contents.Add(decorations(arrayContentValue[++valueCounter]));
                    }
                    else
                    {
                        contents.Add(orchid(arrayContentValue[valueCounter]));
                    }
                    valueCounter++;


                    switch (j)  // j döngüsü ile boyut arasında ilişki kuruldu
                    {
                        case 0:
                            contentlist = new ContentList(smallSize(), arrayBouquetPrice[priceCounter], contents);
                            bouquet.smallSize = contentlist;
                            priceCounter++;
                            break;
                        case 1:
                            contentlist = new ContentList(mediumSize(), arrayBouquetPrice[priceCounter], contents);
                            bouquet.mediumSize = contentlist;
                            priceCounter++;
                            break;
                        case 2:
                            contentlist = new ContentList(largeSize(), arrayBouquetPrice[priceCounter], contents);
                            bouquet.largeSize = contentlist;
                            priceCounter++;
                            break;
                    }

                }

                bouquetList.Add(bouquet);

            }

            print(bouquetList);

        }

        
        private static Content rose(int piece) {
            Content content = new Content("Gül", piece, new Features("Evet", "Evet", "Evet"));
            return content;

        }

        private static Content camomile(int piece)
        {
            Content content = new Content("Papatya", piece, new Features("Evet", "Hayır", "Evet"));
            return content;
        }


        private static Content orchid(int piece)
        {
            Content content = new Content("Orkide", piece, new Features("Evet", "Hayır", "Hayır"));
            return content;
        }


        private static Content decorations(int piece)
        {
            Content content = new Content("Süsleme", piece, new Features("Hayır", "Hayır", "Evet"));
            return content;
        }

        private static String smallSize()
        {
            return "Küçük boy";
        }

        private static String mediumSize()
        {
            return "Orta boy";
        }

        private static String largeSize()
        {
            return "Büyük boy";
        }





    }
}

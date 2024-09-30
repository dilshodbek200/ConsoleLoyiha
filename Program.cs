class Program
{
    public static void Main()
    {
        int son = 0;

        while(son != 19)
        {
            Console.WriteLine();
            Console.WriteLine("Matn taxrir qiluvchi dasturiga xush kelibsiz!");
            Console.WriteLine();
            Console.WriteLine("1. Matnni formatlash (Format)");
            Console.WriteLine("2. Matnni bo'laklarga ajratish (Split)");
            Console.WriteLine("3. Matndan substring olish (Substring)");
            Console.WriteLine("4. Matnlarni taqqoslash (Compare)");
            Console.WriteLine("5. Matnni almashtirish (Replace)");
            Console.WriteLine("6. Matn ichida so'z topish (Contains)");
            Console.WriteLine("7. Matnlarni birlashtirish (Join)");
            Console.WriteLine("8. Bo'sh joylarni olib tashlash (Trim)");
            Console.WriteLine("9. Matn oxirini tekshirish (EndsWith)");
            Console.WriteLine("10. Belgining indeksini aniqlash (IndexOf)");
            Console.WriteLine("11. Matnni o'chirish (Remove)");
            Console.WriteLine("12. Harflarni katta qilish (ToUpper)");
            Console.WriteLine("13. Harflarni kichik qilish (ToLower)");
            Console.WriteLine("14. Matnni chap tomondan to'ldirish (PadLeft)");
            Console.WriteLine("15. Matnni o'ng tomondan to'ldirish (PadRight)");
            Console.WriteLine("16. Matn boshini tekshirish (StartsWith)");
            Console.WriteLine("17. Matnni harflarga ajratish (ToCharArray)");
            Console.WriteLine("18. Oxirgi uchraydigan indeksni aniqlash (LastIndexOf)");
            Console.WriteLine("19. Chiqish");
            Console.WriteLine();

            Console.Write("Tanlang: ");
            son = Convert.ToInt32(Console.ReadLine());

            switch(son)
            {
                case 1:
                    Format();
                    break;
                case 2:
                    Split();
                    break;
                case 3:
                    Substring();
                    break;
                case 4:
                    Compare();
                    break;
                case 5:
                    Replace();
                    break;
                case 6:
                    Contains();
                    break;
                case 7:
                    Join();
                    break;
                case 8:
                    Trim();
                    break;
                case 9:
                    EndsWith();
                    break;
                case 10:
                    IndexOf();
                    break;
                case 11:
                    Remove();
                    break;
                case 12:
                    ToUpper();
                    break;
                case 13:
                    ToLower();
                    break;
                case 14:
                    PadLeft();
                    break;
                case 15:
                    PadRight();
                    break;
                case 16:
                    StartsWith();
                    break;
                case 17:
                    ToCharArray();
                    break;
                case 18:
                    LastIndexOf();
                    break;
                case 19:
                    Console.WriteLine("dasturdan chiqilmoqda...");
                    break;
                default:
                    Console.WriteLine("Noto'g'ri buyruq...");
                    break;
            }

            static void Format()
            {
                var soz1 = string.Format("Hello {0}", 123);
                Console.WriteLine(soz1);
                Console.WriteLine("sonni so'zga almashtiring");
                string soz = Console.ReadLine();
                Console.WriteLine("Hello {0}", soz);
            }
            static void Split()
            {
                Console.WriteLine("Matn Kiriting");
                string soz = Console.ReadLine();
                var natija = soz.Split(' ');

                for(int i = 0; i < soz.Length; i++)
                {
                    Console.WriteLine(soz[i]);
                }
            }
            static void Substring()
            {
                Console.WriteLine("Matn Kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("son kiriting");
                int tan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("son kiriting");
                int tan1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(soz.Substring(tan, tan1));
            }
            static void Compare()
            {
                Console.WriteLine("Birinchi matnni kiriting:");
                string firstText = Console.ReadLine()!;

                Console.WriteLine("Ikkinchi matnni kiriting:");
                string secondText = Console.ReadLine()!;

                int comparisonResult = string.Compare(firstText, secondText, StringComparison.Ordinal);

                Console.WriteLine("Taqqoslash natijasi: " + comparisonResult);

                if (comparisonResult < 0)
                {
                    Console.WriteLine("Birinchi matn ikkinchi matndan oldin keladi.");
                }
                else if (comparisonResult > 0)
                {
                    Console.WriteLine("Ikkinchi matn birinchi matndan oldin keladi.");
                }
                else
                {
                    Console.WriteLine("Ikkala matn bir xil.");
                }
            }
            static void Replace()
            {
                string soz = "Hello world";
                Console.WriteLine(soz);
                Console.WriteLine("qaysi sozni o'zgartirmoqchisiz");
                string tan1 = Console.ReadLine();
                Console.WriteLine("Qaysi so'zga o'zgartirmoqchisiz");
                string tan2 = Console.ReadLine();
                soz = soz.Replace(tan1, tan2);
                Console.WriteLine(soz);
            }
            static void Contains()
            {
                Console.WriteLine("Matn Kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("Qaysi so'zni qidiryapsiz");
                string tan = Console.ReadLine();
                Console.WriteLine(soz.Contains(tan));
            }
            static void Join()
            {
                Console.WriteLine("Qaysi matnlarni birlashtirishni xohlaysiz?");
        
                string[] texts = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    texts[i] = Console.ReadLine()!;
                }

                Console.WriteLine("Matnlarni qaysi belgi bilan ajratishni xohlaysiz?");
                string separator = Console.ReadLine()!;

                string joinedText = string.Join(separator, texts);

                Console.WriteLine("Birlashtirilgan matn: " + joinedText);
            }
            static void Trim()
            {
                Console.WriteLine("Matn Kiritng");
                string soz = Console.ReadLine();

                string natija = soz.Trim();
                Console.WriteLine(natija);
            }
            static void EndsWith()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("so'z kiriting");
                string son = Console.ReadLine();
                Console.WriteLine(soz.EndsWith(son));
            }
            static void IndexOf()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();

                Console.WriteLine("Qaysi harfni qidiryapsiz");
                string tan = Console.ReadLine();

                int natija = soz.IndexOf(tan);
                Console.WriteLine($"Siz qidirgan harf indexsi {natija}");
            }
            static void Remove()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("Qaysi indexdan boshlamoqchisiz");
                int son = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qaysi indexgacha");
                int son1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(soz.Remove(son, son1));
            }
            static void ToUpper()
            {
                Console.WriteLine("So'z kiriting");
                string soz = Console.ReadLine();
                string natija = soz.ToUpper();
                Console.WriteLine(natija);
            }
            static void ToLower()
            {
                Console.WriteLine("So'z kiriting");
                string soz = Console.ReadLine();
                string natija = soz.ToLower();
                Console.WriteLine(natija);
            }
            static void PadLeft()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("son kiriting");
                int son = Convert.ToInt32(Console.ReadLine());
                string natija = soz.PadLeft(son);
                Console.WriteLine(natija);
            }
            static void PadRight()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("son kiriting");
                int son = Convert.ToInt32(Console.ReadLine());
                string natija = soz.PadRight(son);
                Console.WriteLine(natija);
            }
            static void StartsWith()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("so'z kiriting");
                string son = Console.ReadLine();
                Console.WriteLine(soz.StartsWith(son));
            }
            static void ToCharArray()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();

                char[] harf = soz.ToCharArray();
                
                for(int i = 0; i < harf.Length; i++)
                {
                    Console.Write(harf[i]);
                }
            }
            static void LastIndexOf()
            {
                Console.WriteLine("Matn kiriting");
                string soz = Console.ReadLine();
                Console.WriteLine("harf kiriting");
                string harf = Console.ReadLine();
                var son = soz.LastIndexOf(harf);
                Console.WriteLine(son);
            }
        }
    }
}
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region 1: Sc
            //Sc("A");
            //#endregion

            //#region 2: sum
            //sum(15);
            //#endregion

            //#region 3: date
            //Console.WriteLine(date(DateTime.Now));
            //#endregion

            //#region 4:Mass
            //Mass();
            //#endregion

            //#region 5: Foo
            //Foo(5, 35);
            //#endregion

            //#region 6: Foo2
            //Foo2(65, -8);
            //#endregion

            //#region 7: Foo3
            // Foo3(25, 7);
            //#endregion

            //#region 8: forladder
            //forladder(9);
            //#endregion

            //#region 9: 
            //LostCard(5);
            //#endregion

            //#region 10: OtherString
            //StringReplace("ulan", "sfklklsrvess");

            //StringBuilderAppend("Ereke", "Arman", "Jalgas");

            //StringBuilderAppendFormat();
            //Console.WriteLine();

            //var sss= StringBuilderInsert("AAAA ssss DDDD");
            //Console.WriteLine(sss);

            //#endregion

            #region 11: StringTasks

            // Makingslices
            //Console.WriteLine("Resultat: " + Makingslices("Asulbek just do it"));
            //GC.Collect();
            //Console.WriteLine(GC.GetTotalMemory(false));


            //Numberofwords

            Console.WriteLine(Numberofwords("Asulbek, never give up!"));

            #endregion

            Console.Read();
        }


        #region 11: StringTasks
        private static string Makingslices(string sss)
        {
            string res = "";
            char[] sentense = sss.ToCharArray();

            //Сначала выведите третий символ этой строки.
            //for (int i = 1; i <= sentense.Length; i++)
            //{
            //    char s;
            //    if (i==3)
            //    {
            //        s = sentense[i];
            //        res = Convert.ToString(s);
            //        return res;
            //    }
            //}

            //Во второй строке выведите предпоследний символ этой строки.
            for (int i = sentense.Length; i >= 0; i--)
            {
                //if (i==sentense.Length-2)
                //    return Convert.ToString(sentense[i]);
            }

            //В третьей строке выведите первые пять символов этой строки.
            var builder = new StringBuilder(sss);
            //builder.Remove(5, sss.Length-5);
            //res = Convert.ToString(builder);

            //В четвертой строке выведите всю строку, кроме последних двух символов.

            //Console.WriteLine(GC.GetTotalMemory(false));
            //builder.Remove(sss.Length - 2, 2);
            //res = Convert.ToString(builder);
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect();

            //Console.WriteLine(GC.GetTotalMemory(false));

            // В пятой строке выведите все символы с четными индексами(считая, что индексация начинается с 0, поэтому символы выводятся начиная с первого).

            //var result = new StringBuilder();
            //for (int i = 0; i <= sss.Length - 1; i++)
            //{
            //    if (i % 2 == 0 == true)
            //    {
            //        result.Append(sss[i]);
            //    }
            //}
            //res = Convert.ToString(result);

            //В шестой строке выведите все символы с нечетными индексами, то есть начиная со второго символа строки.

            //var rees=new StringBuilder();
            //for (int i = 0; i < sss.Length - 1; i++)
            //{
            //    if (i % 2 == 1 == true)
            //        rees.Append(sss[i]);
            //}

            //res = Convert.ToString(rees);

            //В седьмой строке выведите все символы в обратном порядке.

            //res = Convert.ToString(new string(sss.Reverse().ToArray()));

            //В восьмой строке выведите все символы строки через один в обратном порядке, начиная с последнего.

            //string aaaaa=new string(sss.Reverse().ToArray());
            //Console.WriteLine(aaaaa);
            //var fff=new StringBuilder();
            //for (int i = 0; i <= aaaaa.Length - 1; i++)
            //{
            //    if (i % 2 == 0 == true)
            //        fff.Append(aaaaa[i]);
            //}

            //res = Convert.ToString(fff);

            //В девятой строке выведите длину данной строки.
            //res = Convert.ToString(sss.Length);
            return res;
        }

        private static string Numberofwords(string a)
        {
            string res = "";
            var qqq = a.Trim();
            Console.WriteLine(qqq);
            int k = 1;

            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] != 0 && a[i] == ' ')
                    k++;
                else if (a[i] == null)
                    k = 0;
            }

            res = Convert.ToString(k);




            return res;
        }
        #endregion

        #region 10: OtherString

        private static void StringReplace(string word, string builder)
        {
            var word2 = word.Replace('u', 'k');
            Console.WriteLine(word2);

            var builder2 = new StringBuilder(builder);
            builder2.Replace('s', 'd');
            Console.WriteLine(builder2);
        }

        private static void StringBuilderAppend(string a, string b, string c)
        {
            var builder = new StringBuilder(a);
            builder.Append(b);
            builder.Append(c);

            Console.WriteLine("1: " + builder);
            builder.AppendLine();
            Console.WriteLine("2: " + builder);
            builder.AppendLine("Assalaumagaleykum bauirim!");
            builder.Append("arkashan kulimdp jur, tebe idet");
            Console.WriteLine("3: " + builder);
        }

        private static void StringBuilderAppendFormat()
        {
            string name = "Peter";
            int age = 34;
            var builder = new StringBuilder();
            builder.AppendFormat("{0} is {1} years old", name, age);
            Console.WriteLine(builder);
        }

        private static string StringBuilderInsert(string sss)
        {
            var sentence = sss;
            var builder = new StringBuilder(sentence);
            builder.Insert(5, "ff ffdsss vvv");
            return builder.ToString();
        }
        #endregion

        #region 9: LostCard
        private static void LostCard(int n)
        {
            int[] s = new int[n];
            int k = 0;
            int[] temp = new int[n];

            int j;
            Random r = new Random();
            for (int i = 0; i <= s.Length; i++)
            {
                s[i] = r.Next(n - (n - 1), n);
                Console.Write(s[i] + "\t");
                Console.WriteLine();
                for (j = 0; j <= n; j++)
                {
                    if (s[j] != i)
                    {
                        temp[k] = j;
                        k++;
                    }
                }
                Console.Write(j + "\t");
            }

        }
        #endregion

        #region 8: forladder
        private static void forladder(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region 7: Foo3
        private static void Foo3(int a, int b)
        {
            if (a >= b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.Write(i + "\t");
                }
            }
        }
        #endregion

        #region 6: Foo2
        private static void Foo2(int a, int b)
        {
            if (a >= b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.Write(i + "\t");
                }
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    Console.Write(i + "\t");
                }
            }
        }
        #endregion

        #region 5: Foo
        private static void Foo(int a, int b)
        {
            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.Write(i + "\t");
                }
            }
            else
            {
                Console.WriteLine("A должено быть меньше B");
            }
        }
        #endregion

        #region 4: Mass
        private static void Mass()
        {
            int[,] m = new int[5, 5];
            Random ran = new Random();
            int temp;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    m[i, j] = ran.Next(1, 15);

                    if (m[i, j] > m[i, j + 1])
                    {
                        temp = m[i, j];
                        m[i, j] = m[i, j + 1];
                        m[i, ++j] = temp;
                    }
                    Console.Write("{0}\t", m[i, j]);
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region 3: Date
        private static string date(DateTime now)
        {
            string _date = Convert.ToString(now);
            for (int i = 0; i <= _date.Length; i++)
            {
                // if()
            }

            return _date;
        }
        #endregion

        #region 2: sum
        private static int sum(int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    s += i;
            }

            return s;
        }
        #endregion

        #region 1: Sc
        private static void Sc(string s)
        {
            switch (s)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("AAAAAAAAAAA");
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("DDDDDDDDDDDDDDDD");
                    break;
                default:
                    Console.WriteLine("ASASASASAS");
                    break;

            }
        }
        #endregion
    }
}

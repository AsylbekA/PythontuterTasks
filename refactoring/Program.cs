using System;

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



            Console.Read();
        }

        #region 8: forladder

        private static void forladder(int n)
        {
            for (int i=0;i<=n;i++)
            {
                for (int j = 0; j <= i; j++)
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
                     Console.Write(i+"\t");
                }
            }
        }
        #endregion

        #region 6: Foo2
        private static void Foo2(int a,int b)
        {
            if (a >= b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.Write(i+"\t");
                }
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    Console.Write(i+"\t");
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

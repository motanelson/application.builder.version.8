using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosSplit
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            while (true) 
            {


                splints.Main();
                var input = Console.ReadLine();
            }
            
        }
    }
    class splits
    {
        public static String[] uses(String strings, String separator)
        {
            String[] s = { };
            int i = 0;
            String ss = strings;
            while (true)
            {
                i = ss.IndexOf(separator);
                if (i == -1)
                {
                    Array.Resize(ref s, s.Length + 1);
                    s[s.Length - 1] = ss;
                    break;
                }

                Array.Resize(ref s, s.Length + 1);
                s[s.Length - 1] = ss.Substring(0, i);
                if (i + separator.Length >= ss.Length - 1) break;
                ss = ss.Substring(i + separator.Length);




            }


            return s;



        }



    }

    class splitstests
    {
        public static void mainloop()

        {
            String s = "<!><!>0<!>01<!>012<!>0123<!>01234<!>012345<!>0123456<!>01234567<!>012345678<!>0123456789<!>0123456789A<!>";
            String[] ss = splits.uses(s, "<!>");
            foreach (var sss in ss)
            {
                Console.WriteLine(sss);


            }


        }



    }











    class splints


    {
        public static void Main()
        {

            splitstests.mainloop();



        }




    }


}

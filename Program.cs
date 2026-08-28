class splits 
{
    public static String[] uses(String strings, String separator) 
    {
        String[] s = { };
        int i = 0;
        String ss = strings;
        while (true) 
        {
            i=ss.IndexOf(separator);
            if (i == -1) break;
            Array.Resize(ref s, s.Length+1);
            s[s.Length-1]=ss.Substring(0, i);
            if (i + separator.Length >= ss.Length) break;
            ss=ss.Substring(i+separator.Length);


        
        
        }


        return s;
    
    
    
    }



}

class splitstests 
{
    public static void mainloop() 
    
    {
        String s = "<!><!>0<!>01<!>012<!>0123<!>01234<!>012345<!>0123456<!>01234567<!>012345678<!>0123456789<!>";
        String[] ss= splits.uses(s,"<!>");
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
    
         Console.BackgroundColor=ConsoleColor.White;
         Console.ForegroundColor=ConsoleColor.Black;

         splitstests.mainloop();



    }




}


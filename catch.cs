using System;
using System.IO;

class Catch
{
    public static string ActionPhrase()
    {
        string file = "catchphrase.txt";
        StreamReader temps = new StreamReader(file);
        StreamReader sr = new StreamReader(file);
        int count = 0;
        string temp = null;
        Random rnd = new Random();
        string phrase;
        int choose; 

        while (!temps.EndOfStream)
        {
            temp = temps.ReadLine();
            count++;
           
        }
        string [] catchphrase = new string [count];

        for (int i = 0; i < count; i++)
        {
            catchphrase[i] = sr.ReadLine();
        }
        
        sr.Dispose();
        temps.Dispose();
        choose = rnd.Next(0,count);
        phrase = catchphrase[choose];
        return phrase;
    }
    public static string ExclaimPhrase()
    {
        string file = "exclaimphrase.txt";
        StreamReader temps = new StreamReader(file);
        StreamReader sr = new StreamReader(file);
        int count = 0;
        string temp = null;
        Random rnd = new Random();
        string phrase;
        int choose; 

        while (!temps.EndOfStream)
        {
            temp = temps.ReadLine();
            count++;
           
        }
        string [] catchphrase = new string [count];

        for (int i = 0; i < count; i++)
        {
            catchphrase[i] = sr.ReadLine();
        }
        
        sr.Dispose();
        temps.Dispose();
        choose = rnd.Next(0,count);
        phrase = catchphrase[choose];
        return phrase;
    }
    
    /*static void Main()
    {
        Console.WriteLine(Program.CatchPhrase());

    }*/
}
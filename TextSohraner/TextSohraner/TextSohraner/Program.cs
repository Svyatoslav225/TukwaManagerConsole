using System;
using System.IO;
using System.Text;

while (true) 
{
    string text;
    string path;
    string name;
    string chose;
    string pathR;
    string nameR;

    Console.WriteLine("\nChose operation: \n 1 - Create file \n 2 - Read file");
    chose = Console.ReadLine();

    if (chose == "1")
    {
        
            Console.WriteLine("Enter Path to file:");
            path = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter text:");
        
        text = " ";
        do
        {
            string str;
            Console.Write(">>> ");
            str = Console.ReadLine();
            if (str == "exit")
            {
                break;
            }
            text += "\n " + str;
        } while (true);


            Console.WriteLine("\n Compiling. . .");

            BinaryWriter bw = new BinaryWriter(new FileStream(path + "/" + name + ".txt", FileMode.Create));
            bw.Write(text);
            bw.Close();

            Console.WriteLine("\nFile was created!");
            Console.WriteLine("You can see this file here: " + path + "/" + name + ".txt");
        
    } else if (chose == "2")
    {
        Console.WriteLine("Enter Path to file:");
        pathR = Console.ReadLine();
        Console.WriteLine("Enter file name :");
        nameR = Console.ReadLine();

        BinaryReader br = new BinaryReader(new FileStream(pathR + nameR + ".txt", FileMode.Open));
        Console.WriteLine("Text in file:\n");
        Console.Write(br.ReadString());
        br.Close();
    } else
    {
        Console.WriteLine("Exeption!");
        return;
    }
}


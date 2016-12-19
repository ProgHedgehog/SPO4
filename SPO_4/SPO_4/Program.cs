using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPO_4
{
    class Program
    {
        static string GetName(System.Diagnostics.Process instance)
        {
            string pr_name = instance.ProcessName.ToString();
            if (pr_name.Length > 10)
            {
                pr_name = pr_name.Substring(0, 10);
            }
            return pr_name;
        }

        static string GetTotalTime(System.Diagnostics.Process instance)
        {
            string time = instance.TotalProcessorTime.ToString();
            time = time.Substring(0, 10);
            return time;
        }
        static string GetStartTime(System.Diagnostics.Process instance)
        {
            string time = instance.StartTime.ToString();
            time = time.Substring(0, 10);
            return time;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите команду");
                string s = Console.ReadLine();
                string f = "";
                System.Diagnostics.Process[] processes;
                processes = System.Diagnostics.Process.GetProcesses();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '-')
                    {
                        f = s.Substring(i-1,i);
                        f = f.Trim();
                    }
                }
                    if (f == "-e")
                {
                    Console.Write("PID" + " | ");
                    Console.Write("TTY" + " | ");
                    Console.Write("TIME" + " | ");
                    Console.WriteLine();
                    foreach (System.Diagnostics.Process instance in processes)
                    {
                        if (instance.Id != 0)
                        {
                            Console.Write(instance.Id + "   "); //PID
                            Console.Write(GetName(instance) + "   ");
                            //Console.Write(instance.PagedMemorySize + "   "); //MEM

                        }
                        try
                        {
                            Console.Write(GetTotalTime(instance) + "     ");
                        }
                        catch
                        {
                        }
                        Console.WriteLine();
                    }
                }
                if (f == "-f")
                {
                    Console.Write("USER" + " | ");
                    Console.Write("PID" + " | ");
                    Console.Write("TTY" + " | ");
                    Console.Write("STIME" + " | ");
                    Console.Write("TTIME" + " | ");

                    Console.WriteLine();
                    foreach (System.Diagnostics.Process instance in processes)
                    {
                        if (instance.Id != 0)
                        {
                            Console.Write(instance.MachineName + "   "); //User
                            Console.Write(instance.Id + "   "); //PID
                            Console.Write(GetName(instance) + "   "); //TTY

                        }
                        try
                        {
                            Console.Write(GetStartTime(instance) + "     ");
                            Console.Write(GetTotalTime(instance) + "     ");
                        }
                        catch
                        {
                        }
                        Console.WriteLine();
                    }
                }
                if (f == "-l")
                {
                    Console.Write("USER" + " | ");
                    Console.Write("PID" + " | ");
                    Console.Write("TTY" + " | ");
                    Console.Write("SessionId" + " | ");
                    Console.Write("TTIME" + " | ");

                    Console.WriteLine();
                    foreach (System.Diagnostics.Process instance in processes)
                    {
                        if (instance.Id != 0)
                        {
                            Console.Write(instance.MachineName + "   "); //User
                            Console.Write(instance.Id + "   "); //PID
                            Console.Write(GetName(instance) + "   "); //TTY
                            Console.Write(instance.SessionId + "   "); //SessionId
                        }
                        try
                        {
                            Console.Write(GetTotalTime(instance) + "     ");
                        }
                        catch
                        {
                        }
                        Console.WriteLine();
                    }
                }
                if (f == "-u")
                {
                    Console.Write("USER" + " | ");
                    Console.Write("PID" + " | ");
                    Console.Write("MEM" + " | ");
                    Console.Write("TTY" + " | ");
                    Console.Write("INFO" + " | ");
                    Console.Write("STIME" + " | ");
                    Console.Write("TTIME" + " | ");
                    Console.WriteLine();
                    foreach (System.Diagnostics.Process instance in processes)
                    {
                        if (instance.Id != 0)
                        {
                            Console.Write(instance.MachineName + "   "); //User
                            Console.Write(instance.Id + "   "); //PID
                            Console.Write(instance.VirtualMemorySize + "   "); //MEM
                            Console.Write(GetName(instance) + "   "); //TTY
                            Console.Write(instance.StartInfo + "   "); //MEM
                        }
                        try
                        {
                            Console.Write(GetStartTime(instance) + "     ");
                            Console.Write(GetTotalTime(instance) + "     ");
                        }
                        catch
                        {
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        
    }
}

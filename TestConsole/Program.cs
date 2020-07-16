using RetrieverCore.IO.Gatherer;
using RetrieverCore.Models.WindowsModels.Win32Entities;
using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            Console.ReadLine();

            //var input = new StreamReader(File.Open("test.txt", FileMode.Open));
            //var output = new StreamWriter(File.Open("output.txt", FileMode.OpenOrCreate));

            //while (true)
            //{
            //    var line = input.ReadLine();
            //    if (string.IsNullOrWhiteSpace(line))
            //    {
            //        break;
            //    }
            //    var match = Regex.Match(line, @" \(\d{1,5}\)");
            //    if (!match.Success)
            //    {
            //        throw new Exception();
            //    }

            //    line = line.Replace("xxxx", match.Value.Replace("(", "")
            //                                        .Replace(")", "")
            //                                        .Replace(" ", ""));
            //    line = line.Replace(match.Value, "\";");
            //    output.WriteLine(line);
            //}


            //input.Close();
            //output.Close();

            //Console.WriteLine("ENTER TO CLOSE");
            //Console.ReadLine();

        }
    }
}

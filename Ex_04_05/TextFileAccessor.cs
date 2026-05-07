using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Ex_04_05
{
    public class TextFileAccessor
    {
        public static void Write(string fileName, List<string> datas)
        {
            StreamWriter writer = null!;
            try
            {
                writer = new StreamWriter(fileName);
                foreach(string line in datas)
                {
                    writer.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(writer != null)
                {
                    Console.WriteLine("ファイルにデータを書き込みました。");
                    writer.Close();
                }
            }
        }

        public static void ReadAndPrint(string fileName)
        {
            StreamReader reader = null!;
            try
            {
                reader = new StreamReader(fileName);
                string line = "";
                while((line = reader.ReadLine()!) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(reader != null)
                {
                    Console.WriteLine("ファイルのデータを読み取りました。");
                    reader.Close();
                }
            }
        }
    }
}
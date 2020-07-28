using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecResource();

            ExecResourceCopy();
            Console.ReadKey();
        }

        public static void ExecResource()
        {
            FileStream fs = null;
            string path = @"C:\temp\outro.txt";
            string destPath = @"C:\temp\Teste.txt";

            try
            {
                fs = new FileStream(path, FileMode.CreateNew, FileAccess.ReadWrite);
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.ToString());
                if (!File.Exists(destPath))
                {
                    var newPath = path.Replace("Teste", "outro");
                    //tenta criar o arquivo com novo path
                    fs = new FileStream(newPath, FileMode.CreateNew, FileAccess.ReadWrite);
                }
            }
            finally
            {
                if (fs != null) fs.Dispose();
            }
        }

        public static void ExecResourceCopy()
        {
            string path = @"C:\temp\outro.txt";
            string destPath = @"C:\temp\Teste.txt";

            using (TextReader txt = new StreamReader(path))
            {
                if (!File.Exists(path))
                {
                    File.Copy(path, destPath);
                    Console.WriteLine("Arquivo copiado com sucesso.");
                }
            }
        }


    }
}

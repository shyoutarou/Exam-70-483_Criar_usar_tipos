using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable_finalizador
{
    public class MinhaClasse : IDisposable
    {
        //Construtor
        public MinhaClasse()
        {//inicialização
        }

        //Destruidor também chamado Finalize
        ~MinhaClasse()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            //código para liberar os recursos não gerenciados
        }
    }

    class ResourceExample : IDisposable
    {
        bool disposed = false;
        //se quiser sobrescrever (override) o finalizer, passe false no Dispose(disposing)
        ~ResourceExample()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                //libera recursos gerenciados pela CLR
            }
            //else: libera recursos não gerenciados pela CLR
            disposed = true;
        }
    }

    class UnmangedWrapper : IDisposable
    {
        bool disposed = false;
        public FileStream Stream { get; private set; }
        public UnmangedWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }
        ~UnmangedWrapper()
        {
            Dispose(false);
        }
        public void Close()
        {
            Dispose();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                if (Stream != null)
                {
                    Stream.Close();
                }
            }
            disposed = true;
        }
    }

    class DisposableClass : IDisposable
    { 
        // A name to keep track of the object. 
        public string Name = "";
        // Free managed and unmanaged resources. 
        public void Dispose()
        {
            FreeResources(true);
        }

        // Destructor to clean up unmanaged resources but not managed resources. 
        ~DisposableClass()
        {
            FreeResources(false);
        }

        // Keep track if whether resources are already freed. 
        private bool ResourcesAreFreed = false;
        
        // Free resources. 
        private void FreeResources(bool freeManagedResources)
        {
            Console.WriteLine(Name + ": FreeResources");
            if (!ResourcesAreFreed)
            {
                // Dispose of managed resources if appropriate. 
                if (freeManagedResources)
                {
                    // Dispose of managed resources here. 
                    Console.WriteLine(Name + ": Dispose of managed resources");
                }

                // Dispose of unmanaged resources here. 
                Console.WriteLine(Name + ": Dispose of unmanaged resources");
                // Remember that we have disposed of resources. 
                ResourcesAreFreed = true;
                // We don't need the destructor because 
                // our resources are already freed. 
                GC.SuppressFinalize(this);
            }
        }
    }

    class Person { }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
        }
    }
}

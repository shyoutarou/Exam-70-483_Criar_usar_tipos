using System;

namespace Override_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Teste 1========");
            BaseClass bc = new BaseClass();
            bc.DoWork();
            // Calls the new method BaseClass.
            //BaseClass valor virtual int WorkProperty(1) = 1
            //BaseClass valor int WorkField++ é: 1

            BaseClass dc = new DerivedClass();
            dc.DoWork();
            // Calls the new method DerivedClass.
            //DerivedClass valor override WorkProperty(2) é: 2
            //DerivedClass valor int (BaseClass) WorkField++ é: 1

            Console.WriteLine("=======Teste 2========");

            BaseClass bc_dc = (BaseClass)dc;
            bc_dc.DoWork();
            // Also calls the new method DerivedClass.
            //BaseClass valor virtual int WorkProperty(1) = 2
            //BaseClass valor int WorkField++ é: 2

            Console.WriteLine("=======Teste 3========");

            NewDerivedClass ndc_first = new NewDerivedClass();
            ndc_first.DoWork();
            // Calls the new method NewDerivedClass.
            //NewDerivedClass valor override WorkProperty(3) é: 3
            //NewDerivedClass valor int new WorkField++ é: 1

            BaseClass ndc_sec = new NewDerivedClass();
            ndc_sec.DoWork();
            //BaseClass valor virtual int WorkProperty(1) = 1
            //BaseClass valor int WorkField++ é: 1

            BaseClass ndc_third = (BaseClass)ndc_first;
            ndc_third.DoWork();
            //Calls the old method BaseClass.
            //BaseClass valor virtual int WorkProperty(1) = 1
            //BaseClass valor int WorkField++ é: 1

            NewDerivedClass ndc_four = (NewDerivedClass)ndc_third;
            ndc_four.DoWork();
            //Calls again the ndc_first method NewDerivedClass.
            //NewDerivedClass valor override WorkProperty(3) é: 3
            //NewDerivedClass valor int new WorkField++ é: 2

            BaseClass ndc_five = (NewDerivedClass)ndc_third;
            ndc_five.DoWork();
            //Calls again the ndc_third method BaseClass.
            //BaseClass valor virtual int WorkProperty(1) = 1
            //BaseClass valor int WorkField++ é: 2

            Console.WriteLine("=======Teste 4========");

            BaseClass multi_bc = new BaseClass();
            multi_bc.DoWork();
            // Calls the new method BaseClass.
            //BaseClass valor virtual int WorkProperty(1) = 1
            //BaseClass valor int WorkField++ é: 1

            BaseClass multi_dc = new DerivedClass();
            multi_dc.DoWork();
            // Calls the new method DerivedClass.
            //DerivedClass valor override WorkProperty(2) é: 2
            //DerivedClass valor int (BaseClass) WorkField++ é: 1

            BaseClass multi_th = new ThirdClass();
            multi_th.DoWork();
            //ThirdClass valor override WorkProperty(3) é: 3
            //ThirdClass valor int (BaseClass) WorkField++ é: 1      

            BaseClass multi_de_th = (DerivedClass)multi_th;
            multi_de_th.DoWork();
            //ThirdClass valor override WorkProperty(3) é: 3
            //ThirdClass valor int (BaseClass)WorkField++ é: 2

            //FourthClass NÃO implementa o método DoWork
            //Então utiliza o método virtual da classe herdada DerivedClass
            BaseClass multi_bc_fo = new FourthClass();
            multi_bc_fo.DoWork();
            //DerivedClass valor override WorkProperty(2) é: 4
            //DerivedClass valor int (BaseClass) WorkField++ é: 1

            Console.ReadKey();
        }
    }

    public class BaseClass
    {
        public int WorkField;
        public virtual void DoWork()
        {
            WorkField++;
            Console.WriteLine("BaseClass valor virtual int WorkProperty(1) = " + WorkProperty);
            Console.WriteLine("BaseClass valor int WorkField++ é: " + WorkField);
        }
        public virtual int WorkProperty
        {
            get
            {
                return 1;
            }
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void DoWork()
        {
            //WorkField++;
            //Console.WriteLine("DerivedClass valor override WorkProperty(2) é: " + WorkProperty);
            //Console.WriteLine("DerivedClass valor int (BaseClass)WorkField++ é: " + WorkField);

            //Metodo alternativa de chamada direta da classe base
            base.DoWork();
        }
        public override int WorkProperty
        {
            get
            {
                return 2;
            }
        }
    }

    public class NewDerivedClass : BaseClass
    {
        public new int WorkField;
        public new void DoWork()
        {
            WorkField++;
            Console.WriteLine("NewDerivedClass valor override WorkProperty(3) é: " + WorkProperty);
            Console.WriteLine("NewDerivedClass valor int new WorkField++ é: " + WorkField);
        }
        public new int WorkProperty
        {
            get { return 3; }
        }
    }

    public class ThirdClass : DerivedClass
    {
        public override void DoWork()
        {
            WorkField++;
            Console.WriteLine("ThirdClass valor override WorkProperty(3) é: " + WorkProperty);
            Console.WriteLine("ThirdClass valor int (BaseClass)WorkField++ é: " + WorkField);
        }
        public override int WorkProperty
        {
            get
            {
                return 3;
            }
        }
    }

    public class FourthClass : DerivedClass
    {
        public void Dont_Work()
        {
            WorkField++;
            Console.WriteLine("FourthClass valor override WorkProperty(4) é: " + WorkProperty);
            Console.WriteLine("FourthClass valor int (BaseClass)WorkField++ é: " + WorkField);
        }
        public override int WorkProperty
        {
            get
            {
                return 4;
            }
        }
    }

    public class SealedThirdClass : DerivedClass
    {
        public sealed override void DoWork()
        {
            WorkField++;
            Console.WriteLine("SealedThirdClass valor override WorkProperty(3) é: " + WorkProperty);
            Console.WriteLine("SealedThirdClass valor int (BaseClass)WorkField++ é: " + WorkField);
        }
        public override int WorkProperty
        {
            get
            {
                return 3;
            }
        }
    }

    public class DerivaSeal_FourthClass : SealedThirdClass
    {
        public new void DoWork()
        {
            WorkField++;
            Console.WriteLine("FourthClass valor override WorkProperty(34) é: " + WorkProperty);
            Console.WriteLine("FourthClass valor int (BaseClass)WorkField++ é: " + WorkField);
        }
        public override int WorkProperty
        {
            get
            {
                return 4;
            }
        }
    }

    public sealed class REALLYSealedDerivedClass : DerivedClass
    {
        public sealed override void DoWork()
        {
            WorkField++;
            Console.WriteLine("SealedDerivedClass valor é: " + WorkProperty + " WorkField=" + WorkField);
        }
    }

    //Não é possível herdar de classe SELADA
    //public class New_FromSealedDerivedClass : REALLYSealedDerivedClass
    //{
    //    public new void DoWork()
    //    {
    //        Console.WriteLine("New_FromSealedDerivedClass valor é: " + WorkProperty + " WorkField=" + WorkField);
    //    }
    //    public new int WorkProperty
    //    {
    //        get { return 9999; }
    //    }
    //}

}

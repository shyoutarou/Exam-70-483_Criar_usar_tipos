namespace EXE_Example
{
    class A { public int Random { get; set; } }
    class B : A { }

    class Program
    {
        static void Main(string[] args)
        {
            EscreverMsg("Hello Word");
        }

        public static string EscreverMsg(string txt)
        {
            return txt;
        }
    }
}

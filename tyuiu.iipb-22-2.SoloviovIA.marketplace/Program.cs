namespace tyuiu.iipb_22_2.SoloviovIA.marketplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dates = new(2006, 12, 7);
            List<Salesman> list = new List<Salesman>();
            list.Add(new Salesman("soloviov", dates));
            list.Add(new Salesman("ivanov", dates));
            list.Add(new Salesman("petrov", dates));
            list.Add(new Salesman("hui", dates));
            foreach (Salesman slk in list)
            {
                Console.WriteLine(slk.Name);
            }
        }
    }
}
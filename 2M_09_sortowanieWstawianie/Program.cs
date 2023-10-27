namespace _2M_09_sortowanieWstawianie
{
    class SortWstawianie
    {
        private const int N = 50;
        private int[] liczby = new int[N];
        private int poz = 0;
        public int x { set
            {
                if(poz < N)
                    liczby[poz++] = value;
            } 
        }
        public SortWstawianie()
        {

        }
        public void sortuj()
        {
            for(int i = 0; i < N; i++)
            {
                int p = znajdzMaks(i);
                int maks = liczby[p];
                for(int j = p; j<=p-i ; j--) // poprawić warunrk
                    liczby[j] = liczby[j-1]; 

                liczby[i] = maks;
            }
        }
        private int znajdzMaks(int p)
        {
            int maks = liczby[p];
            int mi = p;
            for(int i = p; i < N; i++)
                if (liczby[i] > maks)
                {
                    maks = liczby[i];
                    mi = i;
                }
            return mi;
        }
        public override string ToString()
        {
            string s = "";
            for(int i= 0;i<N;i++)
                s+= liczby[i].ToString()+", ";
            return s;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 50;
            Random random = new Random();
            Console.WriteLine($"podaj {N} liczb");
            SortWstawianie s = new SortWstawianie();
            for(int i=0; i<N; i++)
            {
                //s.x = int.Parse(Console.ReadLine());
                s.x = random.Next(1,100);
            }
            Console.WriteLine(s);
            

        }
    }
}
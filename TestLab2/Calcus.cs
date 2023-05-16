namespace TestLab2
{
    public class Num
    {
        private int num1;
        private int num2;
        private int num3;

        public Num(int n1, int n2, int n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
        }

        public int Summ()
        {
            return num1 + num2 + num3;
        }

        public double SummPow() 
        {
            return Math.Pow(num1 + num2 + num3, 2);
        }

        public double SummSqrt()
        {
            return Math.Sqrt(num1 + num2 + num3);
        }
        public override string ToString()
        {
            string str;
            str = ("\nПервая: " + num1 + "\n");
            str += ("Вторая: " + num2 + "\n");
            str += ("Третья: " + num3);
            return str;
        }

    }

    class Calcus
    {
        static void Main(string[] args)
        {
            Num num = new Num(2, 3, 6);
            Console.WriteLine("Сумма: " + num.Summ());
            Console.WriteLine("Степень 2 из суммы чисел: " + num.SummPow());
            Console.WriteLine("Корень из суммы чисел: " + num.SummSqrt());
            Console.WriteLine(num.ToString());
            Console.ReadKey();
        }
    }
}

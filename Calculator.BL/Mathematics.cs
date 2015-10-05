namespace Calculator.BL
{
    public class Mathematics : IMathematics
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }
    }
}

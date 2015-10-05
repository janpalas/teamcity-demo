namespace Calculator.BL
{
    public interface IUserInterface
    {
        MathematicModel ReadModel();
        void WriteResult(int result);
    }
}

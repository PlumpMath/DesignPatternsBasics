namespace BankingSystem
{
    public interface IBankingProduct
    {
        double Balance { get; }
        void Evaluate();
    }
}

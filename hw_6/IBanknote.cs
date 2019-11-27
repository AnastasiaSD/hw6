namespace hw_6
{
    public interface IBanknote
        {
            CurrencyType Currency { get; }
            int Value { get; }
        } 
}
namespace hw_6
{
    public class Banknote : IBanknote
    {
        public Banknote(CurrencyType currency, int value)
        {
            Currency = currency;
            Value = value;
        }

        public CurrencyType Currency { get; }
        public int Value { get; }

        public override string ToString()
        {
            return "Валюта: " + Currency + "; Номинал: " + Value;
        }
    }
}
namespace hw_6.Euro
{
    public class FiveHundredEuroHandler : EuroHandlerBase
    {
        protected override int Value => 500;

        public FiveHundredEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
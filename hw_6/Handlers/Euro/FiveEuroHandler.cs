namespace hw_6.Euro
{
    public class FiveEuroHandler : EuroHandlerBase
    {
        protected override int Value => 5;

        public FiveEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
namespace hw_6.Euro
{
    public class TwentyEuroHandler : EuroHandlerBase
    {
        protected override int Value => 20;

        public TwentyEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
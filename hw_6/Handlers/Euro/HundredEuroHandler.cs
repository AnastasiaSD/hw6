namespace hw_6.Euro
{
    public class HundredEuroHandler : EuroHandlerBase
    {
        protected override int Value => 100;

        public HundredEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
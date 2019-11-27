namespace hw_6
{
    public class TwentyDollarHandler : DollarHandlerBase
    {
        protected override int Value => 20;

        public TwentyDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
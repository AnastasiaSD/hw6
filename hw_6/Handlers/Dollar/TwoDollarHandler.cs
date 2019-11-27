namespace hw_6
{
    public class TwoDollarHandler : DollarHandlerBase
    {
        protected override int Value => 2;

        public TwoDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
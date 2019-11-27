namespace hw_6
{
    public class FiveHundredDollarHandler : DollarHandlerBase
    {
        protected override int Value => 500;

        public FiveHundredDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
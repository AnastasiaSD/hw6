namespace hw_6
{
    public class ThousandDollarHandler : DollarHandlerBase
    {
        protected override int Value => 1000;

        public ThousandDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
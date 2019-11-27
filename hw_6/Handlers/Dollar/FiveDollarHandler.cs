namespace hw_6
{
    public class FiveDollarHandler : DollarHandlerBase
    {
        protected override int Value => 5;

        public FiveDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
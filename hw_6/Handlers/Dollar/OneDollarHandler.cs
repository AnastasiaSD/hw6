namespace hw_6
{
    public class OneDollarHandler : DollarHandlerBase
    {
        protected override int Value => 1;

        public OneDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
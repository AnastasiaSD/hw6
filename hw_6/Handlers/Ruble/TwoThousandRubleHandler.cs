namespace hw_6.Ruble
{
    public class TwoThousandRubleHandler : RubleHandlerBase
    {
        protected override int Value => 2000;

        public TwoThousandRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
namespace hw_6.Ruble
{
    public class TwoHundredRubleHandler : RubleHandlerBase
    {
        protected override int Value => 200;

        public TwoHundredRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
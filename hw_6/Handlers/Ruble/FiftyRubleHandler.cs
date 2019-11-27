namespace hw_6.Ruble
{
    public class FiftyRubleHandler : RubleHandlerBase
    {
        protected override int Value => 50;

        public FiftyRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
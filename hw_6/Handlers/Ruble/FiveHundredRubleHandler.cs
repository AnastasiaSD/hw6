namespace hw_6.Ruble
{
    public class FiveHundredRubleHandler : RubleHandlerBase
    {
        protected override int Value => 500;

        public FiveHundredRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
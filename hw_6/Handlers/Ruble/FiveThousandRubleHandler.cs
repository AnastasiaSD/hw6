namespace hw_6.Ruble
{
    public class FiveThousandRubleHandler : RubleHandlerBase
    {
        protected override int Value => 5000;

        public FiveThousandRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
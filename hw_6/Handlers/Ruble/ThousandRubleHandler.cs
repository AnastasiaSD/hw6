namespace hw_6.Ruble
{
    public class ThousandRubleHandler : RubleHandlerBase
    {
        protected override int Value => 1000;

        public ThousandRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
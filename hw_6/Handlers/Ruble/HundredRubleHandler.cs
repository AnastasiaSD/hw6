namespace hw_6.Ruble
{
    public class HundredRubleHandler : RubleHandlerBase
    {
        protected override int Value => 100;

        public HundredRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
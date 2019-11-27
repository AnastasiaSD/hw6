namespace hw_6.Ruble
{
    public class TenRubleHandler : RubleHandlerBase
    {
        protected override int Value => 10;

        public TenRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
using System.Collections.Generic;
using hw_6.Euro;
using hw_6.Ruble;

namespace hw_6
{
    public class Bancomat
    {
        private readonly BanknoteHandler _handler;

        public Bancomat()
        {
            _handler = new TenRubleHandler(null);
            _handler = new FiftyRubleHandler(_handler);
            _handler = new HundredRubleHandler(_handler);
            _handler = new TwoHundredRubleHandler(_handler);
            _handler = new FiveHundredRubleHandler(_handler);
            _handler = new ThousandRubleHandler(_handler);
            _handler = new TwoThousandRubleHandler(_handler);
            _handler = new FiveThousandRubleHandler(_handler);

            _handler = new OneDollarHandler(_handler);
            _handler = new TwoDollarHandler(_handler);
            _handler = new FiveDollarHandler(_handler);
            _handler = new TenDollarHandler(_handler);
            _handler = new TwentyDollarHandler(_handler);
            _handler = new FiftyDollarHandler(_handler);
            _handler = new HundredDollarHandler(_handler);
            _handler = new FiveHundredDollarHandler(_handler);
            _handler = new ThousandDollarHandler(_handler);
            
            _handler = new FiveEuroHandler(_handler);
            _handler = new TenEuroHandler(_handler);
            _handler = new TwentyEuroHandler(_handler);
            _handler = new FiftyEuroHandler(_handler);
            _handler = new HundredEuroHandler(_handler);
            _handler = new TwoHundredEuroHandler(_handler);
            _handler = new FiveHundredEuroHandler(_handler);
        }

        public bool Validate(string banknote)
        {
            return _handler.Validate(banknote);
        } 
        
        public IEnumerable<IBanknote> GetCash(string sumCash)
        {
            return _handler.GetCash(sumCash);
        } 
    }
}
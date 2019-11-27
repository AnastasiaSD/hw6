using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace hw_6.Ruble
{
    public abstract class RubleHandlerBase: BanknoteHandler
    {
        
        protected override Regex MoneyPattern => new Regex(@"(?<Count>\d+)\₽");


        public override bool Validate(string banknote)
        {
            if (banknote.Equals($"{Value}₽"))
            {
                return true;
            }
            return base.Validate(banknote);
        }

        
        protected override IEnumerable<IBanknote> GetCash(int sumCash)
        {
            var count = sumCash / Value;
            
            var cash = new List<IBanknote>(){};
            for (int i = 0; i < count; i++)
            {
                cash.Add(new Banknote(CurrencyType.Ruble, Value));
            }

            var residue = base.GetCash(sumCash - count * Value);
            foreach (var banknote in residue)
            {
                cash.Add(banknote);
            }
            return (IEnumerable<IBanknote>)cash;
        }

        protected RubleHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace hw_6
{
    public abstract class BanknoteHandler
    {
        private readonly BanknoteHandler _nextHandler;

        protected BanknoteHandler(BanknoteHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
        
        protected abstract int Value { get; }
        protected abstract Regex MoneyPattern { get; }
        
        public virtual bool Validate(string banknote)
        {
            return _nextHandler != null && _nextHandler.Validate(banknote);
        }
        
        public IEnumerable<IBanknote> GetCash(string sumCash)
        {
                var match = MoneyPattern.Match(sumCash);

                if (!match.Success)
                {
                    if (_nextHandler is null)
                    {
                        Console.WriteLine($"Не валидный формат: ({sumCash})");
                        return null;
                    }
                    else
                    {
                        return _nextHandler.GetCash(sumCash);
                    }
                }
                else
                {
                    return GetCash(int.Parse(match.Groups["Count"].Value));
                }
        }

        protected virtual IEnumerable<IBanknote> GetCash(int sum)
        {
            if (!(_nextHandler is null))
                return _nextHandler.GetCash(sum);

            if (sum == 0) return Enumerable.Empty<IBanknote>();

            Console.WriteLine($"Не валидная сумма, остаток: ({sum})");
            return Enumerable.Empty<IBanknote>();
        }
        
    }
}
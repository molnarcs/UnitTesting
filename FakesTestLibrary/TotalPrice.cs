using System;

namespace FakesTestLibrary
{
    public class TotalPrice : ITotalPrice
    {
        IRepository _repository;

        public TotalPrice(IRepository repository)
        {
            _repository = repository;
        }

        public decimal UpdateTotalPrice(int value)
        {
            //return value;
            _repository.UpdateTotalPrice(value);
            return _repository.GetTotalPrice();
        }
    }
}

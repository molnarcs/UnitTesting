using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakesTestLibrary
{
    public interface IRepository
    {
        void UpdateTotalPrice(int value);
        decimal GetTotalPrice();
    }
}

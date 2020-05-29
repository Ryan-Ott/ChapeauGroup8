using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace UserInterface
{
    public interface IObserver
    {
        void Update(Order currentOrder);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.BusinessLayer.Lifters
{
    public interface ILifterManager
    {
        Lifter GetLifter(int id);
        List<Lifter> GetAllLifters();
    }
}

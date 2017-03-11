using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.DataLayer.Lifters
{
    public interface ILifterRepo
    {
        List<Lifter> GetAllLifters();

        Lifter GetLifter(int id);
    }
}

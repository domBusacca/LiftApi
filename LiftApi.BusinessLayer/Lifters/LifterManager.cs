using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.DataLayer.Lifters;
using LiftApi.Objects;

namespace LiftApi.BusinessLayer.Lifters
{
    public class LifterManager : ILifterManager
    {
        private readonly ILifterRepo _lifterRepo; 

        public LifterManager(ILifterRepo lifterRepo)
        {
            _lifterRepo = lifterRepo;
        }

        public Lifter GetLifter(int id)
        {
            return _lifterRepo.GetLifter(id);
        }

        public List<Lifter>GetAllLifters()
        {
            return _lifterRepo.GetAllLifters();
        }
    }
}

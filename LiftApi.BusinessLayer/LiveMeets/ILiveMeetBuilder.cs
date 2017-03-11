using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.BusinessLayer.LiveMeets
{
    public interface ILiveMeetBuilder
    {
        LiveMeet BuildLiveMeet(int meetId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.BusinessLayer.Meets
{
    public interface IMeetManager
    {
        MeetInfo GetMeet(int id);
        List<MeetInfo> GetAllMeets();
    }
}

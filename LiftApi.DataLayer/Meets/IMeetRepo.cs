using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.DataLayer.Meets
{
    public interface IMeetRepo
    {
        List<MeetInfo> GetAllMeets();
        MeetInfo GetMeetById(int id);
    }
}

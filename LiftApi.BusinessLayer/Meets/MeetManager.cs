using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.DataLayer.Meets;
using LiftApi.Objects;

namespace LiftApi.BusinessLayer.Meets
{
    public class MeetManager : IMeetManager
    {
        private readonly IMeetRepo _meetRepo;

        public MeetManager(IMeetRepo meetRepo)
        {
            _meetRepo = meetRepo;
        }

        public List<MeetInfo> GetAllMeets()
        {
            return _meetRepo.GetAllMeets();
        }

        public MeetInfo GetMeet(int id)
        {
            return _meetRepo.GetMeetById(id);
        }

    }
}

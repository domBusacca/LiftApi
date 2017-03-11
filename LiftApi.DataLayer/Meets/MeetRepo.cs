using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.DataLayer.Meets
{
    public class MeetRepo : IMeetRepo
    {
        private List<MeetInfo> MockedMeetData;

        public MeetRepo()
        {
            MockedMeetData = GetMockedMeetData();
        }

        public MeetInfo GetMeetById(int id)
        {
            return MockedMeetData.Find(x => x.MeetId == id);
        }

        public List<MeetInfo> GetAllMeets()
        {
            return MockedMeetData;
        }

        private List<MeetInfo>GetMockedMeetData()
        {
            var tempList = new List<MeetInfo>();

            tempList.Add(new MeetInfo()
            {
                MeetId = 1,
                MeetLocation = "The Ole Barbell",
                MeetName = "Harambe's Warriors"
            });

            return tempList;
        }
    }
}

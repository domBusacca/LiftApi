using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.DataLayer.Lifters
{
    public class LifterRepo : ILifterRepo
    {
        private List<Lifter> MockedLifterData;

        public LifterRepo()
        {
            MockedLifterData = GetMockedLifterData();
        }

        public Lifter GetLifter(int id)
        {
            return MockedLifterData.Find(x => x.LifterId == id);
        }

        public List<Lifter> GetAllLifters()
        {
            return MockedLifterData;
        }

        private List<Lifter> GetMockedLifterData()
        {
            var tempList = new List<Lifter>();

            tempList.Add(new Lifter()
            {
                DivisionCd = "Gay Ass Raw",
                LifterId = 2,
                FirstName = "Drew",
                LastName = "Young"
            });

            tempList.Add(new Lifter()
            {
                DivisionCd = "Big Dick Equipped",
                LifterId = 1,
                FirstName = "Dom",
                LastName = "Busacca"
            });

            return tempList;
        }
    }
}
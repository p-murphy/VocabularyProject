using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November16th
{
    class Scheduler
    {
        public Dictionary<int, string> MyDictionary { get; set; }
        public List<Appointment> ScheduleQueue { get; set; }

        #region Singleton Implementation
        public static Scheduler instance;

        public Scheduler()
        {
            Appointment a = new Appointment(MyDataList.instance.CollectionList[0], DateTime.Now.AddSeconds(10), ReviewStatus.SuggestedReview);

            ScheduleQueue = new List<Appointment>(); 
            ScheduleQueue.Add(a);
        }

        public static Scheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Scheduler();
                }
                return instance;
            }
        }
        #endregion
    }
}

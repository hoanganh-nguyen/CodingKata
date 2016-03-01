using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoKatas.Scheduling
{
    public interface IShowScheduler
    {
        IList<Show> Schedule(IList<Show> shows);
    }
    /// <summary>
    /// Goal: Longest show possible
    /// </summary>
    public class ShowScheduler:IShowScheduler
    {
        public IList<Show> Schedule(IList<Show> shows)
        {
            IList<Show> ret = new List<Show>();
            //First show
            var show = GetNextShow(shows, DateTime.MinValue);
            while (show != null)
            {
                ret.Add(show);
                show = GetNextShow(shows, show.EndTime);
            }
            return ret;
        }

        Show GetNextShow(IList<Show> shows, DateTime afterThisDate)
        {
            return shows.Where(x => x.StartTime >= afterThisDate).OrderBy(x => x.EndTime).FirstOrDefault();
        }


    }



    public class Show
    {
        public Show(string name, DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            Name = name;
            EndTime = endTime;
        }

        public string Name { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
    }
}

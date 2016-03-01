using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Api;


[TestFixture]
public class ScheduleTest
{
    [Test]
     public void Main()
    {
        Schedule schedule= new Schedule();
        var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

        var shows = new List<Show>
        {
            new Show("Show1", DateTime.Parse("8/6/2013 07:00", format), DateTime.Parse("8/6/2013 08:00", format)),
            new Show("Show2", DateTime.Parse("8/6/2013 07:00", format), DateTime.Parse("8/6/2013 09:00", format)),
            new Show("Show3", DateTime.Parse("8/6/2013 08:00", format), DateTime.Parse("8/6/2013 10:00", format)),
            new Show("Show4", DateTime.Parse("8/6/2013 10:00", format), DateTime.Parse("8/6/2013 12:00", format)),
            new Show("Show5", DateTime.Parse("8/6/2013 10:00", format), DateTime.Parse("8/6/2013 11:00", format)),
            new Show("Show6", DateTime.Parse("8/6/2013 18:00", format), DateTime.Parse("8/6/2013 20:00", format)),
            new Show("Show7", DateTime.Parse("8/6/2013 19:00", format), DateTime.Parse("8/6/2013 22:00", format)),
            new Show("Show8", DateTime.Parse("8/6/2013 21:00", format), DateTime.Parse("8/6/2013 23:00", format))
        };

        var list = schedule.FindOptimalSchedule(shows);
        string ret = "";
        foreach (var show in list)
        {
            ret+= show.Name;
        }
    }
}
public class Schedule
{
    public IList<Show> FindOptimalSchedule(ICollection<Show> shows)
    {

        List<Show> resultList = new List<Show>();
        //var tmp = shows.OrderBy(x => x.StartTime).ToArray();
        //for (int i = 0; i < tmp.Length; i++)
        //{
        //    if (i < 1)
        //    {
        //        resultList.Add(tmp[i]);
        //    }
        //    else if (i >= tmp.Length - 1)
        //    {
        //        resultList.Add(tmp[i]);
        //    }
        //    else if (tmp[i].StartTime >= tmp[i - 1].EndTime && tmp[i + 1].StartTime >= tmp[i].EndTime && i >1 && i<tmp.Length-1)
        //    {
        //        resultList.Add(tmp[i]);
        //    }
        //}

        shows.OrderBy(x => x.StartTime);
        var first = shows.FirstOrDefault();
        foreach (var show in shows)
        {
            //Children
            var tmp = shows.Where(x => x.StartTime >= show.StartTime).ToList();



            if (tmp.Any() && tmp.Count > shows.Count - resultList.Count)
            {
                var list = FindScheduleFromThisShow(tmp);
                if (list.Any() && list.Count > resultList.Count)
                {
                    resultList = list;
                }
            }

        }

        return resultList;


    }


    List<Show> FindScheduleFromThisShow(List<Show> shows)
    {

        //var tmp = shows.OrderBy(x => x.StartTime);
        List<Show> resultList = new List<Show>();

        foreach (var show in shows)
        {
            var tmp = shows.Where(x => x.StartTime >= show.StartTime).ToList();
            ScheduleHelper helper = new ScheduleHelper(tmp);
            if (helper.Output.Count() > resultList.Count())
            {
                resultList = helper.Output;
            }
        }

        return resultList;

        List<Show> Output = new List<Show>();

        var first = shows.OrderBy(x => x.StartTime).First();
        var last = shows.OrderByDescending(x => x.EndTime).First();
        while (last.StartTime > first.EndTime)
        {
            Output.Add(first);
            Output.Add(last);
            first = shows.Where(x => x.StartTime > first.EndTime).OrderBy(x => x.StartTime).FirstOrDefault();
            last = shows.Where(x => x.EndTime < last.StartTime).OrderByDescending(x => x.EndTime).FirstOrDefault();

        }
        return Output;
    }



}


public class ScheduleHelper
{
    public List<Show> Output { get; private set; }
    public List<Show> Input { get; private set; }

    public ScheduleHelper(List<Show> input)
    {
        Input = input;
        Output = new List<Show>();
        Find(input);
    }

    void Find(List<Show> shows)
    {
        var first = shows.OrderBy(x => x.StartTime).First();
        if (first != null)
        {
            Output.Add(first);
            var tmp = shows.Where(x => x.StartTime >= first.EndTime).ToList();
            if (tmp.Any())
            {
                Find(tmp);
            }

        }
    }
}

public class Show
{
    public string Name { get; private set; }

    public DateTime StartTime { get; private set; }

    public DateTime EndTime { get; private set; }

    public TimeSpan Duration { get { return EndTime - StartTime; }  }

    public Show(string name, DateTime startTime, DateTime endTime)
    {
        this.Name = name;
        this.StartTime = startTime;
        this.EndTime = endTime;
    }
}
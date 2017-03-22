using System;
using System.Collections.Generic;
using System.Linq;
using TN.Core.File;
using TN.Core.Model;
using TN.Data.Model;
using TN.Data.TNBusiness;

namespace TN.Core.Control
{
    public class LearnControl
    {
        public static IList<Learn> ListWord(int id,string username,string password)
        {
            var listday = FileLearn.ReadProcess(username, password);
            if (listday != null)
                return listday;
          
            ILearn learn = new LearnManager();
            IList<Learn> list = new List<Learn>();
            var remember = learn.GetReview(id);

            foreach (var item in remember)
            {
                var l = new Learn();
                var w = learn.GetByIdWord(item.IdWord);
                l.Id = item.IdWord;
                l.Word = w.Word1;
                l.No = 1;
                l.Id = item.IdAccountUser;
                l.Mean = w.Mean;
                l.Audio = w.Audio;
                l.Image = w.Image;
                l.Date = DateTime.Now;
                l.WordRemember = w.WordRemember;
                l.Point = 0;
                l.NumFail = 0;
                if (item.Point != null) l.PointWord = (int) item.Point;
                if (item.Review != null) l.Review = (int)item.Review;

                list.Add(l);
            }
            foreach (var l in learn.Get30Word(id).Take(30 - remember.Count).Select(item => new Learn
            {
                Id = item.Id,
                IdUser = id,
                No = 1,
                Date = DateTime.Now,
                Word = item.Word,
                Mean = item.Mean,
                Image = item.Image,
                Audio = item.Audio,
                NumFail = 0,
                WordRemember = item.WordRemember,
                Point = 0,
                Review = 0
            }))
            {
                list.Add(l);
            }


            return list.OrderBy(x => Guid.NewGuid()).Take(30).ToList();
        }

        public static bool SaveLearn(IList<Learn> learns)
        {
            var result = false;
            foreach (var temp in learns)
            {
                HistoryWord h = new HistoryWord();
                ILearn learn = new LearnManager();
                var e = new WordEffect();
                if (temp.No == 0)
                {
              
                
               
                e.IdWord = temp.Id;
                e.Status = true;
                
                    h.Learned = true;
                    if (temp.NumFail >= 9)
                    {
                        e.Point = 0;

                        e.Review = 0;
                    }else if (temp.NumFail > 5)
                    {
                        e.Point = temp.PointWord - 10;
                      
                        if (temp.Review <=1) e.Review = 0;
                        if (temp.Review >= 2) e.Review = temp.Review - 2;
                    }
                    else if (temp.NumFail > 3)
                    {
                        e.Point = temp.PointWord/2;
                        if (temp.Review == 0) e.Review = 0;
                        if (temp.Review > 0) e.Review = temp.Review - 1;

                    }
                    else if (temp.NumFail <= 3)
                    {

                        e.Review = temp.Review + 1;
                        e.Point = temp.PointWord + 10;

                    }
                    if (temp.Hight)
                    {
                        if (e.Review <= 1) e.Review = 0;
                        if (e.Review >= 2) e.Review = temp.Review - 1;
                    }
                    if (temp.Done)
                        e.Review = 7;

                    switch (e.Review)
                    {
                        case 0:
                            e.DateMilli = temp.Date.AddDays(1).Date;
                            break;
                        case 1:
                            e.DateMilli = temp.Date.AddDays(3).Date;
                            break;
                        case 2:
                            e.DateMilli = temp.Date.AddDays(3).Date;
                            break;
                        case 3:
                            e.DateMilli = temp.Date.AddDays(7).Date;
                            break;
                        case 4:
                            e.DateMilli = temp.Date.AddDays(15).Date;
                            break;
                        case 5:
                            e.DateMilli = temp.Date.AddDays(30).Date;
                            break;
                        case 6:
                            e.DateMilli = temp.Date.AddDays(90).Date;
                            break;
                        case 7:
                            e.DateMilli = temp.Date.AddDays(180).Date;
                            break;
                        default:
                            e.DateMilli = temp.Date.AddDays(365).Date;
                            break;
                    }
                    result = learn.SavePoint(e);

                }
                else
                {
                    h.Learned = false;
                    
                }
                h.Time = temp.NumFail;
                h.Status = true;
                h.Remember = " " + e.Point;
                h.Day = temp.Date;
                h.IdAccount = temp.IdUser;
                h.IdWord = temp.Id;
               result= learn.AddHistory(h);
            }
            return result;
        }

    }
}

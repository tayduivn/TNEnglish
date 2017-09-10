using System;
using System.Collections.Generic;
using System.Linq;
using TN.Data.Model;

namespace TN.Data.TNBusiness
{
    public class LearnManager : ILearn
    {
        public IList<WordEffect> GetReview(int id)
        {
            try
            {
                using (var db = new EnglishEntities())
                {
                    var query = db.WordEffects
                        .Where(x => x.IdAccountUser == id && x.Review < 9 && x.DateMilli <= DateTime.Now &&
                                    x.Status == true).OrderBy(e => e.Point).Take(20).ToList();
                    return query;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IList<learnNew_Result> Get30Word(int id)
        {
            try
            {
                using (var db = new EnglishEntities())
                {
                    var query = db.learnNew(id).ToList();
                    return query;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Word GetByIdWord(int id)
        {
            try
            {
                using (var db = new EnglishEntities())
                {
                    var query = db.Words.FirstOrDefault(x => x.Id == id);
                    return query;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public bool SavePoint(WordEffect e)
        {
            try
            {
                using (var db = new EnglishEntities())
                {
                    var query = db.WordEffects.FirstOrDefault(
                        x => x.IdWord == e.IdWord && x.IdAccountUser == e.IdAccountUser);
                    if (query != null)
                    {
                        query.Point = e.Point;
                        query.Review = e.Review;
                        query.Status = e.Status;
                        query.DateMilli = e.DateMilli;
                        query.IdWord = e.IdWord;
                    }
                    else
                    {
                        query = db.WordEffects.Add(e);
                    }

                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateWord(Word w)
        {
            try
            {
                using (var db = new EnglishEntities())
                {
                    var query = db.Words.FirstOrDefault(x => x.Id == w.Id);
                    query.Word1 = w.Word1;
                    query.WordRemember = w.WordRemember;
                    query.Mean = w.Mean;
                    query.Status = w.Status;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddHistory(HistoryWord h)
        {
            try
            {
                using (var db = new EnglishEntities())
                {
                    var query = db.HistoryWords.Add(h);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Word GetWordNull()
        {
            try
            {
                using (var db = new EnglishEntities())
                {
                    var query = db.Words.FirstOrDefault(x => x.WordRemember == null);
                    return query;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
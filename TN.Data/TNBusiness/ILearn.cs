using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN.Data.Model;

namespace TN.Data.TNBusiness
{
   public interface ILearn
   {
       IList<WordEffect> GetReview(int id);
       IList<learnNew_Result> Get30Word(int id);
       Word GetByIdWord(int id);
       bool SavePoint(WordEffect e);
       bool UpdateWord(Word w);
       bool AddHistory(HistoryWord h);
   }
}

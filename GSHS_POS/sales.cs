using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHS_POS
{
    class sales
    {
        public List<Transaction> selectAllTransactions(string orderby = null, List<DateTime> dates = null)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                var query = db.GetTable<Transaction>().Select(tr => new Transaction());
                switch(dates.Count)
                {
                    case 1:
                        query = query.Where(tr => tr.date == dates.ElementAt(0));
                        break;
                    case 2:
                        query = query.Where(tr => (tr.date >= dates.ElementAt(0) && tr.date <= dates.ElementAt(1)));
                        break;
                    default:
                        break;
                }
                query = (String.IsNullOrEmpty(orderby)) ? query : query.GenericEvaluateOrderBy(orderby);
                return query.ToList();
            }
        }

        public List<RecieptItemInfo> generateRecieptInfo(string transactionID)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                var query =from r in db.GetTable<Reciept>()
                           join tr in db.GetTable<Transaction>() on r.transactionID equals tr.transactionID
                           join p in db.GetTable<Product>() on r.productID equals p.productID
                           where r.transactionID == transactionID
                           select new RecieptItemInfo()
                           {
                               transactionID = r.transactionID,
                               code = p.code,
                               cost = p.cost * r.quantity,
                               productID = p.productID,
                               quantity = r.quantity,
                               items = tr.items
                           };
                return query.ToList<RecieptItemInfo>();
            }
        }

        public void insertTransaction(string transactionID, double value, int items)
        {
            transaction transaction = new transaction();
            transaction.transactionID = transactionID;
            transaction.value = value;
            transaction.items = items;
            transaction.date = DateTime.Now;
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                db.transactions.InsertOnSubmit(transaction);
                db.SubmitChanges();
                db.Connection.Close();
            }
        }

        public void insertRecieptItems(List<Tuple<string, int, int>> insertItems)
        {
            List<reciept> insert = new List<reciept>();
            for (int i = 0; i < insertItems.Count; i++)
            {
                reciept add = new reciept();
                add.transactionID = insertItems.ElementAt(i).Item1;
                add.productID = insertItems.ElementAt(i).Item2;
                add.quantity = insertItems.ElementAt(i).Item3;
                insert.Insert(i, add);
            }
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                db.reciepts.InsertAllOnSubmit(insert);
                db.SubmitChanges();
                db.Connection.Close();
            }
        }
    }
}

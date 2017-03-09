using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHS_POS
{
    class inventories
    {
        public List<Inventory> selectAllInventory(string orderby = null)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                IQueryable<Inventory> inventories = db.GetTable<Inventory>();
                if (String.IsNullOrEmpty(orderby))
                    return inventories.Select(i => i)
                        .ToList<Inventory>();
                else
                    return inventories.Select(i => i)
                        .GenericEvaluateOrderBy(orderby)
                        .ToList<Inventory>();
            }
        }

        public List<Inventory> selectInventoryWhereValue(decimal where, string GrLeEq)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                IQueryable<Inventory> inventories = db.GetTable<Inventory>();
                var query = inventories.Select(i => i);
                switch (GrLeEq.ToLower().Where(c => !Char.IsWhiteSpace(c)).ToString())
                {
                    case "greaterthen":
                        query = query.Where(i => i.value > where);
                        break;
                    case "lessthen":
                        query = query.Where(i => i.value < where);
                        break;
                    case "equal":
                        query = query.Where(i => i.value == where);
                        break;
                    default:
                        return query.ToList();
                }
                return query.ToList();
            }
        }

        public List<Inventory> selectInventoryWhereDate(DateTime where, int GrLeEq, bool recieveOrInvoice)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                IQueryable<Inventory> inventories = db.GetTable<Inventory>();
                var query = inventories.Select(i => i);
                switch (GrLeEq)
                {
                    case 0:
                        query = (recieveOrInvoice) ? query.Where(i => i.recieveDate > where) : query.Where(i => i.invoiceDate > where);
                        break;
                    case 1:
                        query = (recieveOrInvoice) ? query.Where(i => i.recieveDate < where) : query.Where(i => i.invoiceDate < where);
                        break;
                    case 2:
                        query = (recieveOrInvoice) ? query.Where(i => i.recieveDate == where) : query.Where(i => i.invoiceDate == where);
                        break;
                    default:
                        return query.ToList();
                }
                return query.ToList();
            }
        }

        public void insertInventoryItems(List<Tuple<string, int, int>> insertItems)
        {
            List<inventoryItem> insert = new List<inventoryItem>();
            for (int i = 0; i < insertItems.Count; i++)
            {
                inventoryItem add = new inventoryItem();
                add.inventoryID = insertItems.ElementAt(i).Item1;
                add.productID = insertItems.ElementAt(i).Item2;
                add.quantity = insertItems.ElementAt(i).Item3;
                insert.Insert(i, add);
            }
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                db.inventoryItems.InsertAllOnSubmit(insert);
                db.SubmitChanges();
                db.Connection.Close();
            }
        }

        public void insertInventory(string inventoryID, double value, int itemCount, DateTime invoiceDate)
        {
            inventory insert = new inventory();
            insert.inventoryID = inventoryID;
            insert.value = value;
            insert.itemCount = itemCount;
            insert.invoiceDate = invoiceDate;
            insert.recieveDate = DateTime.Now;
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                db.inventories.InsertOnSubmit(insert);
                db.SubmitChanges();
                db.Connection.Close();
            }
        }

        public List<InventoryItemInfo> selectAllItemsInInventory(Inventory queryInventory)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                IQueryable<InventoryItems> inventoryItems = db.GetTable<InventoryItems>();
                var query = from i in inventoryItems
                            join ii in db.GetTable<inventory>() on i.inventoryID equals ii.inventoryID
                            join p in db.GetTable<Product>() on i.productID equals p.productID
                            where i.inventoryID == queryInventory.inventoryID
                            select new InventoryItemInfo
                            {
                                inventoryID = ii.inventoryID,
                                code = p.code,
                                style = p.style,
                                category = p.category,
                                gender = p.gender,
                                size = p.size,
                                secondHand = p.second_hand
                            };
                return query.ToList();
            }
        }
    }
}

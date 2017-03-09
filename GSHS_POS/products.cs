using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHS_POS
{
    class productsClass
    {
        public List<Product> selectAllProductsNoWhere(string orderby = null, bool instock = false)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                IQueryable<Product> products = db.GetTable<Product>();
                var query = products.Select(p => p);
                query = (instock) ? query.Where(p => p.instock > 0) : query;
                query = (!String.IsNullOrEmpty(orderby)) ? query.GenericEvaluateOrderBy(orderby) : query;
                return query.ToList<Product>();
            }
        }

        public List<Product> selectProductsWhere(string category = null, long code = -1, char gender = '\0', bool instock = false, bool? secondHand = null, string size = null, string style = null, string orderby = null)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                IQueryable<Product> products = db.GetTable<Product>();
                var query = products.Select(p => p);
                if(!secondHand.Equals(null))
                    query = query.Where(p => p.second_hand == secondHand);
                query = (String.IsNullOrEmpty(category)) ? query : query.Where(p => p.category == category);
                query = (code < 0) ? query : query.Where(p => p.code == code);
                query = (!instock) ? query : query.Where(p => p.instock > 0);
                query = (Char.Equals(gender, '\0')) ? query : query.Where(p => p.gender == gender);
                query = (String.IsNullOrEmpty(size) || String.IsNullOrWhiteSpace(size)) ? query : query.Where(p => p.size == size);
                query = (String.IsNullOrEmpty(style) || String.IsNullOrWhiteSpace(style)) ? query : query.Where(p => p.style == style);
                if (String.IsNullOrEmpty(orderby))
                    return query.ToList();
                else
                    return query.GenericEvaluateOrderBy(orderby).ToList();
            }
        }

        public void insertIntoProducts(string category, int code, char gender, int instock, bool secondHand, string size, string style)
        {
            product insert = new product();
            insert.category = category;
            insert.code = code;
            insert.gender = gender;
            insert.inStock = instock;
            insert.second_hand = secondHand;
            insert.size = size;
            insert.style = style;
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                db.products.InsertOnSubmit(insert);
                db.SubmitChanges();
                db.Connection.Close();
            }
        }

        public void updateProducts(List<Tuple<int, int>> productsToUpdate, bool addition)
        {
            using (posformconnectionDataContext db = new posformconnectionDataContext())
            {
                foreach (Tuple<int, int> product in productsToUpdate)
                {
                    var update = db.GetTable<Product>().Select(u => u).Where(u => u.productID == product.Item1).First();
                    update.instock = (addition) ? update.instock + product.Item2 : update.instock - product.Item2;
                    db.SubmitChanges();
                }
            }
        }
    }
}

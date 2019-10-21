using System;
using System.Collections.Generic;
using System.Linq;
using PagedList;
using System.Text;
using System.Threading.Tasks;
using Model.ViewModel;
using Model.model;

namespace Model.method
{
    public class SearchProduct 
    {
        DBModel db = null;
        public SearchProduct()
        {
            db = new DBModel();
        }
        public IEnumerable<User> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<User> model = db.Users;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString) || x.Phone.Contains(searchString));
            }

            return model.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);
        }
        public IEnumerable<User> ListUser(string searchString, int page, int pageSize)
        {
           
                IQueryable<User> model = db.Users;
                if (!string.IsNullOrEmpty(searchString))
                {
                    model = model.Where(x => x.Name.Contains(searchString) || x.Phone.Contains(searchString));
                }
                return model.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);

            
           
        }
        public List<Customer> ListCustomer(long id)
        {
            
            var customer = db.Customers.Where(x => x.UserId == id);
            return customer.ToList();
           
        }





        public bool ChangeStatus(long id)
        {
            var user = db.Users.Find(id);
            user.Status = !user.Status;
            db.SaveChanges();
            return user.Status;
        }
        //public bool ChangeStatusCustomer(long id)
        //{

        //    var model = (from a in db.Customers
        //                 join b in db.Users
        //                 on a.UserId equals b.ID 
        //                 where a.UserId == id
        //                 select new
        //                 {
                            
        //                     Status = a.Status,
                           

        //                 }).AsEnumerable().Select(x => new UserCustomer()
        //                 {
                            
        //                     Status = x.Status,
                            
        //                 });
            
        //    var customer = UserCustomer.Find(id);

        //    customer.Status = !customer.Status;
        //    db.SaveChanges();
        //    return customer.Status;
        //}
        public List<UserCustomer> ListUserCustomer(long id)
        {

            var model = (from a in db.Customers
                         join b in db.Users
                         on a.UserId equals b.ID
                         where a.UserId == id
                         select new
                         {
                             ID = a.ID,
                             NameUser = b.Name,
                             Address = a.Address,
                             Phone = a.Phone,
                             Email= a.Email,
                             Status = a.Status,
                             Description = a.Description,
                             ObjectId = b.ID,
                             NameObject = a.Name

                         }).AsEnumerable().Select(x => new UserCustomer()
                         {
                             ID = x.ID,
                             NameUser = x.NameUser,
                             Address = x.Address,
                             Phone = x.Phone,
                             Email = x.Email,
                             Status = x.Status,
                             Description = x.Description,
                             ObjectId = x.ObjectId,
                             NameObject = x.NameObject
                         });

            return model.ToList();
        }
        public List<TeleCustomer> ListTele(long id)
        {

            var model = (from a in db.Customers
                         join b in db.Users
                         on a.TeleId equals b.ID
                         where a.TeleId == id
                         select new
                         {
                             ObjectId = a.ID,
                             NameObject = a.Name,
                             AddressObject = a.Address,
                             PhoneObject = a.Phone,
                             EmailObject = a.Email,
                             StatusObject = a.Status,
                             Description = a.Description,
                           NameTele = b.Name

                         }).AsEnumerable().Select(x => new TeleCustomer()
                         {
                             ObjectId = x.ObjectId,
                             NameObject = x.NameObject,
                             AddressObject = x.AddressObject,
                             PhoneObject = x.PhoneObject,
                             EmailObject = x.EmailObject,
                             StatusObject = x.StatusObject,
                             Description = x.Description,
                             NameTele = x.NameTele
                         });

            return model.ToList();
        }
        //public List<ProductViewModel> ListByCategoryId()
        //{

        //    var model = (from a in db.Products
        //                 join b in db.Users
        //                 on a.ID equals b.ID

        //                 select new
        //                 {
        //                     ID = a.ID,
        //                     NameProduct = a.NameProduct,
        //                     Description = a.Description,
        //                     Status = a.Status,
        //                     UserName = b.UserName

        //                 }).AsEnumerable().Select(x => new ProductViewModel()
        //                 {
        //                     ID = x.ID,
        //                     NameProduct = x.NameProduct,
        //                     Description = x.Description,
        //                     Status = x.Status,
        //                     UserName = x.UserName
        //                 });

        //    return model.ToList();
        //}
    }
}

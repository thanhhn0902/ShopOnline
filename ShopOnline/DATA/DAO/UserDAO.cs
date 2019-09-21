using DATA.Models;
using DATA.Models.Data;
using System.Linq;

namespace DATA.DAO
{
    public class UserDAO
    {
        ShopDbContext db = null;
        public UserDAO()
        {
            ShopDbContext db = new ShopDbContext();
        }
        public long Insert(Users entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }
        public Users GetById(string username)
        {
            var result = db.Users.SingleOrDefault(x=>x.UserName == username);
            return result;
        }
        public bool Login(string username, string password)
        {
            var result = db.Users.Count(x => x.UserName == username && x.Password == password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

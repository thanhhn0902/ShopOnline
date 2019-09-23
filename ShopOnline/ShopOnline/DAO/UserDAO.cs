using ShopOnline.Areas.Administrator.Common;
using ShopOnline.Models;
using ShopOnline.Models.Data;
using System.Linq;

namespace ShopOnline.DAO
{
    class UserDAO
    {
        private ShopDbContext db = null;
        public UserDAO()
        {
            db = new ShopDbContext();
        }
        public long Insert(Users entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }
        public Users GetById(string username)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == username);
            return result;
        }
        public bool Login(string username, string password)
        {
            var pass = Encryptor.MD5Hash(password);
            var result = db.Users.Count(x => x.UserName == username && x.Password == pass);
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}

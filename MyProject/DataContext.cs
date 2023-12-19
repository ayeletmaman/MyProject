using MyProject.Entities;
using System.Reflection;

namespace MyProject
{
    public class DataContext
    {
        public List<Mediatior> _mediatior { get; set; }
        public List<Buyer> _buyer { get; set; }
        public List<Apartment> _apartment { get; set; }


        public DataContext()
        {
            _mediatior = new List<Mediatior>();
            _buyer = new List<Buyer>();
            _apartment = new List<Apartment>();
        }

        internal object Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
  
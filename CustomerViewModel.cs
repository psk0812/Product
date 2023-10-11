using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    class CustomerViewModel : IDisposable
    {
        private masterEntities1 db;
        public CustomerViewModel() => db = new masterEntities1();

        public BindingSource CustomerBindingSource { get; set;}

        public void Load()
        {
            db.Customers.Load();
            CustomerBindingSource.DataSource = db.Customers.Local.ToBindingList();
        }

        public void Delete() => CustomerBindingSource.RemoveCurrent();
        public void New() => CustomerBindingSource.AddNew();
        public void save()
        {
            CustomerBindingSource.EndEdit();
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
        
    }
}

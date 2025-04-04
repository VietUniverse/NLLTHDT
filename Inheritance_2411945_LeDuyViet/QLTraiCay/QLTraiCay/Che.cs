using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraiCay
{
    internal class Che
    {
        List<Fruit> collections = new List<Fruit>();
        List<NguyenLieu> dsn = new List<NguyenLieu>();
        public void Process()
        {
            foreach(Fruit fruit in collections)
                fruit.Process();
            foreach(NguyenLieu nguyenLieu in dsn)
                nguyenLieu.Process();
        }
    }
}

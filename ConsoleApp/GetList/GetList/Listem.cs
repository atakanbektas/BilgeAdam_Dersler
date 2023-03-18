using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetList
{
    internal class Listem : IEnumerable
    {
        ArrayList array;
        public Listem()
        {
            array = new ArrayList();
        }
        public void Ekle(object value)
        {
            array.Add(value);
        }

        /// <summary>
        /// GetEnumarator metodu bana List tipinde değerleri getirdi.
        /// </summary>
        /// <returns>GetEnumerator metodu array döndürdü.</returns>
        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();            
        }
    }
}

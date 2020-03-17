using E_Barangay.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    class DocumentInstantiator<T> where T : DocumentForm, new()
    {
        T doc;
        public DocumentInstantiator()
        {
        }
        public string Name
        {
            get
            {
                return doc.Text;
            }
        }
        public void Open()
        {
            doc = new T();
            doc.Show();
        }
    }
}

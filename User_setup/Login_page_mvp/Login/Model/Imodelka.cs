using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.Login.Model
{
    internal interface Imodelka
    {   
        string Name { get; set; }
        public Imodelka simplefunc() {
            Console.WriteLine("привет");
            return this;
        }
    }
}

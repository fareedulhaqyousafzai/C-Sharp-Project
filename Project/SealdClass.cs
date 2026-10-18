using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{

    //    sealed class BaseClasss{


    //         public void BaseShow()
    //        {
    //            Console.WriteLine("Method of Base Class");
    //        }


    //    }
    //    public class DerivedClasss:BaseClasss
    //    {
    //        public void DerivedShow()
    //        {
    //            Console.WriteLine("Method of Derived Clsss");
    //        }
    //    }

    //}
    public class BaseClasss
    {


        public virtual void print()
        {
            Console.WriteLine("Method of Base Class");
        }


    }
    public class DerivedClasss : BaseClasss
    {
        public sealed override void print()
        {
            Console.WriteLine("Method of Derived Clsss");
        }
    }

}

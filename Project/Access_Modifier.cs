using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project
{
    public class Access_Modifier
    {
        protected void show()
        {
            Console.WriteLine("Welcome");
        }




        public void CallPrivateShow() 
        {
            this.show();

        }


    }

    class pro:Access_Modifier
    {
        public void TestProtected()
        {
            pro obj= new pro();
            obj.show(); 
            this.show(); 
        }


    }
}

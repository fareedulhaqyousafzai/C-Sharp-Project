using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project
{
    public class Access_Modifier
    {
        private void show()
        {
            Console.WriteLine("Welcome");
        }

        public void CallPrivateShow()
        {
            this.show();

        }


    }
}


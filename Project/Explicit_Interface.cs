using System;

namespace Project
{
   
    interface ICar
    {
        void Move();
    }

    interface IRobot
    {
        void Move();
    }

    class OptimusPrime : ICar, IRobot
    {
      
        void ICar.Move()
        {
            Console.WriteLine("This is ICar's Move method!");
        }

 
        void IRobot.Move()
        {
            Console.WriteLine("This is IRobot's Move method!");
        }
    }
}
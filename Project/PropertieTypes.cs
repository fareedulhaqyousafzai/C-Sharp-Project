using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class PropertieTypes
    {
        private int _StudentId = 100;
        private string _StudentName;


        public int StudentId
        {
            get { return _StudentId; }

        }

        public string StudentName
        {
 
            set { _StudentName = value; }
        }

        public int Id { get; private set; }
        public String Name { get;private set; }


        public PropertieTypes(int id, string name)
        {
            Id = id;
            Name = name;
        }


    }
}
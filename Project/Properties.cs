using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Properties
    {
        private int _StudentId;
        private String _StudentName;

        public int StudentId
        {
            
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Student ID cannot be negative.");

                }
                else
                {
                    _StudentId = value;
                }
            }

            get { return _StudentId; }
        }
        public String StudentName
        {

            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student Name cannot be empty.");
                }
                else
                {
                    _StudentName = value;
                }
            }
            get { return _StudentName; }
        }

    }
}

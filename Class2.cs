using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Exception
{
    class Class2
    {

        public void SomeMethod()
        {
            throw new NullReferenceException();


        }



        public void Method3()
        {

            throw new Exception();
        }

        internal void SecondMethod()
        {
            throw new CustomException("Class 2 Exception !!");
        }
    }
}

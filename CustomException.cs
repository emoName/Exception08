using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Exception
{
   public class CustomException : Exception
    {


        public CustomException() : base()
        {

        }

        public CustomException(String s) :base(s)
        {

        }
        public CustomException(String s , Exception e) : base(s,e)
        {
                
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Exception
{
    class Child1 
    {

        int k= Help.b;

        public void SomeMethod()
        {
            var a = new Class1();

            a.SomeMethod();
        }



        public void Method3()
        {
            try
            {
              
                var a = new Class1();
                a.Method3();
            }
            catch (Exception) when (k == 0)
            {
                Help.b++;
                throw;
            }
            catch (Exception e) when (k == 1)
            {
                Help.b++;
                throw e;
            }

            catch (Exception e) when (k == 2)
            {
                Help.b++;
                throw new Exception("<====>  3  <====>", e);
            }
        }

    }
}

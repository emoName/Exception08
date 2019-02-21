using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Exception
{
    class Class1
    {
        int k = Help.c;
        public void SomeMethod()
        {
            var a = new Class2();


            a.SomeMethod();
        }

        


        public void Method3()
        {
            try
            {
              
                var a = new Class2();
                a.Method3();
            }
            catch (Exception) when (k == 0)
            {
                Help.c++;
                throw;
            }
            catch (Exception e) when (k == 1)
            {
                Help.c++;
                throw e;
            }

            catch (Exception e) when (k == 2)
            {
                Help.c++;
                throw new Exception("<====>  3  <====>", e);
            }
        }
    }
}

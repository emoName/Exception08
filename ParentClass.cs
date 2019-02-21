using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Exception
{
    class ParentClass 
    {
        int k = Help.a;
        public string ss = "Parent Class";
        ParentClass parentClass2;


        public  void NewMethod(Child1 child1)
        {

            //  A(B(C());
            object obj = child1;



            var aa = new { p = 7, ff = "fgrtgr" };

#if DEBUG
            aa = new { p = 4, ff = "Debug" };
#elif RELESE
                aa = new { p = 4, ff = "Relese" };

#endif


            Console.WriteLine(aa.p + aa.ff);


            parentClass2 = obj as ParentClass;

            Console.WriteLine(parentClass2.ss);
        }



       public void Method3()
        {
            try
            {
                k = Help.a;
                var a = new Child1();
                a.Method3();
            }
            catch (Exception)when  (k==0)
            {
                Help.a++;
              
                throw;
            }
            catch (Exception e) when (k==1)
            {
                Help.a++;
           
                throw e;
            }

            catch (Exception e) when (k==2)
            {
                Help.a++;
       
                throw new Exception("<====>  3  <====>",e);
            }
        }

        public void SecondMethod()
        {
            var c = new Class2();

            try
            {
  c.SecondMethod();
            }
            catch (Exception e)
            {

                throw new CustomException("Catch in Parent Class  !!! ", e);
            }
          
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            int a =4, b = 6;

            string s ="";

            ParentClass parentClass;
            Child1 child1 = new Child1();

            try
            {

                //  A(B(C());
                object obj;
                obj = child1;

                parentClass = obj as ParentClass ;

                Console.WriteLine( parentClass.ss ); 


            }

            catch (Exception) when  (a>b)
            {

                Console.WriteLine("a>b");
            }
            catch (NullReferenceException) when (a>b)
            {
                Console.WriteLine("Null Reference Exception a>b ");
            }
            catch (Exception e) when (a<b)
            {
                Console.WriteLine("a<b");
            }
            finally
            {
                Console.WriteLine("Finaly Done");
            }





            Console.ReadLine();
        }
    }
}

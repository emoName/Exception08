using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 6;

            var parentClass = new ParentClass();


            Child1 child1 = new Child1();
            A:
            try
            {
                switch (a)
                {
                    case 0:
                        parentClass.NewMethod(child1);
                        break;
                    case 1:
                        parentClass.Method3();
                        break;
                    case 2:
                        parentClass.Method3();
                        break;
                    case 3:
                        parentClass.Method3();
                        break;
                    case 4:
                        parentClass.SecondMethod();
                        break;
                    default:
                        break;
                }



            }

            catch (Exception e) when (a == 0)
            {
                a++;
                System.Diagnostics.Trace.WriteLine("a>b");

                Debug.WriteLine(e.ToString());
                goto A;
            }
            catch (Exception e) when (a == 1)
            {
                a++;
                System.Diagnostics.Trace.WriteLine("Null Reference Exception a>b ");

                Debug.WriteLine(e.ToString());
                goto A;
            }
            catch (Exception e) when (a == 2)
            {
                a++;
                System.Diagnostics.Trace.WriteLine("a<b");
                Debug.WriteLine(e.ToString());
                goto A;
            }
            catch (Exception e) when (a == 3)
            {
                a++;
                System.Diagnostics.Trace.WriteLine("a<b");
                Debug.WriteLine(e.ToString());
                goto A;
            }
            catch (CustomException e)
            {
            
                Debug.WriteLine(e.ToString());
            }
            finally
            {
                System.Diagnostics.Trace.WriteLine("Finaly Done");
            }





            Console.ReadLine();
        }


    }
}

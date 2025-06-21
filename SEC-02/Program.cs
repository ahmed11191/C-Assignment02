namespace SEC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Declaration
            //int x =1 ;
            //int y;
            //int z;//int x = 7, y, z;
            #endregion
            #region value data type
            int x;
            x = 4;
        Int32 y =9;
            //y =9 x=4
            y = x;
            //x and y= 4
            x++;
            //x=x+1
            //x+=1
            //x=5,y=4
            Console.WriteLine(x);
            Console.WriteLine(y);
            #endregion
            #region reference
            Point p1;
                p1 = new Point();
                p1.x = 1;
                p1.y = 2;
            Point p2;
                p2 = new Point();
                p2.x = 3;
                p2.y = 4;
            Console.WriteLine($"p1 = ({p1.x};{p1.y})");
            Console.WriteLine($"p2 = ({p2.x};{p2.y})");

            p2 = p1;
            p1.x = 7;
            p2.y = 9;
            Console.WriteLine($"p1 = ({p1.x};{p1.y})");
            Console.WriteLine($"p2 = ({p2.x};{p2.y})");

            #endregion
            #region Object
             Point3D point3D = new Point3D();

            point3D.y = 2;      
            point3D.z = 3;


            Point p4 = 
            p4 = new Point();
            p4 = new Point3D();


            object obj;

            obj = new object();
            obj = new Point3D();
            obj = new Point ();
            obj = new Temp();
            obj = 123;
            obj = 9.4;
            obj = 'c';
            obj = "Ahmed zaghlou";

            #endregion
        
        }
        //print (7,5)
        //print(6.5,4.2)
        //Print('a',,'b')

                   
        static void Print<T>(T x, T y)
        {    Console.WriteLine(x);
             Console.WriteLine(y);
        }

        Print<int>(7,5);


        //   static void Print(double x, double y)
        //{    Console.WriteLine(x);
        //  Console.WriteLine(y);

        // }

           // static void Print(int x, int y)
        //{
          //  Console.WriteLine(x);
            //Console.WriteLine(y);

//        }


    }


}

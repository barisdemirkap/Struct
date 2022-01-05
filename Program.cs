using System;

namespace conceptofstruct
{
    class Program 
    { 
        static void Main (string[] args)
        { 
            rectangle rectangle1 = new rectangle () ;
            //rectangle1.shortedge = 3 ;
            //rectangle1.longedge = 4 ;

            Console.WriteLine("Class Alan Hesabi    :{0}", rectangle1.AreaCalculation()) ;

            //rectangle_struct rectangle_Struct1 ;
            rectangle_struct rectangle_Struct1 = new rectangle_struct(3,4) ;
            //rectangle_struct rectangle_Struct1 = new rectangle_struct() ;
            //rectangle_Struct1.longedge = 3 ;
            //rectangle_Struct1.shortedge = 4 ;
            Console.WriteLine("Class Alan Hesabi    :{0}", rectangle_Struct1.AreaCalculation()) ;

        }
    }

    class rectangle
    {
        public int shortedge ;
        public int longedge ;

        public rectangle ()
        {
            shortedge = 3 ;
            longedge = 4 ;

        }
        public long AreaCalculation()
        {   
            return this.longedge*this.shortedge ;
        }
    }

    struct rectangle_struct
    {
        public int shortedge;
        public int longedge;

        public rectangle_struct(int Shortedge, int Longedge)
        {
            shortedge = Shortedge ;
            longedge = Longedge; 
        }
        public long AreaCalculation ()
        {
            return this.shortedge * this.longedge ;
        }
    }

}
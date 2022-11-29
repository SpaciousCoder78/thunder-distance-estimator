using System;

namespace Thunder_Distance_Estimator
{
    class thunder_distance_estimator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------Thunder Distance Estimator------------------------------------");
            Console.WriteLine("--------------------------------v1.0-----------------------------------------------------");
            Console.Write("Enter no of seconds after thunder: ");
            string thundertime= Console.ReadLine();
            int thundertimeint = Int32.Parse(thundertime);
            int speedofsound = 343;
            int distance = speedofsound * thundertimeint;
            Console.WriteLine("Distance of thunder is "+distance+" metres");
            Console.ReadLine();

        }
    }

}

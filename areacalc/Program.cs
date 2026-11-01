namespace areacalc;
  
class Program
{
    static void Main(string[] args)
    {   
        int option = 0;
        double[] areas = new double[100];
        int index = 0;
        double largestArea = 0;
        while (option != -1)
        {
            Console.WriteLine(
                "Enter the corresponding number of the shape that you would like to calculate the area of: \n(1) Circle \n(2) Rectangle \n(3) Triangle \n(4) Trapzoid \n(5) Parallelogram \n(6) Square \n(7) Ellipse");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the radius of the circle");
                    double circleRadius = double.Parse(Console.ReadLine());
                    areas[index] = CircleArea(circleRadius);
                    break;
                case 2:
                    Console.WriteLine("Enter the width of the rectangle");
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the rectangle");
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    areas[index] = RectangleArea(rectangleWidth, rectangleHeight);
                    break;
                case 3:
                    Console.WriteLine("Enter the length of the base of the triangle");
                    double triangleBase = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the triangle");
                    double triangleHeight = double.Parse(Console.ReadLine());
                    areas[index] = TriangleArea(triangleBase, triangleHeight);
                    break;
                case 4:
                    Console.WriteLine("Enter the length 'a' of the trapezium");
                    double trapeziumA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the length 'b' of the trapezium");
                    double trapeziumB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the trapezium");
                    double trapeziumHeight = double.Parse(Console.ReadLine());
                    areas[index] = TrapeziumArea(trapeziumA, trapeziumB, trapeziumHeight);
                    break;
                case 5:
                    Console.WriteLine("Enter the length of the base of the parallelogram");
                    double parallelogramBase = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the parallelogram");
                    double parallelogramHeight = double.Parse(Console.ReadLine());
                    areas[index] = ParallelogramArea(parallelogramBase, parallelogramHeight);
                    break;
                case 6:
                    Console.WriteLine("Enter the side length of the square");
                    double squareLength = double.Parse(Console.ReadLine());
                    areas[index] = SquareArea(squareLength);
                    break;
                case 7:
                    Console.WriteLine("Enter the radius 'a' of the ellipse");
                    double ellipseA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the radius 'b' of the ellipse");
                    double ellipseB = double.Parse(Console.ReadLine());
                    areas[index] = EllipseArea(ellipseA, ellipseB);
                    break;
                case -1:
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again");
                    break;
            }
    
            for (int i = 0; i < areas.Length; i++)
            {
                if (areas[i] > largestArea)
                    largestArea = areas[i];
            }

            Console.WriteLine("The largest area is:   " + largestArea);
            index += 1;
        }

        Console.WriteLine("Exiting the program...");
    }

    static double CircleArea(double radius)
    {
        double area = radius * radius * Math.PI;
        Console.WriteLine("The area of circle is " + area);
        return area;
    }

    static double RectangleArea(double width, double height)
    {
        double area = width * height;
        Console.WriteLine("The area of rectangle is " + area);
        return area;
    }

    static double TriangleArea(double trianglebase, double height)
    {
        double area = 0.5 * trianglebase * height;
        Console.WriteLine("The area of triangle is " + area);
        return area;
    }

    static double TrapeziumArea(double a, double b, double height)
    {
        double area = ((a +b)/2)*height;
        Console.WriteLine("The area of trapezium is " + area);
        return area;
    }

    static double ParallelogramArea(double parallelogramBase, double height)
    {
        double area = parallelogramBase * height;
        Console.WriteLine("The area of parallelogram is " + area);
        return area;
    }

    static double SquareArea(double side)
    {
        double area = side * side;
        Console.WriteLine("The area of square is " + area);
        return area;
    }

    static double EllipseArea(double a, double b)
    {
        double area = a * b * Math.PI;
        Console.WriteLine("The area of ellipse is " + area);
        return area;
    }
    
}
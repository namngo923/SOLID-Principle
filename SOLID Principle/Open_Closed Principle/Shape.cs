namespace SOLID_Principle.Open_Closed_Principle
{
    // Ta có 3 class: vuông, tròn, tam giác, kế thừa class Shape
    public class Shape
    {
    }
    public class Square : Shape
    {
        public double Height { get; set; }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
    }
    public class Triangle : Shape
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
    }

    // Module in ra diện tích các hình
    public class AreaDisplay
    {
        public double ShowArea(List<Shape> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                // Nếu yêu cầu thay đổi, thêm shape khác, ta phải sửa module Area Calculator
                if (shape is Square)
                {
                    Square square = (Square)shape;
                     area += Math.Sqrt(square.Height);
                    Console.WriteLine(area);
                }
                if (shape is Triangle)
                {
                    Triangle triangle = (Triangle)shape;
                    double TotalHalf = (triangle.FirstSide + triangle.SecondSide + triangle.ThirdSide) / 2;
                    area += Math.Sqrt(TotalHalf * (TotalHalf - triangle.FirstSide) * (TotalHalf - triangle.SecondSide) * (TotalHalf - triangle.ThirdSide));
                    Console.WriteLine(area);
                }
                if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                    Console.WriteLine(area);
                }
            }
            return area;
        }
    }

    //After
    // Ta có 3 class: vuông, tròn, tam giác, kế thừa class Shape
    // Chuyển logic tính diện tích vào mỗi class
    public abstract class ShapeAfter
    {
        public double area { set; get; }

    }
    public class SquareAfter : ShapeAfter
    {
        public double Height { get; set; }
        public double Area()
        {
            return Math.Sqrt(this.Height);
        }
    }
    public class CircleAfter : ShapeAfter
    {
        public double Radius { get; set; }
        public double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
    public class TriangleAfter : ShapeAfter
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public double Area()
        {
            double TotalHalf = (this.FirstSide + this.SecondSide + this.ThirdSide) / 2;
             area += Math.Sqrt(TotalHalf * (TotalHalf - this.FirstSide) * (TotalHalf - this.SecondSide) * (TotalHalf - this.ThirdSide));

            return area;
        }
    }

    // Module in ra diện tích các hình
    public class AreaDisplayAfter
    {
        public void ShowAreaAfter(List<ShapeAfter> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.area);
            }
        }
    }


}

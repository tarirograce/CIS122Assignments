namespace The_Triangle_Farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AreaOfTriangle> aListOfTriangles = new List<AreaOfTriangle>();

            AreaOfTriangle aTriangles1 = new AreaOfTriangle(2,8);
            AreaOfTriangle aTriangles2 = new AreaOfTriangle(10, 8);

            aListOfTriangles.Add(aTriangles1);
            aListOfTriangles.Add(aTriangles2);

            foreach (AreaOfTriangle aTriangle in aListOfTriangles)
            {
                Console.WriteLine(aTriangle.ToString());
            }


        }
    }
}

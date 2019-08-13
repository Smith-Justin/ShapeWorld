using ShapeWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeWorld.Domain.Collections
{
    public class ShapeArray
    {
        public void DimensionalArray()
        {
            //1-D
            Shape[] shaped = new Shape[10];
            Shape[] shaped2 = new Shape[]{new Square()};

            //2-D
            Shape[,] shaped3 = new Shape[2,2];
            Shape[,] shaped4 = new Shape[,]
            {
                {new Square(),new Square()}, 
                {new Cube(),new Triangle()}
            };

            //3-D
            Shape[,,] shaped5 = new Shape[3,3,3];
            Shape[,,] shaped6 = new Shape[,,]
            {
                {  {new Square(), new Square(), new Square()},  {new Square(), new Square(), new Square()},  {new Square(), new Square(), new Square()}  },
                {  {new Square(), new Square(), new Square()},  {new Square(), new Square(), new Square()},  {new Square(), new Square(), new Square()}  },
                {  {new Square(), new Square(), new Square()},  {new Square(), new Square(), new Square()},  {new Square(), new Square(), new Square()}  }
            };

            //READ
            System.Console.WriteLine(shaped2);

            //WRITE
            shaped2[0] = new Circle();
            shaped4[1,0] = new Cube();
            shaped6[1,0,2] = new Rectangle();

            //JAGGED ARRAY
            Shape[][] shaped7 = new Shape[10][];
            Shape[][] shaped8 = new Shape[][]
            {
                new Rectangle[10],
                new Circle[]{new Circle(), new Circle()},
                new []{new Circle(), new Circle()} //creates array of the type of the container array (Shape)
            };

            System.Console.WriteLine(shaped8[1][1]);
        }

        public void MyList()
        {
            List<Shape> shaped = new List<Shape>();
            List<Shape> shaped2 = new List<Shape> {new Cube(), new Cube()};

            List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
            List<Shape[][,,]> shaped4 = new List<Shape[][,,]>{ new Shape[5][,,] };

            //READ
            System.Console.WriteLine(shaped2[1]);
            System.Console.WriteLine(shaped2.Find(e => e.NumberOfEdges == 12)); //predicate function "=>" (Fat arrow, "such that")
            System.Console.WriteLine(shaped2.FindIndex(e => e.NumberOfEdges == 12));
            System.Console.WriteLine(shaped2.FirstOrDefault(e => e.NumberOfEdges == 12));

            //WRITE
            try
            {
                shaped2[100] = new Rectangle();
            }
            catch(NullReferenceException)
            {
                throw; //walk away from error, code that called this code (Program.PlayWithCollection()) will take the error
            }
            catch(ArgumentOutOfRangeException)
            {
                shaped2.Add(new Rectangle());
            }
            catch(Exception ex)
            {
                //throw ex; //throws error similar to "throw" but throws the error at this line
                throw new KeyNotFoundException("error information", ex);
            }
            finally
            {
                GC.Collect();
                System.Console.WriteLine("It is final!");
            }

            shaped2.Add(new Triangle());
            shaped2.AddRange(shaped2);

            //REMOVE
            shaped2.Remove(new Cube()); // doesn't remove anything, the new cube isn't in the list
        }

        public void MyDictionary()
        {
            //Dictionary<System.Guid, Shape> shaped = new Dictionary<System.Guid, Shape>(); //Guid (Graphical/General User ID) alphanumeric number
           
            Dictionary<string, Shape> shaped = new Dictionary<string, Shape>(); //Keys should NOT be a reference type (object), ONLY value types (primitive)
            
            Dictionary<string, List<Shape>> shaped2 = new Dictionary<string, List<Shape>>
            {
                {"square", new List<Shape>()}
            };

            //READ
            System.Console.WriteLine(shaped2["square"]);
            shaped2.Select(d => d.Key == "square");

            //WRITE
            shaped2["square"] = new List<Shape>(); // add-or-update - add square if it doesn't exist, if it does then update it (Don't do this, it could cause bugs)
            try
            {
                shaped2.Add("square", new List<Shape>()); // add, no update - add square if it doesn't exist, if it does then throw an error (Do this, it might throw an error, but it won't have unintended consequences)
            }
            catch(Exception)
            {
                shaped2["square"] = new List<Shape>();
            }
        }
    }
}
namespace PracticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConstructorType obj = new ConstructorType();
            ConstructorType obj_One = new ConstructorType("Bruce", 33);
            obj_One.Output();
            //Copy Constructor
            ConstructorType obj_Two = new ConstructorType("Ferrari", "485Hp");
            ConstructorType construct = new ConstructorType(obj_Two);
            Console.WriteLine("Copy Constructor : " + construct.car);
            Console.WriteLine("Copy Constructor : " + construct.Hp);
        }
    }
}
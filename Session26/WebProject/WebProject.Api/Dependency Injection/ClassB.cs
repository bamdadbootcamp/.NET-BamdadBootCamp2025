namespace WebProject.Api.Dependency_Injection
{
    public class ClassB
    {

        //private readonly ClassA _classA;
        //public ClassB()
        //{
        //    _classA = new ClassA();
        //}

        private readonly IClassA _classA;
        public ClassB(IClassA classA)
        {
            _classA = classA;
        }



        public string GetHelloText()
        {
            return _classA.SayHello();
        }
    }
}

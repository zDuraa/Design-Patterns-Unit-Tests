namespace SingletonTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.Name = "Test";
            
            Singleton singleton2 = Singleton.GetInstance();
            Assert.That(singleton.Name, Is.EqualTo(singleton2.Name));
        }
    }
}
namespace EME.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestMethod_ThrowsExceptionOnInvalidArgument()    
    {
        EME1 obj = new EME1();

        Assert.Throws<ArgumentNullException>(() => obj.MethodThatThrowsException(null));
        
    }
//    [Test]
//    public void TestMethod_ThrowsCustomExceptionOnLongArgument()
//    {
           
//            EME1 obj = new EME1();

           
//            Assert.Throws<MyCustomException>(() => obj.MethodThatThrowsException("O argumento é muito longo"));
//    }

    [Test]
    public void TestMethod_NoExceptionOnShortArgument()
    {
            
            EME1 obj = new EME1();

            
            Assert.DoesNotThrow(() => obj.MethodThatThrowsException("curto"));
        }
}
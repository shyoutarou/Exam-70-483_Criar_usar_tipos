using Xunit;

namespace xUnitClassLibrary
{
    // Não é mais possível herdar da classe selada TraitAttribute
    //public class CategoryAttribute : TraitAttribute
    //{
    //    public CategoryAttribute(string value)
    //    : base("Category", value)
    //    { }
    //}

    //public class UnitTestAttribute : CategoryAttribute
    //{
    //    public UnitTestAttribute()
    //    : base("Unit Test")
    //    { }
    //}

    public class Class1
    {
        //=== TEST EXECUTION SUMMARY ===
        //xUnitClassLibrary Total: 2, Errors: 0, Failed: 1, Skipped: 0, Time: 0,737s
        [Fact]
        [Trait("Category", "Unit Test")]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2)); //OK
        }

        [Fact]
        [Trait("Category", "Integration Test")]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2)); //Failed
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        //=== SECOND TEST EXECUTION SUMMARY ===
        // xUnitClassLibrary Total: 5, Errors: 0, Failed: 2, Skipped: 0, Time: 0,311s
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}

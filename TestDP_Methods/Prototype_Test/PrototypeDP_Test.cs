//using PrototypeDP_UdemyDesignPatterns_ConsoleApp.IClonableIsBad;
//using PrototypeDP_UdemyDesignPatterns_ConsoleApp.ConstructorCopy;
using PrototypeDP_UdemyDesignPatterns_ConsoleApp.PrototypeInheritance;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Xunit;

namespace TestDP_Methods.Prototype_Test
{
    public class PrototypeDP_Test
    {
        [Fact]
        public void ShallowCloningObjectsTest_ShoulCopyAllPropertiesAndChangeOnlyTheRequiredPropert()
        {
            // Arrange
            //Person marko = new Person(new string[] { "Marko", "Pancev" },
            //                new Address("Green Street Hooligans", 234));

            //Person pavle = (Person)marko.Clone();
            //pavle.Address.StreetName = "Blue Street Ultras";

            // Actions

            // Asserts

            // Testibg the test - should pass.
            //.Equal(marko, marko);
            //Assert.Equal(pavle, pavle);
            
            // Should failed
            //Assert.Equal(marko,pavle);
        }
        //[Fact]
        //public void TesdtPersonDeepCopy_TwoObjectsShouldBeDifferent()
        //{
        //    var john = new Person(new string[] { " Jürgen", "Klopp" },
        //                                new Address("FK Liverpool Road", 4));
        //    var jane = john.DeepCopy();
        //    jane.Address.HouseNumber = 23;
        //    PersonObjectComperer personObjectComperer = new PersonObjectComperer();
        //    // Test the Test - test should pass.
        //    //Assert.Equal(john, john);
        //    //Assert.True(personObjectComperer.Equals(john, john));

        //    // Testing 2 different objects - should not pass.
        //    Assert.Equal(john, jane);
        //    Assert.True(personObjectComperer.Equals(john, jane));
        //}
        [Fact]
        public void TestPrototypeInheritance_TwoObjectsShouldBeDifferent()
        {
            var john = new Employee();
            john.Names = new string[] { "John", "Doe" };
            john.Address = new Address
            {
                HouseNumber = 123,
                StreetName = "London Road"
            };
            john.Salery = 321000;
            var copy = john.DeepCopy();
            copy.Names[0] = "Smith";
            copy.Address.HouseNumber++;
            copy.Salery = 123000;

            // Test the Test - test should pass.

            PersonObjectComperer personObjectComperer = new PersonObjectComperer();

            //Assert.Equal(john, john);
            //Assert.True(personObjectComperer.Equals(john, john));

            // Testing 2 different objects - should not pass.

            Assert.Equal(john, copy);
            Assert.True(personObjectComperer.Equals(john, copy));

        }


    }
}

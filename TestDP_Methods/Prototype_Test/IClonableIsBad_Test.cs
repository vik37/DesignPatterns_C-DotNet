using PrototypeDP_UdemyDesignPatterns_ConsoleApp.IClonableIsBad;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Xunit;

namespace TestDP_Methods.Prototype_Test
{
    public class IClonableIsBad_Test
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
    }
}

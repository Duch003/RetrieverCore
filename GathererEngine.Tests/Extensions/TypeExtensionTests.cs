using GathererEngine.Extensions;
using System;
using Xunit;

namespace GathererEngine.Tests.Extensions
{
    public class TypeExtensionTests
    {
        [Fact]
        public void GetDefault_InputIsNull_ThrowsNullReferenceException()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => ((Type)null).GetDefault());
        }

        [Fact]
        public void GetDefault_InputIsValid_ReturnsDefaultObject()
        {
            //Arrange
            var objectType = typeof(object);
            var structType = typeof(int);
            var stringType = typeof(string);

            //Act
            var objectResult = objectType.GetDefault();
            var structResult = structType.GetDefault();
            var stringResult = stringType.GetDefault();

            //Assert
            Assert.Null(objectResult);
            Assert.Equal(default(int), structResult);
            Assert.Equal(default(string), stringResult);
        }
    }
}

using System;
using System.Linq;
using Xunit;
using RetrieverCore.Extensions;
using System.Collections.Generic;

namespace RetrieverCore.ExtensionsTests
{
    public class LinqExtensionTests
    {
        [Fact]
        public void ForEach_ListItselfIsNull_ThrowsNullReferenceException()
        {
            //Arrange
            IEnumerable<object> nullList = null;

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => nullList.ForEach(x => x));
        }

        [Fact]
        public void ForEach_ActionIsNull_ThrowsNullReferenceException()
        {
            //Arrange
            List<object> nullList = new List<object>();
            nullList.Add("Test");

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => nullList.AsEnumerable().ForEach((Func<object, object>)null));
        }
    }
}

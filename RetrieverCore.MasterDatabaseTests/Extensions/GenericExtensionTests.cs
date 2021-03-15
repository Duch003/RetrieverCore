using RetrieverCore.MasterDatabase.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RetrieverCore.MasterDatabaseTests.Extensions
{
    public class GenericExtensionTests
    {
        private string _invalidString = "Invalid String";
        private string _nullString = null;
        private string _emptyString = string.Empty;

        [Fact]
        public void ToNullable_StringIsInvalid_ReturnsNull()
        {
            //Arrange
            var resultList = new List<object>();

            //Act
            resultList.Add(_invalidString.ToNullable<ushort>());
            resultList.Add(_invalidString.ToNullable<short>());
            resultList.Add(_invalidString.ToNullable<uint>());
            resultList.Add(_invalidString.ToNullable<int>());
            resultList.Add(_invalidString.ToNullable<ulong>());
            resultList.Add(_invalidString.ToNullable<long>());
            resultList.Add(_invalidString.ToNullable<float>());
            resultList.Add(_invalidString.ToNullable<decimal>());
            resultList.Add(_invalidString.ToNullable<sbyte>());
            resultList.Add(_invalidString.ToNullable<byte>());
            resultList.Add(_invalidString.ToNullable<DateTime>());

            //Assert
            Assert.True(resultList.All(x => x == null));
        }

        [Fact]
        public void ToNullable_StringIsEmpty_ReturnsNull()
        {
            //Arrange
            var resultList = new List<object>();

            //Act
            resultList.Add(_emptyString.ToNullable<ushort>());
            resultList.Add(_emptyString.ToNullable<short>());
            resultList.Add(_emptyString.ToNullable<uint>());
            resultList.Add(_emptyString.ToNullable<int>());
            resultList.Add(_emptyString.ToNullable<ulong>());
            resultList.Add(_emptyString.ToNullable<long>());
            resultList.Add(_emptyString.ToNullable<float>());
            resultList.Add(_emptyString.ToNullable<decimal>());
            resultList.Add(_emptyString.ToNullable<sbyte>());
            resultList.Add(_emptyString.ToNullable<byte>());
            resultList.Add(_invalidString.ToNullable<DateTime>());

            //Assert
            Assert.True(resultList.All(x => x == null));
        }

        [Fact]
        public void ToNullable_StringIsNull_ReturnsNull()
        {
            //Arrange
            var resultList = new List<object>();

            //Act
            resultList.Add(_nullString.ToNullable<ushort>());
            resultList.Add(_nullString.ToNullable<short>());
            resultList.Add(_nullString.ToNullable<uint>());
            resultList.Add(_nullString.ToNullable<int>());
            resultList.Add(_nullString.ToNullable<ulong>());
            resultList.Add(_nullString.ToNullable<long>());
            resultList.Add(_nullString.ToNullable<float>());
            resultList.Add(_nullString.ToNullable<decimal>());
            resultList.Add(_nullString.ToNullable<sbyte>());
            resultList.Add(_nullString.ToNullable<byte>());
            resultList.Add(_invalidString.ToNullable<DateTime>());

            //Assert
            Assert.True(resultList.All(x => x == null));
        }
    }
}

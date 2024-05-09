using FlatSharp.Internal;

namespace FlatSharpEndToEndTests.ToStringMethods;

[TestClass]
class ToStringTests
{
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Table_ToString(FlatBufferDeserializationOption option)
    {
        MyTable myTable = new MyTable 
        {
            FieldA = "hello",
            FieldB = 123
        };
        int maxBytesNeeded = MyTable.Serializer.GetMaxSize(myTable);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = MyTable.Serializer.Write(buffer, myTable);

        MyTable deserializedTable = MyTable.Serializer.Parse(buffer, option);

        Assert.AreEqual("MyTable { FieldA = hello, FieldB = 123 }", deserializedTable.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void EmptyTable_ToString(FlatBufferDeserializationOption option)
    {
        MyEmptyTable myEmptyTable = new MyEmptyTable();
        int maxBytesNeeded = MyEmptyTable.Serializer.GetMaxSize(myEmptyTable);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = MyEmptyTable.Serializer.Write(buffer, myEmptyTable);

        MyEmptyTable deserializedTable = MyEmptyTable.Serializer.Parse(buffer, option);

        Assert.AreEqual("MyEmptyTable { }", deserializedTable.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Struct_ToString(FlatBufferDeserializationOption option)
    {
        MyStructs myStructs = new MyStructs 
        {
            MyStruct = new MyStruct 
            {
                FieldA = 456,
                FieldB = 123
            },
            MyEmptyStruct = new MyEmptyStruct(),
            MyValueStruct = new MyValueStruct 
            {
                FieldX = 2f,
                FieldY = 3f
            }
        };

        int maxBytesNeeded = MyStructs.Serializer.GetMaxSize(myStructs);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = MyStructs.Serializer.Write(buffer, myStructs);

        MyStructs deserializedStructs = MyStructs.Serializer.Parse(buffer, option);

        Assert.AreEqual("MyStructs { MyStruct = MyStruct { FieldA = 456, FieldB = 123 }, MyEmptyStruct = MyEmptyStruct { }, MyValueStruct = MyValueStruct { FieldX = 2, FieldY = 3 } }", deserializedStructs.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Union_ToString(FlatBufferDeserializationOption option)
    {
        MyUnions myUnions = new MyUnions 
        {
            FieldA = new MyUnion[]
            {
                Member1 = new ValueA 
                {
                    Value = 2
                },
                Member2 = "hello"
            }
        };

        int maxBytesNeeded = MyUnions.Serializer.GetMaxSize(myUnions);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = MyUnions.Serializer.Write(buffer, myUnions);

        MyUnions deserializedUnions = MyUnions.Serializer.Parse(buffer, option);

        Assert.AreEqual("MyUnions { FieldA = [MyUnion { Member1 = ValueA { Value = 2 } }, MyUnion { Member2 = hello }] }", deserializedUnions.ToString());
    }
}
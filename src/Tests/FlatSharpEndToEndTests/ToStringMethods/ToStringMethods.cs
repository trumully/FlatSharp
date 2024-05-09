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
            FieldA = new MyStruct 
            {
                FieldA = 456,
                FieldB = 123
            },
            FieldB = new MyValueStruct 
            {
                FieldX = 2f,
                FieldY = 3f
            }
        };

        int maxBytesNeeded = MyStructs.Serializer.GetMaxSize(myStructs);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = MyStructs.Serializer.Write(buffer, myStructs);

        MyStructs deserializedStructs = MyStructs.Serializer.Parse(buffer, option);

        Assert.AreEqual("MyStructs { FieldA = MyStruct { FieldA = 456, FieldB = 123 }, FieldB = MyValueStruct { FieldX = 2, FieldY = 3 } }", deserializedStructs.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Union_ToString(FlatBufferDeserializationOption option)
    {
        Container c = new Container
        {
            FieldA = new MyUnion[]
            {
                new MyUnion(new A()),
                new MyUnion(new B()),
                new MyUnion(new C()),
                new MyUnion(new D()),
            }
        };

        byte[] buffer = new byte[Container.Serializer.GetMaxSize(c)];
        Container.Serializer.Write(buffer, c);

        Container deserializedContainer = Container.Serializer.Parse(buffer, option);

        Assert.AreEqual("Container { FieldA = [A { }, B { }, C { }, D { }] }", deserializedContainer.ToString());
    }
}
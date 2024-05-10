namespace FlatSharpEndToEndTests.ToStringMethods;

[TestClass]
public class ToStringTests
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
                new MyUnion(new A{V = 1}),
                new MyUnion(new B{V = 2}),
                new MyUnion(new C{V = 3}),
                new MyUnion(new D{V = 4}),
            }
        };

        byte[] buffer = new byte[Container.Serializer.GetMaxSize(c)];
        Container.Serializer.Write(buffer, c);

        Container deserializedContainer = Container.Serializer.Parse(buffer, option);

        Assert.AreEqual("Container { FieldA = { A { V = 1 }, B { V = 2 }, C { V = 3 }, D { V = 4 } }", deserializedContainer.ToString());
    }
}
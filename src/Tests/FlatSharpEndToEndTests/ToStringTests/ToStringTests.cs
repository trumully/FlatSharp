namespace FlatSharpEndToEndTests.ToStringTests;

[TestClass]
public class ToStringTests
{
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Table_ToString(FlatBufferDeserializationOption option)
    {
        byte[] table = new Table
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
        }.AllocateAndSerialize();
        Table parsed = Table.Serializer.Parse(table, option);
        
        Assert.AreEqual("Table { A = 1, B = 2, C = 3, D = 4 }", parsed.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void EmptyTable_ToString(FlatBufferDeserializationOption option)
    {
        byte[] emptyTable = new EmptyTable().AllocateAndSerialize();
        EmptyTable parsed = EmptyTable.Serializer.Parse(emptyTable, option);

        Assert.AreEqual("EmptyTable { }", parsed.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Struct_ToString(FlatBufferDeserializationOption option)
    {
        SomeStruct s = new SomeStruct
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
        };

        SomeStruct parsed = this.ParseStruct(s, option);

        Assert.AreEqual("SomeStruct { A = 1, B = 2, C = 3, D = 4 }", parsed.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void ValueStruct_ToString(FlatBufferDeserializationOption option)
    {
        ValueStruct vs = new ValueStruct
        {
            X = 1,
            Y = 2,
            Z = 3,
        };

        ValueStruct parsed = this.ParseStruct(vs, option);

        Assert.AreEqual("ValueStruct { X = 1, Y = 2, Z = 3 }", parsed.ToString());
    }

    [TestMethod]
    public void Union_ToString()
    {
        var c = this.Setup();

        Assert.AreEqual("Container { Value = [MyUnion { A { X = 1 } }, MyUnion { B { Y = 2 } }, MyUnion { C { Z = 3 } }, MyUnion { D { W = 4 } }], Empty = [] }", c.ToString());
    }

    private T ParseStruct<T>(T, FlatBufferDeserializationOption option)
        where T : struct
    {
        ISerializer<T> serializer = T.Serializer;
        int maxBytes = serializer.GetMaxSize(vs);
        byte[] buffer = new byte[maxBytes];
        serializer.Write(buffer, vs);
        int written = serializer.Write(buffer, vs);
        T parsed = serializer.Parse(buffer.AsMemory().Slice(0, written), option);
        return parsed;
    }
    private Container Setup()
    {
        Container c = new Container
        {
            Value = new MyUnion[]
            {
                new MyUnion(new A()),
                new MyUnion(new B()),
                new MyUnion(new C()),
                new MyUnion(new D()),
            }
            Empty = new EmptyUnion[]
            {
            }
        };

        byte[] buffer = new byte[Container.Serializer.GetMaxSize(c)];
        Container.Serializer.Write(buffer, c);

        return Container.Serializer.Parse(buffer);
    }

}
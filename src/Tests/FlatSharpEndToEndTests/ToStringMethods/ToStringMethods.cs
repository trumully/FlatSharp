namespace FlatSharpEndToEndTests.ToString;

[TestClass]
class ToStringTests
{
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Table_ToString(FlatBufferDeserializationOption option)
    {
        TableValues tableValues = new TableValues
        {
            A = 1;
            B = 2;
            C = 3;
        }

        int maxBytesNeeded = TableValues.Serializer.GetMaxSize(tableValues);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = TableValues.Serializer.Write(buffer, tableValues);

        TableValues tableValuesDeserialized = TableValues.Serializer.Parse(buffer.AsSpan().Slice(0, bytesWritten));

        Assert.AreEqual("TableValues { A = 1, B = 2, C = 3 }", tableValuesDeserialized.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void TableEmpty_ToString(FlatBufferDeserializationOption option)
    {
        TableEmpty tableEmpty = new TableEmpty();

        int maxBytesNeeded = TableEmpty.Serializer.GetMaxSize(tableEmpty);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = TableEmpty.Serializer.Write(buffer, tableEmpty);

        TableEmpty tableEmptyDeserialized = TableEmpty.Serializer.Parse(buffer.AsSpan().Slice(0, bytesWritten));

        Assert.AreEqual("TableEmpty { A = 1, B = 2, C = 3 }", tableEmptyDeserialized.ToString());
    }

    
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Struct_ToString(FlatBufferDeserializationOption option)
    {
        Struct s = new Struct
        {
            X = 1;
            Y = 2;
            Z = 3;
        }

        int maxBytesNeeded = Struct.Serializer.GetMaxSize(s);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = Struct.Serializer.Write(buffer, s);

        Struct structDeserialized = Struct.Serializer.Parse(buffer.AsSpan().Slice(0, bytesWritten));

        Assert.AreEqual("Struct { X = 1, Y = 2, Z = 3 }", structDeserialized.ToString());
    }
    
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void ValueStruct_ToString(FlatBufferDeserializationOption option)
    {
        ValueStruct vs = new ValueStruct
        {
            X = 1;
            Y = 2;
            Z = 3;
        }

        int maxBytesNeeded = ValueStruct.Serializer.GetMaxSize(vs);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = ValueStruct.Serializer.Write(buffer, vs);

        ValueStruct valueStructDeserialized = ValueStruct.Serializer.Parse(buffer.AsSpan().Slice(0, bytesWritten));

        Assert.AreEqual("ValueStruct { X = 1, Y = 2, Z = 3 }", valueStructDeserialized.ToString());
    }
    
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Union_ToString(FlatBufferDeserializationOption option)
    {
        Dog dog = new Dog
        {
            Name = "Doggo";
            Age = 5;
        }
        Cat cat = new Cat
        {
            Name = "Cat";
            Age = 3;
        }
        Fish fish = new Fish
        {
            Name = "Fish";
            Weight = 0.5;
            Age = 1;
        }


        MyUnion u = new MyUnion
        {
            Doggo = dog;
            Cat = cat;
            Fish = fish;
            someString = "hello";
        }

        int maxBytesNeeded = MyUnion.Serializer.GetMaxSize(u);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = MyUnion.Serializer.Write(buffer, u);

        MyUnion unionDeserialized = MyUnion.Serializer.Parse(buffer.AsSpan().Slice(0, bytesWritten));

        Assert.AreEqual("MyUnion { Doggo = Dog { Name = Doggo, Age = 5 }, Cat = Cat { Name = Cat, Age = 3 }, Fish = Fish { Name = Fish, Weight = 0.5, Age = 1 }, someString = hello }", unionDeserialized.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void UnionEmpty_ToString(FlatBufferDeserializationOption option)
    {
        EmptyUnion u = new EmptyUnion();

        int maxBytesNeeded = EmptyUnion.Serializer.GetMaxSize(u);
        byte[] buffer = new byte[maxBytesNeeded];
        int bytesWritten = EmptyUnion.Serializer.Write(buffer, u);

        EmptyUnion unionDeserialized = EmptyUnion.Serializer.Parse(buffer.AsSpan().Slice(0, bytesWritten));

        Assert.AreEqual("EmptyUnion { }", unionDeserialized.ToString());
    }
}
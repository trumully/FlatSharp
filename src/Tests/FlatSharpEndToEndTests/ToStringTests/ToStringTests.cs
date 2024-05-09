namespace FlatSharpEndToEndTests.ToStringTests;

[TestClass]
public class ToStringTestCases()
{
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void All_ToString(FlatBufferDeserializationOption option)
    {
        ISerializer<RootTable> serializer = RootTable.Serializer;
        int maxBytes = serializer.GetMaxSize(table);
        byte[] buffer = new byte[maxBytes];
        int written = serializer.Write(buffer, table);
        RootTable parsed = serializer.Parse(buffer.AsMemory().Slice(0, written), option);

        Assert.AreEqual("Person { Name = John, Age = 30  }", parsed.Person.ToString());
        Assert.AreEqual("Empty { }", parsed.EmptyTable.ToString());
        Assert.AreEqual("Struct { V = 2 }", parsed.Struct.ToString());
        Assert.AreEqual("ValueStruct { X = 0.5, Y = 1, Z = 0 }", parsed.Vec3.ToString());
        Assert.AreEqual("Union { [A = { V }, B = { V }, C = { V }, D = { V }] }", parsed.Union.ToString());
        Assert.AreEqual("EmptyUnion { [] }", parsed.EmptyUnion.ToString());
    }

}
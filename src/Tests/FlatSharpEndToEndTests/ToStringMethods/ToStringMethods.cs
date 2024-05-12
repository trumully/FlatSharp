namespace FlatSharpEndToEndTests.ToStringMethods;

[TestClass]
public class ToStringTests
{
    [TestMethod]
    public void Table_ToString()
    {
        MyTable myTable = new MyTable 
        {
            FieldA = "hello",
            FieldB = 123
        };

        Assert.AreEqual("MyTable { FieldA = hello, FieldB = 123 }", myTable.ToString());
    }

    [TestMethod]
    public void EmptyTable_ToString()
    {
        MyEmptyTable myEmptyTable = new MyEmptyTable();

        Assert.AreEqual("MyEmptyTable { }", myEmptyTable.ToString());
    }

    [TestMethod]
    public void Struct_ToString()
    {
        MyStruct myStruct = new MyStruct
        {
            FieldA = 456,
            FieldB = 123
        };

        Assert.AreEqual("MyStruct { FieldA = 456, FieldB = 123 }", myStruct.ToString());
    }

    [TestMethod]
    public void ValueStruct_ToString()
    {
        MyValueStruct myValueStruct = new MyValueStruct
        {
            FieldA = 456,
            FieldB = 123
        };

        Assert.AreEqual("MyValueStruct { FieldA = 456, FieldB = 123 }", myValueStruct.ToString());
    }

    [TestMethod]
    public void UnionStructs_ToString()
    {
        StructContainer c = new StructContainer
        {
            Value = new StructUnion[]
            {
                new StructUnion(new A()),
                new StructUnion(new B()),
                new StructUnion(new C()),
                new StructUnion(new D()),
            }
        };

        Assert.AreEqual("StructContainer { Value = { A, B, C, D }", c.ToString());
    }

    [TestMethod]
    public void UnionTables_ToString()
    {
        TableContainer c = new TableContainer
        {
            Value = new TableUnion[]
            {
                new TableUnion(new MyTable()),
                new TableUnion(new MyEmptyTable()),
            }
        };

        Assert.AreEqual("TableContainer { Value = { MyTable, MyEmptyTable } }", c.ToString());
    }

    [TestMethod]
    public void UnionMixed_ToString()
    {
        MixedContainer c = new MixedContainer
        {
            Value = new MixedUnion[]
            {
                new MixedUnion(new A()),
                new MixedUnion(new B()),
                new MixedUnion(new MyTable());
                new MixedUnion(new MyEmptyTable()),
            }
        };

        Assert.AreEqual("MixedContainer { Value = { A, B, MyTable, MyEmptyTable } }", c.ToString());
    }
}
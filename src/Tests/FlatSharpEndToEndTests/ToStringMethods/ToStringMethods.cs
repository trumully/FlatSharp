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
            FieldX = 1f,
            FieldY = 2f
        };

        Assert.AreEqual("MyValueStruct { FieldX = 1, FieldY = 2 }", myValueStruct.ToString());
    }

    [TestMethod]
    public void UnionStructs_ToString()
    {
        StructContainer c = new StructContainer
        {
            Value = new StructUnion[]
            {
                new A(),
                new B(),
                new C(),
                new D(),
            }
        };

        Assert.AreEqual("StructContainer { Value = { A, B, C, D } }", c.ToString());
    }

    [TestMethod]
    public void UnionTables_ToString()
    {
        TableContainer c = new TableContainer
        {
            Value = new TableUnion[]
            {
                new MyTable(),
                new MyEmptyTable(),
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
                new A(),
                new B(),
                new MyTable(),
                new MyEmptyTable(),
            }
        };

        Assert.AreEqual("MixedContainer { Value = { A, B, MyTable, MyEmptyTable } }", c.ToString());
    }
}
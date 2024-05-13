using FlatSharp.Internal;

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
        StructUnion[] u =
        {
            new StructUnion(new A{ V = 0 }),
            new StructUnion(new B{ V = 1 }),
            new StructUnion(new C{ V = 2 }),
            new StructUnion(new D{ V = 3 }),
        };

        Assert.AreEqual("StructUnion { A { V = 0 } }", u[0].ToString());
        Assert.AreEqual("StructUnion { B { V = 1 } }", u[1].ToString());
        Assert.AreEqual("StructUnion { C { V = 2 } }", u[2].ToString());
        Assert.AreEqual("StructUnion { D { V = 3 } }", u[3].ToString());
    }

    [TestMethod]
    public void UnionTables_ToString()
    {
        TableUnion[] u = new TableUnion[]
        {
            new TableUnion(new MyTable{ FieldA = "hello", FieldB = 10 }),
            new TableUnion(new MyEmptyTable()),
        };
        Assert.AreEqual("TableUnion { MyTable { FieldA = hello, FieldB = 10 } }", u[0].ToString());
        Assert.AreEqual("TableUnion { MyEmptyTable { } }", u[1].ToString());
    }

    [TestMethod]
    public void UnionMixed_ToString()
    {
        MixedUnion[] u = new MixedUnion[]
        {
            new MixedUnion(new A()),
            new MixedUnion(new B()),
            new MixedUnion(new MyTable{ FieldA = "hi", FieldB = 21 }),
            new MixedUnion(new MyEmptyTable()),
        };

        Assert.AreEqual("MixedUnion { A { V = 0 } }", u[0].ToString());
        u[0].A.V = (uint)2;
        Assert.AreEqual("MixedUnion { A { V = 2 } }", u[0].ToString());
        Assert.AreEqual("MixedUnion { B { V = 0 } }", u[1].ToString());
        Assert.AreEqual("MixedUnion { MyTable { FieldA = hi, FieldB = 21 } }", u[2].ToString());
        Assert.AreEqual("MixedUnion { MyEmptyTable { } }", u[3].ToString());

    }
}
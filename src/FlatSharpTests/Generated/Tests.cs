// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpTests.Oracle
{

using global::System;
using global::FlatBuffers;

    public struct BasicTypes : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static BasicTypes GetRootAsBasicTypes(ByteBuffer _bb) { return GetRootAsBasicTypes(_bb, new BasicTypes()); }
  public static BasicTypes GetRootAsBasicTypes(ByteBuffer _bb, BasicTypes obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public BasicTypes __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte Byte { get { int o = __p.__offset(4); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public ushort UShort { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public short Short { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public bool Bool { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint UInt { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public int Int { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public sbyte SByte { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
  public ulong ULong { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
  public long Long { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float Float { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public double Double { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)0.0; } }
  public string String { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetStringBytes() { return __p.__vector_as_arraysegment(26); }

  public static Offset<BasicTypes> CreateBasicTypes(FlatBufferBuilder builder,
      byte Byte = 0,
      ushort UShort = 0,
      short Short = 0,
      bool Bool = false,
      uint UInt = 0,
      int Int = 0,
      sbyte SByte = 0,
      ulong ULong = 0,
      long Long = 0,
      float Float = 0.0f,
      double Double = 0.0,
      StringOffset StringOffset = default(StringOffset)) {
    builder.StartObject(12);
    BasicTypes.AddDouble(builder, Double);
    BasicTypes.AddLong(builder, Long);
    BasicTypes.AddULong(builder, ULong);
    BasicTypes.AddString(builder, StringOffset);
    BasicTypes.AddFloat(builder, Float);
    BasicTypes.AddInt(builder, Int);
    BasicTypes.AddUInt(builder, UInt);
    BasicTypes.AddShort(builder, Short);
    BasicTypes.AddUShort(builder, UShort);
    BasicTypes.AddSByte(builder, SByte);
    BasicTypes.AddBool(builder, Bool);
    BasicTypes.AddByte(builder, Byte);
    return BasicTypes.EndBasicTypes(builder);
  }

  public static void StartBasicTypes(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddByte(FlatBufferBuilder builder, byte Byte) { builder.AddByte(0, Byte, 0); }
  public static void AddUShort(FlatBufferBuilder builder, ushort UShort) { builder.AddUshort(1, UShort, 0); }
  public static void AddShort(FlatBufferBuilder builder, short Short) { builder.AddShort(2, Short, 0); }
  public static void AddBool(FlatBufferBuilder builder, bool Bool) { builder.AddBool(3, Bool, false); }
  public static void AddUInt(FlatBufferBuilder builder, uint UInt) { builder.AddUint(4, UInt, 0); }
  public static void AddInt(FlatBufferBuilder builder, int Int) { builder.AddInt(5, Int, 0); }
  public static void AddSByte(FlatBufferBuilder builder, sbyte SByte) { builder.AddSbyte(6, SByte, 0); }
  public static void AddULong(FlatBufferBuilder builder, ulong ULong) { builder.AddUlong(7, ULong, 0); }
  public static void AddLong(FlatBufferBuilder builder, long Long) { builder.AddLong(8, Long, 0); }
  public static void AddFloat(FlatBufferBuilder builder, float Float) { builder.AddFloat(9, Float, 0.0f); }
  public static void AddDouble(FlatBufferBuilder builder, double Double) { builder.AddDouble(10, Double, 0.0); }
  public static void AddString(FlatBufferBuilder builder, StringOffset StringOffset) { builder.AddOffset(11, StringOffset.Value, 0); }
  public static Offset<BasicTypes> EndBasicTypes(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<BasicTypes>(o);
  }
};

public struct Simple : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Simple GetRootAsSimple(ByteBuffer _bb) { return GetRootAsSimple(_bb, new Simple()); }
  public static Simple GetRootAsSimple(ByteBuffer _bb, Simple obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Simple __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte Byte { get { int o = __p.__offset(4); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public int Int { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string String { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetStringBytes() { return __p.__vector_as_arraysegment(8); }
  public Location? Location { get { int o = __p.__offset(10); return o != 0 ? (Location?)(new Location()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartSimple(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddByte(FlatBufferBuilder builder, byte Byte) { builder.AddByte(0, Byte, 0); }
  public static void AddInt(FlatBufferBuilder builder, int Int) { builder.AddInt(1, Int, 0); }
  public static void AddString(FlatBufferBuilder builder, StringOffset stringOffset) { builder.AddOffset(2, stringOffset.Value, 0); }
  public static void AddLocation(FlatBufferBuilder builder, Offset<Location> LocationOffset) { builder.AddStruct(3, LocationOffset.Value, 0); }
  public static Offset<Simple> EndSimple(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Simple>(o);
  }
};

public struct LinkedListNode : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static LinkedListNode GetRootAsLinkedListNode(ByteBuffer _bb) { return GetRootAsLinkedListNode(_bb, new LinkedListNode()); }
  public static LinkedListNode GetRootAsLinkedListNode(ByteBuffer _bb, LinkedListNode obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public LinkedListNode __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Value { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(4); }
  public LinkedListNode? Next { get { int o = __p.__offset(6); return o != 0 ? (LinkedListNode?)(new LinkedListNode()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<LinkedListNode> CreateLinkedListNode(FlatBufferBuilder builder,
      StringOffset ValueOffset = default(StringOffset),
      Offset<LinkedListNode> NextOffset = default(Offset<LinkedListNode>)) {
    builder.StartObject(2);
    LinkedListNode.AddNext(builder, NextOffset);
    LinkedListNode.AddValue(builder, ValueOffset);
    return LinkedListNode.EndLinkedListNode(builder);
  }

  public static void StartLinkedListNode(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset ValueOffset) { builder.AddOffset(0, ValueOffset.Value, 0); }
  public static void AddNext(FlatBufferBuilder builder, Offset<LinkedListNode> NextOffset) { builder.AddOffset(1, NextOffset.Value, 0); }
  public static Offset<LinkedListNode> EndLinkedListNode(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<LinkedListNode>(o);
  }
};

public struct Vectors : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Vectors GetRootAsVectors(ByteBuffer _bb) { return GetRootAsVectors(_bb, new Vectors()); }
  public static Vectors GetRootAsVectors(ByteBuffer _bb, Vectors obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vectors __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int IntVector(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int IntVectorLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetIntVectorBytes() { return __p.__vector_as_arraysegment(4); }
  public long LongVector(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int LongVectorLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetLongVectorBytes() { return __p.__vector_as_arraysegment(6); }
  public byte ByteVector1(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int ByteVector1Length { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetByteVector1Bytes() { return __p.__vector_as_arraysegment(8); }
  public byte ByteVector2(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int ByteVector2Length { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetByteVector2Bytes() { return __p.__vector_as_arraysegment(10); }

  public static Offset<Vectors> CreateVectors(FlatBufferBuilder builder,
      VectorOffset IntVectorOffset = default(VectorOffset),
      VectorOffset LongVectorOffset = default(VectorOffset),
      VectorOffset ByteVector1Offset = default(VectorOffset),
      VectorOffset ByteVector2Offset = default(VectorOffset)) {
    builder.StartObject(4);
    Vectors.AddByteVector2(builder, ByteVector2Offset);
    Vectors.AddByteVector1(builder, ByteVector1Offset);
    Vectors.AddLongVector(builder, LongVectorOffset);
    Vectors.AddIntVector(builder, IntVectorOffset);
    return Vectors.EndVectors(builder);
  }

  public static void StartVectors(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddIntVector(FlatBufferBuilder builder, VectorOffset IntVectorOffset) { builder.AddOffset(0, IntVectorOffset.Value, 0); }
  public static VectorOffset CreateIntVectorVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartIntVectorVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLongVector(FlatBufferBuilder builder, VectorOffset LongVectorOffset) { builder.AddOffset(1, LongVectorOffset.Value, 0); }
  public static VectorOffset CreateLongVectorVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartLongVectorVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddByteVector1(FlatBufferBuilder builder, VectorOffset ByteVector1Offset) { builder.AddOffset(2, ByteVector1Offset.Value, 0); }
  public static VectorOffset CreateByteVector1Vector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartByteVector1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddByteVector2(FlatBufferBuilder builder, VectorOffset ByteVector2Offset) { builder.AddOffset(3, ByteVector2Offset.Value, 0); }
  public static VectorOffset CreateByteVector2Vector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartByteVector2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<Vectors> EndVectors(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Vectors>(o);
  }
};

public struct LocationHolder : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static LocationHolder GetRootAsLocationHolder(ByteBuffer _bb) { return GetRootAsLocationHolder(_bb, new LocationHolder()); }
  public static LocationHolder GetRootAsLocationHolder(ByteBuffer _bb, LocationHolder obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public LocationHolder __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Location? SingleLocation { get { int o = __p.__offset(4); return o != 0 ? (Location?)(new Location()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public string Fake { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetFakeBytes() { return __p.__vector_as_arraysegment(6); }
  public Location? LocationVector(int j) { int o = __p.__offset(8); return o != 0 ? (Location?)(new Location()).__assign(__p.__vector(o) + j * 12, __p.bb) : null; }
  public int LocationVectorLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static void StartLocationHolder(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddSingleLocation(FlatBufferBuilder builder, Offset<Location> SingleLocationOffset) { builder.AddStruct(0, SingleLocationOffset.Value, 0); }
  public static void AddFake(FlatBufferBuilder builder, StringOffset FakeOffset) { builder.AddOffset(1, FakeOffset.Value, 0); }
  public static void AddLocationVector(FlatBufferBuilder builder, VectorOffset LocationVectorOffset) { builder.AddOffset(2, LocationVectorOffset.Value, 0); }
  public static void StartLocationVectorVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(12, numElems, 4); }
  public static Offset<LocationHolder> EndLocationHolder(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<LocationHolder>(o);
  }
};

public struct Location : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Location __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
  public float Z { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }

  public static Offset<Location> CreateLocation(FlatBufferBuilder builder, float X, float Y, float Z) {
    builder.Prep(4, 12);
    builder.PutFloat(Z);
    builder.PutFloat(Y);
    builder.PutFloat(X);
    return new Offset<Location>(builder.Offset);
  }
};

public struct AlignmentTestInner : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public AlignmentTestInner __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte A { get { return __p.bb.Get(__p.bb_pos + 0); } }
  public int B { get { return __p.bb.GetInt(__p.bb_pos + 4); } }
  public sbyte C { get { return __p.bb.GetSbyte(__p.bb_pos + 8); } }

  public static Offset<AlignmentTestInner> CreateAlignmentTestInner(FlatBufferBuilder builder, byte A, int B, sbyte C) {
    builder.Prep(4, 12);
    builder.Pad(3);
    builder.PutSbyte(C);
    builder.PutInt(B);
    builder.Pad(3);
    builder.PutByte(A);
    return new Offset<AlignmentTestInner>(builder.Offset);
  }
};

public struct AlignmentTestOuter : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public AlignmentTestOuter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte A { get { return __p.bb.Get(__p.bb_pos + 0); } }
  public ushort B { get { return __p.bb.GetUshort(__p.bb_pos + 2); } }
  public byte C { get { return __p.bb.Get(__p.bb_pos + 4); } }
  public uint D { get { return __p.bb.GetUint(__p.bb_pos + 8); } }
  public byte E { get { return __p.bb.Get(__p.bb_pos + 12); } }
  public ulong F { get { return __p.bb.GetUlong(__p.bb_pos + 16); } }
  public AlignmentTestInner G { get { return (new AlignmentTestInner()).__assign(__p.bb_pos + 24, __p.bb); } }

  public static Offset<AlignmentTestOuter> CreateAlignmentTestOuter(FlatBufferBuilder builder, byte A, ushort B, byte C, uint D, byte E, ulong F, byte g_A, int g_B, sbyte g_C) {
    builder.Prep(8, 40);
    builder.Pad(4);
    builder.Prep(4, 12);
    builder.Pad(3);
    builder.PutSbyte(g_C);
    builder.PutInt(g_B);
    builder.Pad(3);
    builder.PutByte(g_A);
    builder.PutUlong(F);
    builder.Pad(3);
    builder.PutByte(E);
    builder.PutUint(D);
    builder.Pad(3);
    builder.PutByte(C);
    builder.PutUshort(B);
    builder.Pad(1);
    builder.PutByte(A);
    return new Offset<AlignmentTestOuter>(builder.Offset);
  }
};

public struct AlignmentTestOuterHoder : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static AlignmentTestOuterHoder GetRootAsAlignmentTestOuterHoder(ByteBuffer _bb) { return GetRootAsAlignmentTestOuterHoder(_bb, new AlignmentTestOuterHoder()); }
  public static AlignmentTestOuterHoder GetRootAsAlignmentTestOuterHoder(ByteBuffer _bb, AlignmentTestOuterHoder obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public AlignmentTestOuterHoder __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public AlignmentTestOuter? Value { get { int o = __p.__offset(4); return o != 0 ? (AlignmentTestOuter?)(new AlignmentTestOuter()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartAlignmentTestOuterHoder(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddValue(FlatBufferBuilder builder, Offset<AlignmentTestOuter> ValueOffset) { builder.AddStruct(0, ValueOffset.Value, 0); }
  public static Offset<AlignmentTestOuterHoder> EndAlignmentTestOuterHoder(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<AlignmentTestOuterHoder>(o);
  }
};


}
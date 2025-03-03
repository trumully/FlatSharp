// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpEndToEndTests.Oracle.Flatc
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AlignmentTestInner : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public AlignmentTestInner __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte A { get { return __p.bb.Get(__p.bb_pos + 0); } }
  public int B { get { return __p.bb.GetInt(__p.bb_pos + 4); } }
  public sbyte C { get { return __p.bb.GetSbyte(__p.bb_pos + 8); } }

  public static Offset<FlatSharpEndToEndTests.Oracle.Flatc.AlignmentTestInner> CreateAlignmentTestInner(FlatBufferBuilder builder, byte A, int B, sbyte C) {
    builder.Prep(4, 12);
    builder.Pad(3);
    builder.PutSbyte(C);
    builder.PutInt(B);
    builder.Pad(3);
    builder.PutByte(A);
    return new Offset<FlatSharpEndToEndTests.Oracle.Flatc.AlignmentTestInner>(builder.Offset);
  }
  public AlignmentTestInnerT UnPack() {
    var _o = new AlignmentTestInnerT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AlignmentTestInnerT _o) {
    _o.A = this.A;
    _o.B = this.B;
    _o.C = this.C;
  }
  public static Offset<FlatSharpEndToEndTests.Oracle.Flatc.AlignmentTestInner> Pack(FlatBufferBuilder builder, AlignmentTestInnerT _o) {
    if (_o == null) return default(Offset<FlatSharpEndToEndTests.Oracle.Flatc.AlignmentTestInner>);
    return CreateAlignmentTestInner(
      builder,
      _o.A,
      _o.B,
      _o.C);
  }
}

public class AlignmentTestInnerT
{
  public byte A { get; set; }
  public int B { get; set; }
  public sbyte C { get; set; }

  public AlignmentTestInnerT() {
    this.A = 0;
    this.B = 0;
    this.C = 0;
  }
}


}

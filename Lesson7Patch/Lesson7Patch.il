
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly extern System.Linq
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly Lesson7
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 35 2E 30 01 00 54 0E 14   // ersion=v5.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 07 52 65 6C 65 61 73 65 00 00 )             // ...Release..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Lesson7.dll
// MVID: {A962E7D6-DD7F-436C-AB64-A9C93E17A7E6}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x092A0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Lesson7.Program
       extends [System.Runtime]System.Object
{
  .method public hidebysig static int32[0...,0...] 
          SortArray(int32[0...,0...] 'array') cil managed
  {
    // Размер кода:       139 (0x8b)
    .maxstack  6
    .locals init (int32 V_0,
             int32 V_1,
             int32 V_2,
             int32 V_3)
    IL_0000:  ldc.i4.0
    IL_0001:  stloc.0
    IL_0002:  br.s       IL_007c

    IL_0004:  ldc.i4.0
    IL_0005:  stloc.1
    IL_0006:  br.s       IL_006c

    IL_0008:  ldarg.0
    IL_0009:  ldloc.1
    IL_000a:  ldc.i4.1
    IL_000b:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_0010:  ldarg.0
    IL_0011:  ldloc.1
    IL_0012:  ldc.i4.1
    IL_0013:  add
    IL_0014:  ldc.i4.1
    IL_0015:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_001a:  bge.s      IL_0068

    IL_001c:  ldarg.0
    IL_001d:  ldloc.1
    IL_001e:  ldc.i4.1
    IL_001f:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_0024:  stloc.2
    IL_0025:  ldarg.0
    IL_0026:  ldloc.1
    IL_0027:  ldc.i4.0
    IL_0028:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_002d:  stloc.3
    IL_002e:  ldarg.0
    IL_002f:  ldloc.1
    IL_0030:  ldc.i4.0
    IL_0031:  ldarg.0
    IL_0032:  ldloc.1
    IL_0033:  ldc.i4.1
    IL_0034:  add
    IL_0035:  ldc.i4.0
    IL_0036:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_003b:  call       instance void int32[0...,0...]::Set(int32,
                                                             int32,
                                                             int32)
    IL_0040:  ldarg.0
    IL_0041:  ldloc.1
    IL_0042:  ldc.i4.1
    IL_0043:  ldarg.0
    IL_0044:  ldloc.1
    IL_0045:  ldc.i4.1
    IL_0046:  add
    IL_0047:  ldc.i4.1
    IL_0048:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_004d:  call       instance void int32[0...,0...]::Set(int32,
                                                             int32,
                                                             int32)
    IL_0052:  ldarg.0
    IL_0053:  ldloc.1
    IL_0054:  ldc.i4.1
    IL_0055:  add
    IL_0056:  ldc.i4.0
    IL_0057:  ldloc.3
    IL_0058:  call       instance void int32[0...,0...]::Set(int32,
                                                             int32,
                                                             int32)
    IL_005d:  ldarg.0
    IL_005e:  ldloc.1
    IL_005f:  ldc.i4.1
    IL_0060:  add
    IL_0061:  ldc.i4.1
    IL_0062:  ldloc.2
    IL_0063:  call       instance void int32[0...,0...]::Set(int32,
                                                             int32,
                                                             int32)
    IL_0068:  ldloc.1
    IL_0069:  ldc.i4.1
    IL_006a:  add
    IL_006b:  stloc.1
    IL_006c:  ldloc.1
    IL_006d:  ldarg.0
    IL_006e:  ldc.i4.0
    IL_006f:  callvirt   instance int32 [System.Runtime]System.Array::GetLength(int32)
    IL_0074:  ldc.i4.1
    IL_0075:  sub
    IL_0076:  blt.s      IL_0008

    IL_0078:  ldloc.0
    IL_0079:  ldc.i4.1
    IL_007a:  add
    IL_007b:  stloc.0
    IL_007c:  ldloc.0
    IL_007d:  ldarg.0
    IL_007e:  ldc.i4.0
    IL_007f:  callvirt   instance int32 [System.Runtime]System.Array::GetLength(int32)
    IL_0084:  blt        IL_0004

    IL_0089:  ldarg.0
    IL_008a:  ret
  } // end of method Program::SortArray

  .method public hidebysig static void  GetPackagedBag(int32 maxWeight,
                                                       int32[] itemsPrice,
                                                       int32[] itemsWeight,
                                                       string[] itemsName) cil managed
  {
    // Размер кода:       287 (0x11f)
    .maxstack  6
    .locals init (int32[0...,0...] V_0,
             string V_1,
             int32 V_2,
             int32[] V_3,
             int32 V_4,
             int32 V_5,
             int32 V_6)
    IL_0000:  ldarg.2
    IL_0001:  ldlen
    IL_0002:  conv.i4
    IL_0003:  ldc.i4.2
    IL_0004:  newobj     instance void int32[0...,0...]::.ctor(int32,
                                                               int32)
    IL_0009:  stloc.0
    IL_000a:  ldnull
    IL_000b:  stloc.1
    IL_000c:  ldc.i4.0
    IL_000d:  stloc.2
    IL_000e:  ldc.i4.0
    IL_000f:  stloc.s    V_4
    IL_0011:  br.s       IL_0036

    IL_0013:  ldloc.0
    IL_0014:  ldloc.s    V_4
    IL_0016:  ldc.i4.0
    IL_0017:  ldloc.s    V_4
    IL_0019:  call       instance void int32[0...,0...]::Set(int32,
                                                             int32,
                                                             int32)
    IL_001e:  ldloc.0
    IL_001f:  ldloc.s    V_4
    IL_0021:  ldc.i4.1
    IL_0022:  ldarg.1
    IL_0023:  ldloc.s    V_4
    IL_0025:  ldelem.i4
    IL_0026:  ldarg.2
    IL_0027:  ldloc.s    V_4
    IL_0029:  ldelem.i4
    IL_002a:  mul
    IL_002b:  call       instance void int32[0...,0...]::Set(int32,
                                                             int32,
                                                             int32)
    IL_0030:  ldloc.s    V_4
    IL_0032:  ldc.i4.1
    IL_0033:  add
    IL_0034:  stloc.s    V_4
    IL_0036:  ldloc.s    V_4
    IL_0038:  ldarg.2
    IL_0039:  ldlen
    IL_003a:  conv.i4
    IL_003b:  blt.s      IL_0013

    IL_003d:  ldloc.0
    IL_003e:  call       int32[0...,0...] Lesson7.Program::SortArray(int32[0...,0...])
    IL_0043:  stloc.0
    IL_0044:  ldc.i4.0
    IL_0045:  stloc.s    V_5
    IL_0047:  br.s       IL_0088

    IL_0049:  ldarg.0
    IL_004a:  ldarg.2
    IL_004b:  ldloc.0
    IL_004c:  ldloc.s    V_5
    IL_004e:  ldc.i4.0
    IL_004f:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_0054:  ldelem.i4
    IL_0055:  sub
    IL_0056:  ldc.i4.0
    IL_0057:  blt.s      IL_0082

    IL_0059:  ldarg.0
    IL_005a:  ldarg.2
    IL_005b:  ldloc.0
    IL_005c:  ldloc.s    V_5
    IL_005e:  ldc.i4.0
    IL_005f:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_0064:  ldelem.i4
    IL_0065:  sub
    IL_0066:  starg.s    maxWeight
    IL_0068:  ldloc.1
    IL_0069:  ldloc.0
    IL_006a:  ldloc.s    V_5
    IL_006c:  ldc.i4.0
    IL_006d:  call       instance int32& int32[0...,0...]::Address(int32,
                                                                   int32)
    IL_0072:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0077:  ldstr      " "
    IL_007c:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string,
                                                                      string)
    IL_0081:  stloc.1
    IL_0082:  ldloc.s    V_5
    IL_0084:  ldc.i4.1
    IL_0085:  add
    IL_0086:  stloc.s    V_5
    IL_0088:  ldloc.s    V_5
    IL_008a:  ldarg.2
    IL_008b:  ldlen
    IL_008c:  conv.i4
    IL_008d:  blt.s      IL_0049

    IL_008f:  ldstr      bytearray (12 04 20 00 40 04 4E 04 3A 04 37 04 30 04 3A 04   // .. .@.N.:.7.0.:.
                                    20 00 32 04 3C 04 35 04 41 04 42 04 38 04 3B 04   //  .2.<.5.A.B.8.;.
                                    38 04 41 04 4C 04 20 00 32 04 35 04 49 04 38 04   // 8.A.L. .2.5.I.8.
                                    3A 00 )                                           // :.
    IL_0094:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0099:  ldloc.1
    IL_009a:  callvirt   instance string [System.Runtime]System.String::Trim()
    IL_009f:  ldc.i4.s   32
    IL_00a1:  ldc.i4.0
    IL_00a2:  callvirt   instance string[] [System.Runtime]System.String::Split(char,
                                                                                valuetype [System.Runtime]System.StringSplitOptions)
    IL_00a7:  ldnull
    IL_00a8:  ldftn      int32 [System.Runtime]System.Int32::Parse(string)
    IL_00ae:  newobj     instance void class [System.Runtime]System.Func`2<string,int32>::.ctor(object,
                                                                                                native int)
    IL_00b3:  call       class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!1> [System.Linq]System.Linq.Enumerable::Select<string,int32>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                       class [System.Runtime]System.Func`2<!!0,!!1>)
    IL_00b8:  call       !!0[] [System.Linq]System.Linq.Enumerable::ToArray<int32>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_00bd:  stloc.3
    IL_00be:  ldc.i4.0
    IL_00bf:  stloc.s    V_6
    IL_00c1:  br.s       IL_0102

    IL_00c3:  ldstr      bytearray (1D 04 30 04 38 04 3C 04 35 04 3D 04 3E 04 32 04   // ..0.8.<.5.=.>.2.
                                    30 04 3D 04 38 04 35 04 3A 00 20 00 7B 00 30 00   // 0.=.8.5.:. .{.0.
                                    7D 00 2C 00 20 00 12 04 35 04 41 04 3A 00 20 00   // }.,. ...5.A.:. .
                                    7B 00 31 00 7D 00 2C 00 20 00 21 04 42 04 3E 04   // {.1.}.,. .!.B.>.
                                    38 04 3C 04 3E 04 41 04 42 04 4C 04 3A 00 20 00   // 8.<.>.A.B.L.:. .
                                    7B 00 32 00 7D 00 )                               // {.2.}.
    IL_00c8:  ldarg.3
    IL_00c9:  ldloc.3
    IL_00ca:  ldloc.s    V_6
    IL_00cc:  ldelem.i4
    IL_00cd:  ldelem.ref
    IL_00ce:  ldarg.2
    IL_00cf:  ldloc.3
    IL_00d0:  ldloc.s    V_6
    IL_00d2:  ldelem.i4
    IL_00d3:  ldelem.i4
    IL_00d4:  box        [System.Runtime]System.Int32
    IL_00d9:  ldarg.1
    IL_00da:  ldloc.3
    IL_00db:  ldloc.s    V_6
    IL_00dd:  ldelem.i4
    IL_00de:  ldelem.i4
    IL_00df:  box        [System.Runtime]System.Int32
    IL_00e4:  call       string [System.Runtime]System.String::Format(string,
                                                                      object,
                                                                      object,
                                                                      object)
    IL_00e9:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00ee:  ldloc.2
    IL_00ef:  ldloc.0
    IL_00f0:  ldloc.3
    IL_00f1:  ldloc.s    V_6
    IL_00f3:  ldelem.i4
    IL_00f4:  ldc.i4.1
    IL_00f5:  call       instance int32 int32[0...,0...]::Get(int32,
                                                              int32)
    IL_00fa:  add
    IL_00fb:  stloc.2
    IL_00fc:  ldloc.s    V_6
    IL_00fe:  ldc.i4.1
    IL_00ff:  add
    IL_0100:  stloc.s    V_6
    IL_0102:  ldloc.s    V_6
    IL_0104:  ldloc.3
    IL_0105:  ldlen
    IL_0106:  conv.i4
    IL_0107:  blt.s      IL_00c3

    IL_0109:  ldstr      bytearray (1C 04 30 04 3A 04 41 04 38 04 3C 04 30 04 3B 04   // ..0.:.A.8.<.0.;.
                                    4C 04 3D 04 30 04 4F 04 20 00 46 04 35 04 3D 04   // L.=.0.O. .F.5.=.
                                    30 04 20 00 3A 00 20 00 7B 00 30 00 7D 00 )       // 0. .:. .{.0.}.
    IL_010e:  ldloc.2
    IL_010f:  box        [System.Runtime]System.Int32
    IL_0114:  call       string [System.Runtime]System.String::Format(string,
                                                                      object)
    IL_0119:  call       void [System.Console]System.Console::WriteLine(string)
    IL_011e:  ret
  } // end of method Program::GetPackagedBag

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       229 (0xe5)
    .maxstack  4
    .locals init (string[] V_0,
             int32[] V_1,
             int32[] V_2,
             int32 V_3,
             int32 V_4,
             string V_5,
             int32 V_6)
    IL_0000:  ldstr      bytearray (30 00 20 00 2D 00 20 00 32 04 4B 04 39 04 42 04   // 0. .-. .2.K.9.B.
                                    38 04 20 00 38 04 37 04 20 00 3F 04 40 04 3E 04   // 8. .8.7. .?.@.>.
                                    33 04 40 04 30 04 3C 04 3C 04 4B 04 )             // 3.@.0.<.<.K.
    IL_0005:  call       void [System.Console]System.Console::WriteLine(string)
    IL_000a:  ldstr      bytearray (31 00 20 00 2D 00 20 00 40 04 35 04 48 04 38 04   // 1. .-. .@.5.H.8.
                                    42 04 4C 04 20 00 37 04 30 04 34 04 30 04 47 04   // B.L. .7.0.4.0.G.
                                    43 04 20 00 3E 04 20 00 40 04 4E 04 3A 04 37 04   // C. .>. .@.N.:.7.
                                    30 04 3A 04 35 04 )                               // 0.:.5.
    IL_000f:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0014:  call       string [System.Console]System.Console::ReadLine()
    IL_0019:  callvirt   instance string [System.Runtime]System.String::Trim()
    IL_001e:  stloc.s    V_5
    IL_0020:  ldloc.s    V_5
    IL_0022:  ldstr      "0"
    IL_0027:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_002c:  brtrue.s   IL_003d

    IL_002e:  ldloc.s    V_5
    IL_0030:  ldstr      "1"
    IL_0035:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_003a:  brfalse.s   IL_0044

    IL_003c:  ret

    IL_003d:  ldc.i4.0
    IL_003e:  call       void [System.Runtime]System.Environment::Exit(int32)
    IL_0043:  ret

    IL_0044:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3C 04 30 04 3A 04 41 04 38 04 3C 04 30 04 3B 04   // <.0.:.A.8.<.0.;.
                                    4C 04 3D 04 43 04 4E 04 20 00 33 04 40 04 43 04   // L.=.C.N. .3.@.C.
                                    37 04 3E 04 3F 04 3E 04 34 04 4A 04 35 04 3C 04   // 7.>.?.>.4.J.5.<.
                                    3D 04 3E 04 41 04 42 04 4C 04 20 00 40 04 4E 04   // =.>.A.B.L. .@.N.
                                    3A 04 37 04 30 04 3A 04 30 04 )                   // :.7.0.:.0.
    IL_0049:  call       void [System.Console]System.Console::WriteLine(string)
    IL_004e:  call       string [System.Console]System.Console::ReadLine()
    IL_0053:  call       int32 [System.Runtime]System.Convert::ToInt32(string)
    IL_0058:  stloc.3
    IL_0059:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    41 04 3A 04 3E 04 3B 04 4C 04 3A 04 3E 04 20 00   // A.:.>.;.L.:.>. .
                                    32 04 35 04 49 04 35 04 39 04 20 00 32 04 4B 04   // 2.5.I.5.9. .2.K.
                                    20 00 45 04 3E 04 42 04 38 04 42 04 35 04 20 00   //  .E.>.B.8.B.5. .
                                    3F 04 3E 04 3C 04 35 04 41 04 42 04 38 04 42 04   // ?.>.<.5.A.B.8.B.
                                    4C 04 20 00 32 04 20 00 40 04 4E 04 3A 04 37 04   // L. .2. .@.N.:.7.
                                    30 04 3A 04 )                                     // 0.:.
    IL_005e:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0063:  call       string [System.Console]System.Console::ReadLine()
    IL_0068:  call       int32 [System.Runtime]System.Convert::ToInt32(string)
    IL_006d:  stloc.s    V_4
    IL_006f:  ldloc.s    V_4
    IL_0071:  newarr     [System.Runtime]System.String
    IL_0076:  stloc.0
    IL_0077:  ldloc.s    V_4
    IL_0079:  newarr     [System.Runtime]System.Int32
    IL_007e:  stloc.1
    IL_007f:  ldloc.s    V_4
    IL_0081:  newarr     [System.Runtime]System.Int32
    IL_0086:  stloc.2
    IL_0087:  ldc.i4.0
    IL_0088:  stloc.s    V_6
    IL_008a:  br.s       IL_00d5

    IL_008c:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3D 04 30 04 38 04 3C 04 35 04 3D 04 3E 04 32 04   // =.0.8.<.5.=.>.2.
                                    30 04 3D 04 38 04 35 04 20 00 32 04 35 04 49 04   // 0.=.8.5. .2.5.I.
                                    38 04 )                                           // 8.
    IL_0091:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0096:  ldloc.0
    IL_0097:  ldloc.s    V_6
    IL_0099:  call       string [System.Console]System.Console::ReadLine()
    IL_009e:  stelem.ref
    IL_009f:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    41 04 42 04 3E 04 38 04 3C 04 3E 04 41 04 42 04   // A.B.>.8.<.>.A.B.
                                    4C 04 20 00 32 04 35 04 49 04 38 04 20 00 37 04   // L. .2.5.I.8. .7.
                                    30 04 20 00 3E 04 34 04 3D 04 43 04 20 00 35 04   // 0. .>.4.=.C. .5.
                                    34 04 38 04 3D 04 38 04 46 04 43 04 20 00 40 04   // 4.8.=.8.F.C. .@.
                                    30 04 37 04 3C 04 35 04 40 04 3D 04 3E 04 41 04   // 0.7.<.5.@.=.>.A.
                                    42 04 38 04 20 00 40 04 4E 04 3A 04 37 04 30 04   // B.8. .@.N.:.7.0.
                                    3A 04 30 04 )                                     // :.0.
    IL_00a4:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00a9:  ldloc.1
    IL_00aa:  ldloc.s    V_6
    IL_00ac:  call       string [System.Console]System.Console::ReadLine()
    IL_00b1:  call       int32 [System.Runtime]System.Convert::ToInt32(string)
    IL_00b6:  stelem.i4
    IL_00b7:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    32 04 35 04 41 04 20 00 32 04 35 04 49 04 38 04 ) // 2.5.A. .2.5.I.8.
    IL_00bc:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00c1:  ldloc.2
    IL_00c2:  ldloc.s    V_6
    IL_00c4:  call       string [System.Console]System.Console::ReadLine()
    IL_00c9:  call       int32 [System.Runtime]System.Convert::ToInt32(string)
    IL_00ce:  stelem.i4
    IL_00cf:  ldloc.s    V_6
    IL_00d1:  ldc.i4.1
    IL_00d2:  add
    IL_00d3:  stloc.s    V_6
    IL_00d5:  ldloc.s    V_6
    IL_00d7:  ldloc.s    V_4
    IL_00d9:  blt.s      IL_008c

    IL_00db:  ldloc.3
    IL_00dc:  ldloc.1
    IL_00dd:  ldloc.2
    IL_00de:  ldloc.0
    IL_00df:  call       void Lesson7.Program::GetPackagedBag(int32,
                                                              int32[],
                                                              int32[],
                                                              string[])
    IL_00e4:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class Lesson7.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 C:\Users\admin\Desktop\geekbrains\Lesson7Patch.res

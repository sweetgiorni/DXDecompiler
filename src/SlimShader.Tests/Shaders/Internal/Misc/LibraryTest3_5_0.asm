//
// Library:  flags 0, 1 functions:
//   0  TestFunction
//
// Created by:  Microsoft (R) HLSL Shader Compiler 10.1
//
//
// Generated by Microsoft (R) HLSL Shader Compiler 10.1
//
//
// Buffer Definitions: 
//
// cbuffer $Globals
// {
//
//   float4 TestGlobal1;                // Offset:    0 Size:    16
//      = 0x40a00000 0x40a00000 0x40a00000 0x40a00000 
//   int4 TestGlobal2;                  // Offset:   16 Size:    16
//      = 0x00000006 0x00000006 0x00000006 0x00000006 
//   
//   struct TestStruct
//   {
//       
//       float3 Member1;                // Offset:   32
//       int3 Member2;                  // Offset:   48
//
//   } Foo;                             // Offset:   32 Size:    28
//
// }
//
//
// Resource Bindings:
//
// Name                                 Type  Format         Dim      HLSL Bind  Count
// ------------------------------ ---------- ------- ----------- -------------- ------
// $Globals                          cbuffer      NA          NA            cb0      1 
//
//
//
// Function parameter signature (return: yes, parameters: 1):
//
// Name                 SemanticName         In 1st,Num,Mask Out 1st,Num,Mask Type                           
// -------------------- -------------------- --------------- ---------------- ------------------------------ 
// TestFunction                                                o0    1   xyzw out float4
// input                                      v0    1   x                     in uint
//
lib_5_0
dcl_globalFlags refactoringAllowed
dcl_constantbuffer CB0[4], immediateIndexed
dcl_input v0.x
dcl_output o0.xyzw
dcl_temps 2
utof r0.x, v0.x
mad r0.xyzw, r0.xxxx, l(2.000000, 2.000000, 2.000000, 2.000000), cb0[0].xyzw
itof r1.xyzw, cb0[1].xyzw
add r0.xyzw, r0.xyzw, r1.xyzw
add r0.xyzw, r0.xyzw, cb0[2].xyzx
itof r1.xyzw, cb0[3].xyzx
add o0.xyzw, r0.xyzw, r1.xyzw
ret 
// Approximately 8 instruction slots used

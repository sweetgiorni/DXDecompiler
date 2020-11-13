//
// Generated by Microsoft (R) HLSL Shader Compiler 10.1
//
// Parameters:
//
//   sampler2D CurFramePixelVelSampler;
//   sampler2D LastFramePixelVelSampler;
//   float PixelBlurConst;
//   sampler2D RenderTargetSampler;
//
//
// Registers:
//
//   Name                     Reg   Size
//   ------------------------ ----- ----
//   PixelBlurConst           c0       1
//   RenderTargetSampler      s0       1
//   CurFramePixelVelSampler  s1       1
//   LastFramePixelVelSampler s2       1
//

    ps_2_0
    def c1, 0.0833333358, 0.166666672, 0.25, 0.333333343
    def c2, 0.75, 0.833333373, 0.916666687, 1
    def c3, 0.416666687, 0.5, 0.583333373, 0.666666687
    dcl t0.xy
    dcl_2d s0
    dcl_2d s1
    dcl_2d s2
    texld r0, t0, s1
    texld r1, t0, s2
    mul r0.z, r0.y, r0.y
    mad r0.z, r0.x, r0.x, r0.z
    mul r0.w, r1.y, r1.y
    mad r0.w, r1.x, r1.x, r0.w
    add r0.z, -r0.w, r0.z
    mul r2.x, r1.x, c0.x
    mul r2.y, -r1.y, c0.x
    mul r1.x, r0.x, c0.x
    mul r1.y, -r0.y, c0.x
    cmp r0.xy, r0.z, r1, r2
    mad r1.xy, r0, c1.x, t0
    mad r2.xy, r0, c1.y, t0
    mad r3.xy, r0, c1.z, t0
    mad r4.xy, r0, c1.w, t0
    mad r5.xy, r0, c3.x, t0
    mad r6.xy, r0, c3.y, t0
    mad r7.xy, r0, c3.z, t0
    mad r8.xy, r0, c3.w, t0
    mad r9.xy, r0, c2.x, t0
    texld r10, t0, s0
    texld r1, r1, s0
    texld r2, r2, s0
    texld r3, r3, s0
    texld r4, r4, s0
    texld r5, r5, s0
    texld r6, r6, s0
    texld r7, r7, s0
    texld r8, r8, s0
    texld r9, r9, s0
    add r1.xyz, r1, r10
    add r1.xyz, r2, r1
    add r1.xyz, r3, r1
    add r1.xyz, r4, r1
    add r1.xyz, r5, r1
    add r1.xyz, r6, r1
    add r1.xyz, r7, r1
    add r1.xyz, r8, r1
    add r1.xyz, r9, r1
    mad r2.xy, r0, c2.y, t0
    mad r0.xy, r0, c2.z, t0
    texld r0, r0, s0
    texld r2, r2, s0
    add r1.xyz, r1, r2
    add r0.xyz, r0, r1
    mul r0.xyz, r0, c1.x
    mov r0.w, c2.w
    mov oC0, r0

// approximately 49 instruction slots used (14 texture, 35 arithmetic)
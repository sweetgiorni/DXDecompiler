//
// Generated by Microsoft (R) HLSL Shader Compiler 10.1
//
// Parameters:
//
//   samplerCUBE EnvironmentSampler;
//   float g_fAlpha;
//   float g_fScale;
//
//
// Registers:
//
//   Name               Reg   Size
//   ------------------ ----- ----
//   g_fAlpha           c0       1
//   g_fScale           c1       1
//   EnvironmentSampler s0       1
//

    ps_2_0
    dcl t0.xyz
    dcl_cube s0
    texld r0, t0, s0
    mul r0.xyz, r0, c1.x
    mov r0.w, c0.x
    mov oC0, r0

// approximately 4 instruction slots used (1 texture, 3 arithmetic)
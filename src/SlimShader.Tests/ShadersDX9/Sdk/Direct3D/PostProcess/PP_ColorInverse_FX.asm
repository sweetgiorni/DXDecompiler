
//listing of all techniques and passes with embedded asm listings 

technique PostProcess
{
    pass p0
    {
        //No embedded vertex shader
        pixelshader = 
            asm {
            //
            // Generated by Microsoft (R) HLSL Shader Compiler 10.1
            //
            // Parameters:
            //
            //   sampler2D g_samSrcColor;
            //
            //
            // Registers:
            //
            //   Name          Reg   Size
            //   ------------- ----- ----
            //   g_samSrcColor s0       1
            //
            
                ps_2_0
                def c0, 1, 0, 0, 0
                dcl t0.xy
                dcl_2d s0
                texld r0, t0, s0
                add r0, -r0, c0.x
                mov oC0, r0
            
            // approximately 3 instruction slots used (1 texture, 2 arithmetic)
            };
    }
}


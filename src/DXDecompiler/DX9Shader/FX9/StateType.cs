﻿namespace SlimShader.DX9Shader.FX9
{
	public enum StateType
	{
		/// <summary>
		/// Vertex Pipe Render States. Based of D3DRENDERSTATETYPE.
		/// </summary>
		ZEnable = 0,
		FillMode = 1,
		ShadeMode = 2,
		ZWriteEnable = 3,
		AlphaTestEnable = 4,
		LastPixel = 5,
		SrcBlend = 6,
		DestBlend = 7,
		CullMode = 8,
		ZFunc = 9,
		AlphaRef = 10,
		AlphaFunc = 11,
		DitherEnable = 12,
		AlphaBlendEnable = 13,
		FogEnable = 14,
		SpecularEnable = 15,
		FogColor = 16,
		FogTableMode = 17,
		FogStart = 18,
		FogEnd = 19,
		FogDensity = 20,
		RangeFogEnable = 21,
		StencilEnable = 22,
		StencilFail = 23,
		StencilZFail = 24,
		StencilPass = 25,
		StencilFunc = 26,
		StencilRef = 27,
		StencilMask = 28,
		StencilWriteMask = 29,
		TextureFactor = 30,
		Wrap0 = 31,
		Wrap1 = 32, 
		Wrap2 = 33,
		Wrap3 = 34,
		Wrap4 = 35,
		Wrap5 = 36,
		Wrap6 = 37,
		Wrap7 = 38,
		Wrap8 = 39,
		Wrap9 = 40,
		Wrap10 = 41,
		Wrap11 = 42,
		Wrap12 = 43,
		Wrap13 = 44,
		Wrap14 = 45,
		Wrap15 = 46,
		/// <summary>
		/// Pixel Pipe Render States. Based of D3DRENDERSTATETYPE.
		/// </summary>
		Clipping = 47,
		Lighting = 48,
		Ambient = 49,
		FogVertexMode = 50,
		ColorVertex = 51,
		LocalViewer = 52,
		NormalizeNormals = 53,
		DiffuseMaterialSource = 54,
		SpecularMaterialSource = 55,
		AmbientMaterialSource = 56,
		EmissiveMaterialSource = 57,
		VertexBlend = 58,
		ClipPlaneEnable = 59,
		PointSize = 60,
		PointSize_Min = 61,
		PointSize_Max = 62,
		PointSpriteEnable = 63,
		PointScaleEnable = 64,
		PointScale_A = 65,
		PointScale_B = 66,
		PointScale_C = 67,
		MultiSampleAntiAlias = 68,
		MultiSampleMask = 69,
		PatchEdgeStyle = 70,
		DebugMonitorToken = 71,
		IndexedVertexBlendEnable = 72,
		ColorWriteEnable = 73,
		TweenFactor = 74,
		BlendOp = 75,
		PositionDegree = 76,
		NormalDegree = 77,
		ScissorTestEnable = 78,
		SlopeScaleDepthBias = 79,
		AntiAliasedLineEnable = 80,
		MinTessellationLevel = 81,
		MaxTessellationLevel = 82,
		AdaptiveTess_X = 83,
		AdaptiveTess_Y = 84,
		AdaptiveTess_Z = 85,
		AdaptiveTess_W = 86,
		EnableAdaptiveTessellation = 87,
		TwoSidedStencilMode = 88,
		Ccw_StencilFail = 89,
		Ccw_StencilZFail = 90,
		Ccw_StencilPass = 91,
		Ccw_StencilFunc = 92,
		ColorWriteEnable1 = 93,
		ColorWriteEnable2 = 94,
		ColorWriteEnable3 = 95,
		BlendFactor = 96,
		SrgbWriteEnable = 97,
		DepthBias = 98,
		SeparateAlphaBlendEnable = 99,
		SrcBlendAlpha = 100,
		DestBlendAlpha = 101,
		BlendOpAlpha = 102,
		/// <summary>
		/// Texture Stage States. Based off D3DTEXTURESTAGESTATETYPE
		/// </summary>
		ColorOp = 103,
		ColorArg0 = 104,
		ColorArg1 = 105,
		ColorArg2 = 106,
		AlphaOp = 107,
		AlphaArg0 = 108,
		AlphaArg1 = 109,
		AlphaArg2 = 110,
		ResultArg = 111,
		BumpEnvMat00 = 112,
		BumpEnvMat01 = 113,
		BumpEnvMat10 = 114,
		BumpEnvMat11 = 115,
		TexCoordIndex = 116,
		BumpEnvLScale = 117,
		BumpEnvLOffset = 118,
		TextureTransformFlags = 119,
		Constant = 120,
		/// <summary>
		/// Transform States
		/// </summary>
		ProjectionTransform = 123,
		ViewTransform = 124,
		WorldTransform = 125,
		TextureTransform = 126,
		/// <summary>
		/// Material States. Refer https://docs.microsoft.com/en-us/windows/win32/direct3d9/effect-states
		/// </summary>
		MaterialDiffuse = 127,
		MaterialAmbient = 128,
		MaterialSpecular = 129,
		MaterialEmissive = 130,
		MaterialPower = 131,
		/// <summary>
		/// Light States. Refer https://docs.microsoft.com/en-us/windows/win32/direct3d9/effect-states
		/// </summary>
		LightType = 132,
		LightDiffuse = 133,
		LightSpecular = 134,
		LightAmbient = 135,
		LightPosition = 136,
		LightDirection = 137,
		LightRange = 138,
		LightFalloff = 139,
		LightAttenuation0 = 140,
		LightAttenuation1 = 141,
		LightAttenuation2 = 142,
		LightTheta = 143,
		LightPhi = 144,
		LightEnable = 145,
		/// <summary>
		/// Shader States. Refer https://docs.microsoft.com/en-us/windows/win32/direct3d9/effect-states
		/// </summary>
		VertexShader = 146,
		PixelShader = 147,
		/// <summary>
		/// Shader Constant States. Refer https://docs.microsoft.com/en-us/windows/win32/direct3d9/effect-states
		/// </summary>
		VertexShaderConstantF = 148,
		VertexShaderConstantB = 149,
		VertexShaderConstantI = 150,
		VertexShaderConstant = 151,
		VertexShaderConstant1 = 152,
		VertexShaderConstant2 = 153,
		VertexShaderConstant3 = 154,
		VertexShaderConstant4 = 155,
		PixelShaderConstantF = 156,
		PixelShaderConstantB = 157,
		PixelShaderConstantI = 158,
		PixelShaderConstant = 159,
		PixelShaderConstant1 = 160,
		PixelShaderConstant2 = 161,
		PixelShaderConstant3 = 162,
		PixelShaderConstant4 = 163,
		/// <summary>
		/// Texture States. Refer https://docs.microsoft.com/en-us/windows/win32/direct3d9/effect-states
		/// </summary>
		Texture = 164,
		/// <summary>
		/// Sampler Stage States. Refer https://docs.microsoft.com/en-us/windows/win32/direct3d9/effect-states
		/// </summary>
		AddressU = 165,
		AddressV = 166,
		AddressW = 167,
		BorderColor = 168,
		MagFilter = 169,
		MinFilter = 170,
		MipFilter = 171,
		MipMapLodBias = 172,
		MaxMipLevel = 173,
		MaxAnisotropy = 174,
		SRGBTexture = 175,
		/// <summary>
		/// Sampler State. Refer https://docs.microsoft.com/en-us/windows/win32/direct3d9/effect-states
		/// </summary>
		Sampler = 178,
	}
}
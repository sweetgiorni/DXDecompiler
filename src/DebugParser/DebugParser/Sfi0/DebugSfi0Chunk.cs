﻿using DXDecompiler.Chunks.Sfi0;

namespace DXDecompiler.DebugParser.Sfi0
{
	public class DebugSfi0Chunk : DebugBytecodeChunk
	{
		public ShaderRequiresFlags Flags;
		private DebugShaderVersion _version;
		public static DebugSfi0Chunk Parse(DebugBytecodeReader reader, DebugShaderVersion version, uint chunkSize)
		{
			var result = new DebugSfi0Chunk();
			var flags = reader.ReadEnum32<ShaderRequiresFlags>("flags");
			result.Flags = flags;
			result._version = version;
			var unknown = reader.ReadUInt32("Sfi0Unknown0");
			return result;
		}
	}
}

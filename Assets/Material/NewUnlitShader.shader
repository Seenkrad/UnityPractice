Shader "Custom/DoubleSided"
{
	Properties {
		_Color ("Main Color", Color) = (1,1,1,1)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		Pass {
			Cull Off
			ColorMaterial AmbientAndDiffuse
		}
	}
}

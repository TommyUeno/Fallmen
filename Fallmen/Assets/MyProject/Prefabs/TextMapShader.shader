Shader "Unlit/TextMapShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        
        _Index ("Index", int) = 0
        
        _MaxIndexX ("Max Index X", int) = 0
        _MaxIndexY ("Max Index Y", int) = 0
        
        _DiscardThreshold ("Discard Threashold", Range(0, 1)) = 0.5
    }
    
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue" = "Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha 
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _DiscardThreshold;

            int _Index;

            uniform int _MaxIndexX;
            uniform int _MaxIndexY;
            
            
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float letterSizeX = _MainTex_ST.x;
                float letterSizeY = _MainTex_ST.y;
                
                uint maxIndex = _MaxIndexX * _MaxIndexY;
                
                uint index = floor(_Index) % maxIndex;
                
                uint indexX = index % _MaxIndexX;
                uint indexY = index / _MaxIndexX;

                i.uv.x += letterSizeX * indexX;
                i.uv.y -= letterSizeY * indexY;
                
                fixed4 col = tex2D(_MainTex, i.uv);
                if(col.b > _DiscardThreshold)
                    discard;
                
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
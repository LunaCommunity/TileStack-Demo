Shader "Unlit/VertexColorOnly"
{
    SubShader
    {
        BindChannels
        {
            Bind "vertex", 
            vertex Bind "color", 
            color
        }

        Pass
        {
            
        }
    }
}

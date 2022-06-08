#version 450

layout(location=0) out vec4 FragColor;

in vec2 v_TexCoord;

uniform sampler2D u_TexSampler;

vec4 Flip()
{
	vec4 returnValue = vec4(0);
	vec2 newTexCoord = v_TexCoord;
	newTexCoord = vec2(v_TexCoord.x, 1.0 - v_TexCoord.y);
	returnValue = texture(u_TexSampler, newTexCoord);
	return returnValue;
}

vec4 P1()
{
	vec4 returnValue = vec4(0);
	vec2 newTexCoord = v_TexCoord;
	newTexCoord.y = abs(2.0 * (v_TexCoord.y - 0.5));
	returnValue = texture(u_TexSampler, newTexCoord);
	return returnValue;
}

vec4 P2()
{
	vec4 returnValue = vec4(0);
	vec2 newTexCoord = v_TexCoord;
	newTexCoord.x = fract(v_TexCoord.x * 3.0);
	newTexCoord.y = newTexCoord.y / 3.0 + floor(v_TexCoord.x * 3.0) / 3.0;
	returnValue = texture(u_TexSampler, newTexCoord);
	return returnValue;
}

vec4 P3()
{
	vec4 returnValue = vec4(0);
	vec2 newTexCoord = v_TexCoord;
	newTexCoord.x = fract(v_TexCoord.x * 3.0);
	newTexCoord.y = floor((1 - v_TexCoord.x) * 3.0) / 3.0 + v_TexCoord.y / 3.0f;
	returnValue = texture(u_TexSampler, newTexCoord);
	return returnValue;
}

vec4 p4()
{
	vec4 returnValue = vec4(0);
	vec2 newTexCoord = v_TexCoord;
	newTexCoord.y = floor((1 - v_TexCoord.y) * 3.0) / 3.0 + fract(v_TexCoord.y * 3.0) / 3.0; 

	returnValue = texture(u_TexSampler, newTexCoord);
	return returnValue;
}

vec4 p5()
{
	vec4 returnValue = vec4(0);
	vec2 newTexCoord = v_TexCoord;
	newTexCoord.x = fract(v_TexCoord.x * 2.0) + floor(v_TexCoord.y * 2.0) * 0.5;
	newTexCoord.y = fract(v_TexCoord.y * 2.0);
	returnValue = texture(u_TexSampler, newTexCoord);
	return returnValue;
}

vec4 p6()
{
	vec4 returnValue = vec4(0);
	vec2 newTexCoord = v_TexCoord;
	newTexCoord.x = fract(v_TexCoord.x * 2.0);
	newTexCoord.y = fract(v_TexCoord.y * 2.0) + floor(v_TexCoord.x * 2.0) * 0.5;
	returnValue = texture(u_TexSampler, newTexCoord);
	return returnValue;
}
 
void main()
{
	FragColor = p6();
}

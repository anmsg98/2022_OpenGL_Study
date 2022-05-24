#version 450

in vec3 a_Position;
in vec4 a_Color;

out vec4 v_Color;
out vec4 v_ColorOverride;

void main()
{
	gl_Position = vec4(a_Position, 1); // -0.5 ~ 0.5, x, y °¢ Ãàº°·Î ÁÂÇ¥
	vec3 newValue = a_Position + vec3(0.5, 0.5, 0); // Texture ÁÂÇ¥
	v_Color = vec4(newValue, 1);
	v_ColorOverride = a_Color;
}

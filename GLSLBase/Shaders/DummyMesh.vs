#version 450

in vec3 a_Position;

const float PI = 3.141592;

out vec4 v_Color;

uniform float u_Time;

void Flag()
{
	vec3 newPos = a_Position;
	float XDis = a_Position.x + 0.5;
	float Dis = distance(a_Position.xy, vec2(-0.5, 0.0));
	float YValue = XDis * 0.5 * cos(Dis * 2.0 * PI - u_Time);
	newPos.y += YValue;
	gl_Position = vec4(newPos, 1);
	v_Color = vec4((sin((a_Position.x + 0.5) * 2.0 * PI - u_Time) + 1.0) / 2.0);
}

void main()
{
	Flag();
}

#version 450

in vec3 a_Position;

uniform float u_Time;

const float PI = 3.141592;

void main()
{
	float newStart = a_Position.x + 1.0f;
	vec4 newPos = vec4(a_Position.x, 0.5 * sin(u_Time + 3 * PI * newStart), a_Position.z, 1); // 0.5는 진폭, 3은 주기
	gl_Position = newPos;
}

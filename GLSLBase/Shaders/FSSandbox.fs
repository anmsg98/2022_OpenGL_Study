#version 450

layout(location=0) out vec4 FragColor;

in vec4 v_Color;

const float PI = 3.141592;

uniform vec3 u_Points[10];
uniform float u_Time;

vec4 CrossPattern()
{
	vec4 returnValue = vec4(1);
	float XAxis = sin(10 * (v_Color.x * 2 * PI) + PI/20.0); // 격자 완성하는거 시험에 낸다
	float YAxis = sin(10 * (v_Color.y * 2 * PI) + PI/20.0);
	float resultColor = max(XAxis, YAxis);
	returnValue = vec4(resultColor);
	return returnValue;
}

vec4 DrawMultipleCircles()
{
	float dis = distance(v_Color.xy, vec2(0.5, 0.5));  // 0~0.5
	float temp = sin(10 * dis * 4 * PI);
	return vec4(temp);
}

vec4 DrawCircles() // 서서히 사라지게 하는 기능 이나 시간이 갈수록 좁혀지는 기능 시험에 나옴
{
	vec4 returnColor = vec4(0);
	float Limit = 0.5;
	for (int i = 0; i < 10; i++)
	{
		float dis = distance(u_Points[i].xy, v_Color.xy);
		float temp = sin(10 * dis * 4 * PI - u_Time * 100);
		if (dis < u_Time)
		{
			returnColor += vec4(temp); 
		}
	}
	return returnColor;
}

vec4 DrawCircle()
{
	float dis = distance(v_Color.xy, vec2(0.5, 0.5));

	// 내부가 채워진 원
	/*if (dis < 0.5)
		FragColor = vec4(1);
	else 
		FragColor = vec4(0);*/

	// 내부가 빈 원
	if (dis > 0.49 && dis < 0.5)
		FragColor = vec4(1);
	else
		FragColor = vec4(0);

	return FragColor;
}

void main()
{
	FragColor = DrawCircles();
}

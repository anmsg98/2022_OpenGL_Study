#version 450

in vec3 a_Position;
in vec3 a_Velocity;
in float a_EmitTime;
in float a_LifeTime;
in float a_Amp;
in float a_Period;

uniform float u_Time;
uniform vec3 u_Accel;

float g_PI = 3.14;

void main()
{
	vec3 newPos;
	float t = u_Time - a_EmitTime;
	float tt = t*t;
	
	if(t > 0)
	{
		float temp = t / a_LifeTime;
		float fractional = fract(temp);
		t = fractional * a_LifeTime;
		tt = t * t;

		float amp = a_Amp; // ÁÖ±â
		float period = a_Period; // ÁøÆø
		newPos.x = a_Position.x + a_Velocity.x * t + 0.5 * u_Accel.x * tt;
		newPos.y = a_Position.y + amp * sin(period * t * 2.0 * g_PI);
		newPos.z = 0;
	}

	else
	{
		newPos = vec3(-100000 ,-100000, -100000);
	}

	
	gl_Position = vec4(newPos, 1);
}

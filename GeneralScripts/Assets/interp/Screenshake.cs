using UnityEngine;
using System.Collections;

public class Screenshake : MonoBehaviour 
{

	
	//to be interpolated
	public float X;
	//starting point A
	public float to = 0;
	//end point B
	public float from = 1;
	//amount of steps N
	public float steps = 10;
	
	
	
	
	void Update () 
	{
		
		if (Input.GetKeyDown("f")) 
		{
			StartCoroutine(herp(0,1));
		}
		if (Input.GetKeyDown("g")) 
		{
			StartCoroutine(lerp());
		}
		
	}
	//linear interpolation 
	IEnumerator lerp()
	{
		
		for (int i = 0; i <= steps; i++)
		{
			float v = i/steps;
			Debug.Log(v);
			X = (to * v) + (from * (1 - v));
			yield return new WaitForSeconds(0);
		}
		
	}
	
	IEnumerator herp(int Q, int T)
	{
		for (int i = 0; i <= steps; i++)
			{
				float vv = i / steps;
				vv = catmullrom(vv, Q, 0, 1, T);
				X = (to * vv) + (from * (1 - vv));
				Debug.Log(X);
				yield return new WaitForSeconds(0);
			} 
	}
	public float catmullrom(float t, float p0, float p1, float p2, float p3)
	{
		return 0.5f * ((2 * p1) + 
		(-p0 + p2) * t + 
		(2 * p0 - 5 * p1 + 4 * p2 - p3) * t * t + 
		(-p0 + 3 * p1 - 3 * p2 + p3) * t * t * t);
	}
}

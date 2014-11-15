using UnityEngine;
using System.Collections;

public class Floating : MonoBehaviour 
{
	public GameObject vTarget;
	public float value = 0F;
	public float Test = 0F;
	public float vTime = 0F;
	void Awake()
	{
		if(vTarget == null)
		{
			vTarget = gameObject;
		}
	}
	void FixedUpdate () 
	{vTime = Time.time;
		value = Mathfx.Sine(0.1F, 0.3F, vTime);
		value *= 0.1F;
		vTarget.transform.position = new Vector3(vTarget.transform.position.x,vTarget.transform.position.y + value,vTarget.transform.position.z);

	}
}

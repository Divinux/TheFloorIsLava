using UnityEngine;
using System.Collections;

public class Headbobbing : MonoBehaviour 
{
	public GameObject cam;
	public float speed = 1;

	void Awake () 
	{
		cam = GameObject.FindWithTag("MainCamera");
	}
	
	void Update () 
	{
		if(cam.transform.position.y < transform.position.y)
		{
			cam.transform.position = transform.position;
		}
		float a =  Mathf.Lerp(cam.transform.position.y, transform.position.y, speed);
		cam.transform.position = new Vector3(transform.position.x,a,transform.position.z);
		cam.transform.rotation = transform.rotation;

		
	}
}

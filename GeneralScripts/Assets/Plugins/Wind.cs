using UnityEngine;
using System.Collections;

public class Wind : MonoBehaviour 
{
private RigidbodyController rc;

void Awake()
{
	rc = gameObject.GetComponent<RigidbodyController>();
}
	void Update () 
	{
	if(rc.onGround && !audio.mute)
	{
		 audio.mute = true;
	}
	else if(!rc.onGround && audio.mute)
	{
	audio.mute = false;
	}
	audio.volume =  rigidbody.velocity.magnitude * 0.05F;
	}
}

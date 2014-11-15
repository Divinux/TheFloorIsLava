using UnityEngine;
using System.Collections;

public class ThrusterEnabler : MonoBehaviour 
{

	public bool left = true;

	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			if(left)
			{
				tutorial.EnableLeft();
			}
			else
			{
				tutorial.EnableRight();
			}
		}
		
	}
}


using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour 
{
public GameObject ThrusterGO;
public static Thruster thruster;

	void Awake () 
	{
		thruster = ThrusterGO.GetComponent<Thruster>();
		thruster.vEnabledLeft = false;
		thruster.vEnabledRight = false;
	}
	
	public static void EnableLeft()
	{
		thruster.vEnabledLeft = true;
	}
	public static void EnableRight()
	{
		thruster.vEnabledRight = true;
	}
}

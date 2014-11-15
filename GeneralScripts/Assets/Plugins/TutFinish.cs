using UnityEngine;
using System.Collections;

public class TutFinish : MonoBehaviour 
{
public float vFinalTime = 0F;
	public float vTime = 0F;
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
		vFinalTime = vTime;
		if(PlayerPrefs.GetFloat("lvl0") > vFinalTime){
			PlayerPrefs.SetFloat("lvl" + "0", vFinalTime);
			}
			Application.LoadLevel(0);
			
		}
	}
	void Update () 
	{
		vTime = Time.time;
	}
}

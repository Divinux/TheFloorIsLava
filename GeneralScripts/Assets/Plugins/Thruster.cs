//thruster item
using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour 
{
	//strength of the thrusters
	public float strength = 10;
	//cooldown for both thrusters
	public float vMaxCool = 300;
	//player and camera objects
	private GameObject player;
	private GameObject cam;
	//update -> fixed update bools
	private bool vFired = false;
	private bool vFired2 = false;
	//current cooldowns
	public float vCool1 = 0F;
	public float vCool2 = 0F;
	//audioclips
	public AudioClip thr1;
	public AudioClip thr2;
	//gui texture
	public Texture2D UIframew;
	public Texture2D green;
	public Texture2D greendark;
	private float max = 58F;
	public bool vEnabledLeft = true;
	public bool vEnabledRight = true;
	//cursorlocker
	private cursorlocker locker;
	void OnGUI()
	{
		if(vEnabledLeft)
		{
		//left bg
		 GUI.Label(new Rect(10,Screen.height - 40,100,15),UIframew);
		
		 //left cd
		 float a = vCool1/vMaxCool;
		 a *= max;
		 a = max-a;
		 if(a == max)
		 {
		 GUI.DrawTexture(new Rect(11,Screen.height - 36,a,7),green);
		 }
		 else
		 {
		 GUI.DrawTexture(new Rect(11,Screen.height - 36,a,7),greendark);
		 }
		 }
		 if(vEnabledRight)
		 {
		  //right bg
		 GUI.Label(new Rect(Screen.width - 110,Screen.height - 40,100,15),UIframew);
		 //right cd
		  float b = vCool2/vMaxCool;
		 b *= max;
		 b = max-b;
		  if(b == max)
		 {
		 GUI.DrawTexture(new Rect(Screen.width - 109,Screen.height - 36,b,7),green);
			}
			else
		 {
		 GUI.DrawTexture(new Rect(Screen.width - 109,Screen.height - 36,b,7),greendark);
		 }
		 }
	}
	void Awake () 
	{
		player = GameObject.FindWithTag("Player");
		cam = GameObject.FindWithTag("MainCamera");
		locker = cam.GetComponent<cursorlocker>();
	}
	
	void Update () 
	{
	if(locker.wasLocked == true){
		if (Input.GetMouseButtonDown(0) && vEnabledLeft)
		{
			vFired = true;
		}
		if (Input.GetMouseButtonDown(1) && vEnabledRight)
		{
			vFired2 = true;
		}
		}
		
	}
	
	void FixedUpdate()
	{
		if(vCool1 >= 1)
		{
			vCool1--;
		}
		else
		{
		vCool1 = 0;
		}
		if(vCool2 >= 1)
		{
			vCool2--;
		}
		else
		{
			vCool2 = 0;
		}
		if(vFired)
		{
			if(vCool1 == 0)
			{
				player.rigidbody.AddForce(cam.transform.forward * strength, ForceMode.Impulse);	
				vCool1 = vMaxCool;
				vFired = false;
				 audio.clip = thr2;
					audio.Play();
			}
			else
			{
				vFired = false;
			}
		}
		else if(vFired2)
		{
			if( vCool2 == 0)
			{
				player.rigidbody.AddForce(-cam.transform.forward * strength, ForceMode.Impulse);	
				vCool2 = vMaxCool;
				vFired2 = false;
				 audio.clip = thr1;
    audio.Play();
			}
			else
			{
				vFired2 = false;
			}
		}
	}
}

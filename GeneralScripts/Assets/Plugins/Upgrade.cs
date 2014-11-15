using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour 
{
	public bool str = false;
	public bool cool = false;
	
	public float vAmount = 0.1F;
	
	public GameObject soundthing;
	
	public GameObject thr;
	public Thruster ts;
	private TextFader fadr;
	void Awake () 
	{
		thr = GameObject.FindWithTag("Thruster");
		ts = thr.GetComponent<Thruster>();
		GameObject fg = GameObject.FindWithTag("MainCamera");
		fadr = fg.GetComponent<TextFader>();
	}
	
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			if(str)
			{
				ts.strength *= 1F+vAmount;
				if(ts.strength > 100)
				{
				ts.strength = 100;
				}
				fadr.fFade("Strength increased: " + ts.strength);
			}
			else
			{
				
				ts.vMaxCool *= 1F - vAmount;
				if(ts.vMaxCool < 1)
				{
					ts.vMaxCool = 1;
				}
				fadr.fFade("Cooldown decreased: " + ts.vMaxCool);
			}
			Instantiate(soundthing, transform.position, transform.rotation);
			Score s = transform.parent.gameObject.GetComponent<Score>();
			s.vItemsLeft--;
			s.check();
			Destroy(gameObject);
		}
	
	}
}

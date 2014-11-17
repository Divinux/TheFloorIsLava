using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour 
{
public bool vEnabled = false;
public GameObject child;
private CheckpointManager mangr;
private TextFader fadr;
private Thruster thrst;

public Color vDarkred = new Color(0.7F, 0.1F, 0.1F, 1F);
public Color vRed = new Color(1F, 0F, 0F, 1F);
public Color vDarkgreen = new Color(0F, 0.7F, 0F, 1F);
public Color vGreen = new Color(0F, 1F, 0F, 1F);
	
	void Awake()
	{
		mangr = transform.parent.gameObject.GetComponent<CheckpointManager>();
		GameObject fg = GameObject.FindWithTag("MainCamera");
		fadr = fg.GetComponent<TextFader>();
		GameObject thrOb = GameObject.FindWithTag("Thruster");
		thrst = thrOb.GetComponent<Thruster>();
	}
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			if(vEnabled == false)
			{
			mangr.disable();
			mangr.current = this;
			vEnabled = true;
			child.renderer.material.color = vGreen;
			child.light.color = vGreen;
			
			fadr.fFade("Checkpoint reached!");
			}
			
			audio.Play();
			
			thrst.vCool2 = 0;
			thrst.vCool1 = 0;
		}
	}
	public void vDisable()
	{
		vEnabled = false;
		child.renderer.material.color = vRed;
		child.light.color = vRed;
	}
}

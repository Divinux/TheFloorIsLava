using UnityEngine;
using System.Collections;

public class lavatrigger : MonoBehaviour 
{
public GameObject cpm;
public CheckpointManager mgr;
public GameObject pl;
public RigidbodyController pls;
public TrailRenderer tl;

	void Awake () 
	{
	cpm = GameObject.FindWithTag("cpm");
	mgr = cpm.GetComponent<CheckpointManager>();
	pl = GameObject.FindWithTag("Player");
	pls = pl.GetComponent<RigidbodyController>();
	tl = pls.Trail.GetComponent<TrailRenderer>();
	}
	
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
		if(pls.Trail != null)
		{
		pls.Trail.transform.parent = null;
		tl = pls.Trail.GetComponent<TrailRenderer>();
		}
		

		if(tl != null){
		tl.autodestruct = true;
		}
		
		
			mgr.reset();
			
		}
	
	}
}

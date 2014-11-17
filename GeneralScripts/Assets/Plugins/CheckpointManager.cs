using UnityEngine;
using System.Collections;

public class CheckpointManager : MonoBehaviour 
{
	public Checkpoint[] points;
	public Checkpoint current;
	
	
	private GameObject player;
	private RigidbodyController pls;
	public TrailRenderer tl;
	void Awake()
	{
		player = GameObject.FindWithTag("Player");
		pls = player.GetComponent<RigidbodyController>();
		tl = pls.Trail.GetComponent<TrailRenderer>();
	}
	
	public void disable () 
	{
		foreach(Checkpoint a in points)
		{
			a.vDisable();
		}
	}
	
	void Update()
	{
		if(Input.GetKeyDown("r") )
		{
			tl = pls.Trail.GetComponent<TrailRenderer>();
			if(tl != null){
			tl.transform.parent = null;
		tl.autodestruct = true;
		}
			reset();
		}
	}
	
	public void reset()
	{
		if(current != null)
		{
			
			player.transform.position = new Vector3(current.transform.position.x,current.transform.position.y+1,current.transform.position.z);
			player.transform.rotation = current.transform.rotation;
			pls.Trail = Instantiate(pls.TrailPref, pls.TrailHolder.transform.position, pls.TrailHolder.transform.rotation) as GameObject;
			pls.Trail.transform.parent = pls.TrailHolder.transform;
		}
	}
	public void resetKey()
	{
	if(current != null)
		{
			player.transform.position = new Vector3(current.transform.position.x,current.transform.position.y+1,current.transform.position.z);
		}
	}
}

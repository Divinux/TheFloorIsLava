using UnityEngine;
using System.Collections;

public class die : MonoBehaviour 
{

	void Awake () 
	{
	InvokeRepeating("asd", 1F, 1F);
	}
	
	void asd () 
	{
	Destroy(gameObject);
	}
}

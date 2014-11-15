using UnityEngine;
using System.Collections;

public class Thump : MonoBehaviour 
{
public GameObject holder;

	void OnCollisionEnter ()
{
	holder.audio.Play();
}
}

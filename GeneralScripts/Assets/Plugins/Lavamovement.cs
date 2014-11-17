using UnityEngine;
using System.Collections;

public class Lavamovement : MonoBehaviour 
{
public float speed = 0F;
public float vel = 0.001F;
public bool direction = false;
	void Awake () 
	{
	
	}
	
	void FixedUpdate () 
	{
		renderer.material.SetTextureOffset("_MainTex", new Vector2(speed,speed));
		renderer.material.SetTextureOffset("_Illum", new Vector2(speed,speed));
		if(direction){
		renderer.material.SetTextureOffset("_BumpMap", new Vector2(-speed * 0.5f,speed*0.5f));
		}
		else{
		renderer.material.SetTextureOffset("_BumpMap", new Vector2(speed,speed));
		}
		
		speed += vel;
		if(speed == 10F)
		{
		speed = 0F;
		}
	}
}

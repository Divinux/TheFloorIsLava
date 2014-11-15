using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	private Color dg= new Color(0F,0.3F,0F,1F);
	public Texture2D button;
	public GUISkin s1;
	
	private int vMenuCount = 0;
	
	void Awake()
	{
		Screen.lockCursor = false;
	}
	void OnGUI()
	{
		GUI.skin = s1;
		//GUI.Box(new Rect(0, 0, Screen.width, Screen.height), " ");
		if(vMenuCount == 0)
		{
			/////
			GUI.Label(new Rect(Screen.width/2 - 50, 100, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 - 45, 105, 100, 30), "Start", "label"))
			{
				vMenuCount = 1;
			}
			GUI.contentColor = Color.white;
/////
			GUI.Label(new Rect(Screen.width/2 - 50, 140, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 - 45, 145, 100, 30), "Quit", "label"))
			{
				Application.Quit();
				Debug.Log("Quitting");
			}
			GUI.contentColor = Color.white;			
		} 
		else if(vMenuCount == 1)
		{
			/////Back button
			GUI.contentColor = Color.white;
			GUI.Label(new Rect(Screen.width/2 - 50, 100, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 - 45, 105, 100, 30), "Back", "label"))
			{
				vMenuCount = 0;
			}
			GUI.contentColor = Color.white;
			/////best time button
			GUI.Label(new Rect(Screen.width/2 + 50, 100, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 + 55, 105, 100, 30), "Best Time", "label"))
			{
				//
			}
			GUI.contentColor = Color.white;
			/////tutorial score
			GUI.Label(new Rect(Screen.width/2 + 50, 140, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 + 55, 145, 100, 30), PlayerPrefs.GetFloat("lvl0") + "s", "label"))
			{
				//
			}
			/////lvl1 score
			GUI.contentColor = Color.white;
			GUI.Label(new Rect(Screen.width/2 + 50, 180, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 + 55, 185, 100, 30), PlayerPrefs.GetFloat("lvl1") + "s", "label"))
			{
				//
			}
			/////////////tut buttn
			GUI.contentColor = Color.white;
			GUI.Label(new Rect(Screen.width/2 - 50, 140, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 - 45, 145, 100, 30), "Tutorial", "label"))
			{
				Application.LoadLevel(1);
			}
			GUI.contentColor = Color.white;
			/////1 buttn
			GUI.Label(new Rect(Screen.width/2 - 50, 180, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 - 45, 185, 100, 30), "Level 1", "label"))
			{
				Application.LoadLevel(2);
			}
			GUI.contentColor = Color.white;
		}
	}
}

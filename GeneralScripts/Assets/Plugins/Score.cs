using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	public int vItemsLeft = 1;
	public int vLvl = 0;
	public float vFinalTime = 0F;
	public float vTime = 0F;

	public int vDone = 0;
	private Color dg= new Color(0F,0.3F,0F,1F);
	public Texture2D button;
	public GUISkin s1;
	
	public MouseLook m1;
	public MouseLook m2;
	
	public bool vShowing = false;
	
	private GameObject cam;
	private TextFader fader;
	
	void Awake()
	{
	cam = GameObject.FindWithTag("MainCamera");
	fader = cam.GetComponent<TextFader>();
	
	/*///*
	PlayerPrefs.SetFloat("lvl0", 0);
	PlayerPrefs.SetFloat("lvl1", 0);
	PlayerPrefs.SetFloat("lvl2", 0);
	PlayerPrefs.SetFloat("lvl3", 0);*/
	}

	void Update () 
	{
		vTime = Time.time;
		if (Input.GetKeyDown("escape")&&vShowing)
		{
			vDone = 0;
			m1.enabled = true;
			m2.enabled = true;
			Screen.lockCursor = true;
			vShowing = false;
		}
	}
	
	void OnGUI()
	{
		if(vDone == 1)
		{
		GUI.skin = s1;
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), " ");
			GUI.Label(new Rect(Screen.width/2 - 50, 100, 300, 30), "Congratulations!");
			GUI.Label(new Rect(Screen.width/2 - 50, 140, 300, 30), "You finished in " + vFinalTime + "s!");
			/////
			GUI.Label(new Rect(Screen.width/2 - 50, 180, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 - 45, 185, 100, 30), "Main Menu", "label"))
			{
				Application.LoadLevel(0);
			}
			
			GUI.contentColor = Color.white;
			/////
			GUI.Label(new Rect(Screen.width/2 - 50, 210, 100, 30), button);
			GUI.contentColor = dg;
			
			if (GUI.Button(new Rect(Screen.width/2 - 45, 215, 100, 30), "Keep Playing", "label"))
			{
				vDone = 0;
				m1.enabled = !m1.enabled;
			m2.enabled = !m2.enabled;
			Screen.lockCursor = true;
			vShowing = false;
			}
			
			GUI.contentColor = Color.white;
		}
	}
	
	public void check()
	{
		if(vItemsLeft == 0)
		{
			Debug.Log("GameWon");
			vDone = 1;
			vFinalTime = vTime;
			Debug.Log("lvl" + vLvl);
			if(PlayerPrefs.GetFloat("lvl" + vLvl) > vFinalTime || PlayerPrefs.GetFloat("lvl" + vLvl) == 0){
			PlayerPrefs.SetFloat("lvl" + vLvl, vFinalTime);
			}
			m1.enabled = !m1.enabled;
			m2.enabled = !m2.enabled;
			Screen.lockCursor = false;
			vShowing = true;
		}
		else
		{
			fader.fFade("Items left: " + vItemsLeft);
		}
	}
}

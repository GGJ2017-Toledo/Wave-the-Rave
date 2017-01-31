using UnityEngine;

public class Statics : MonoBehaviour 
{
	public static Transform lightAimPos;
	public static Transform soundAimPos;

	void Awake()
	{
		lightAimPos = GameObject.FindGameObjectWithTag("LightAim").GetComponent<Transform>();
		soundAimPos = GameObject.FindGameObjectWithTag("SoundAim").GetComponent<Transform>();
	}
}
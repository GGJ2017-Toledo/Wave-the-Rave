using UnityEngine;

public class restButton : MonoBehaviour 
{
	public void RestGame()
	{
		//gameObject.SetActive(false);
		Application.LoadLevel(3);
	}
}
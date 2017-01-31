using System.Collections.Generic;
using UnityEngine;

public class PolishText : MonoBehaviour 
{
	public int qty = 50;
	public GameObject text;

	List<GameObject> list;

	void Start()
	{
		list = new List<GameObject>();

		for(int i = 0; i < qty; i++)
		{
			GameObject tmpText = (GameObject)Instantiate(text);
			list.Add(tmpText);
			tmpText.transform.parent = transform;
			tmpText.SetActive(false);
		}
	}

	public GameObject SearchText()
	{
		foreach(GameObject gm in list)
			if(!gm.activeSelf)
				return gm;

		GameObject tmpText = (GameObject)Instantiate(text);
		list.Add(tmpText);
		return tmpText;
	}
}
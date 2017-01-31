using UnityEngine;

public class ChangeControll : MonoBehaviour 
{
	Aim_Mouse aimMouse;
	Aim_Controller aimController;

	void Awake()
	{
		aimMouse = GetComponent<Aim_Mouse>();
		aimController = GetComponent<Aim_Controller>();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			aimMouse.enabled = false;
			aimController.enabled = true;
		}

		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			aimMouse.enabled = true;
			aimController.enabled = false;
		}
	}
}
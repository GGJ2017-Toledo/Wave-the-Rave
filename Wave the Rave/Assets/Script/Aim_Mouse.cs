using UnityEngine;

public class Aim_Mouse : MonoBehaviour {

	Vector3 temp;
	Vector3 temp2;

	void Update () 
	{
		temp = new Vector3(Input.mousePosition.x,
						   Input.mousePosition.y,
						   0f);

		temp2 = Camera.main.ScreenToWorldPoint (temp);
		temp2.z = -5f;

		transform.position = temp2;
	}
}

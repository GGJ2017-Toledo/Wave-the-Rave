using UnityEngine;

public class Aim_Controller : MonoBehaviour 
{
	public float speed = 0f;

	string horizontalAxis,
		   verticalAxis;

	Vector3 pos;

	void Start()
	{
		horizontalAxis = gameObject.name + "HorizontalStick";
		verticalAxis   = gameObject.name + "VerticalStick";
	}

	void Update()
	{
		pos = new Vector3(Input.GetAxis(horizontalAxis) * speed * Time.deltaTime,
						  -Input.GetAxis(verticalAxis) * speed * Time.deltaTime,
						  0f);

		transform.Translate(pos);
	}
}
using UnityEngine;

public class Aim_Clamp : MonoBehaviour 
{
	public Transform rightClamp,
	      		     leftClamp,
	                 upperClamp,
	                 lowerClamp;

	Vector3 clamp;

	void Update()
	{
		clamp = transform.position;

		clamp = new Vector3(Mathf.Clamp(transform.position.x, leftClamp.position.x, rightClamp.position.x),
							Mathf.Clamp(transform.position.y, lowerClamp.position.y, upperClamp.position.y),
                            -2f);

		transform.position = clamp;
	}
}
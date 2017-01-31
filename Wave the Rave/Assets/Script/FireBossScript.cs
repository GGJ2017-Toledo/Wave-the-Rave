using UnityEngine;

public class FireBossScript : MonoBehaviour 
{
	public GameObject target;
	public float speed;

	Vector3 pos;
	void Update()
	{
		pos = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
		transform.position = pos;
	}
}
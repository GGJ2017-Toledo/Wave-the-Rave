using UnityEngine;

public class textLifetime : MonoBehaviour 
{
	public float lifetime;
	public float speed;

	float timer = 0f;

	void OnEnable()
	{
		timer = 0f;
	}

	void OnDisable()
	{
		transform.position = transform.parent.position;
	}

	void Update()
	{
		timer += Time.deltaTime;

		transform.Translate( Vector3.up * speed * Time.deltaTime);

		if(timer > lifetime)
			gameObject.SetActive(false);
	}
}
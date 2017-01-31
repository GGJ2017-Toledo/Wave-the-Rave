using UnityEngine;

public class SoundBullet : MonoBehaviour 
{
	public float speed;

	float lifetime = 3f;
	float time = 0f;

	void Update()
	{
		transform.Translate( Vector3.up * speed * Time.deltaTime );

		time += Time.deltaTime;

		if(time > lifetime)
			Destroy(gameObject);
	}
}
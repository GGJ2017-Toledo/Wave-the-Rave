using UnityEngine;

public class LightBullet : MonoBehaviour 
{
	public float speed;
	public float fadeSpeed;
	public float lightRadius;
	public float fadeLimit;
	public Texture[] cookies;
	public float timeChangeCookie;

	Vector3 target;
	float time = 0f;
	int i = 0;
	float shootTime;
	bool isShooting = true;
	Light light;

	void Start()
	{
 		target = Statics.lightAimPos.position;
		light = GetComponentInChildren<Light>();
	}

	void FixedUpdate()
	{
		if(isShooting)
		{
			float distance = Vector3.Distance(transform.position, target);

			if( distance >= 2f )
				transform.Translate( Vector3.up * speed * Time.deltaTime );
			else
			{
				GetComponent<SpriteRenderer>().enabled = false;
				GetComponent<CircleCollider2D>().enabled = true;
				light.cookie = cookies[i];
				light.enabled= true;
				light.intensity = 15f;
				light.spotAngle = lightRadius * 10f;
				isShooting = false;
			}
		}else
		{
			light.intensity -= fadeSpeed;

			time += Time.deltaTime;

			if(time > timeChangeCookie)
			{
				light.cookie = cookies[i];
				i++;

				if(i >= cookies.Length)
					i = 0;

				time = 0;
			}

			if(light.intensity < fadeLimit)
				Destroy(gameObject);
		}
	}
}
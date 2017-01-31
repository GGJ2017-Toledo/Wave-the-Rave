using UnityEngine;

public class soundRing : MonoBehaviour 
{
	public float growRate;
	public float growSpeed;

	float time = 0f;
	bool isGrowning = false;

	void Update()
	{
		if(time > 0.2f)
		{
			Vector3 pos = new Vector3(1f, 1f, 1f);

			if(!isGrowning)
				pos = Grow();
			
			if( Vector3.Distance(transform.localScale, pos) > 0.5f )
			{
				if( pos.x > 0 )
					transform.localScale = Vector3.Lerp(transform.localScale, pos, growSpeed * Time.deltaTime);
				else
					transform.localScale = Vector3.Lerp(transform.localScale, -pos, growSpeed * Time.deltaTime);
			}

			transform.localScale = new Vector3( transform.localScale.x, 1f, 1f);

			time = 0;
		}else
			time += Time.deltaTime;
	}

	Vector3 Grow()
	{
		float num = Random.Range(-growRate, growRate);
		Vector3 scale = transform.localScale;

		Vector3 grow = new Vector3(scale.x + num, 1f, 1f);			

		return grow;
	}
}
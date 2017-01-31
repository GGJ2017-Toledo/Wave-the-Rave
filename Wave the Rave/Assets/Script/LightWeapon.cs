using UnityEngine;

public class LightWeapon : MonoBehaviour 
{
	public GameObject lightBullet;
	public Transform cannonPos;
	public float cooldownTime = 0f;

	AudioSource audioSource;
	Animator animator;
	float time;

	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		if( Input.GetButtonDown("LeftFire") && time > cooldownTime )
		{
			GameObject tmp = (GameObject)Instantiate(lightBullet, cannonPos.transform.position, cannonPos.rotation);
			audioSource.Play();
			animator.SetBool("isCharging", true);
			time = 0;
		}

		if( time <= cooldownTime )
			time += Time.deltaTime;

		if( time >= cooldownTime )
			animator.SetBool("isCharging", false);
	}
}
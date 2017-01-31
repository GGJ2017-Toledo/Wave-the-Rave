using UnityEngine;

public class Turret_Controller : MonoBehaviour 
{
	public Transform target; //Add target in inspector
 
    void Update ()
    {
            float angle = 0;
         
            Vector3 relative = transform.InverseTransformPoint(target.position);
            angle = Mathf.Atan2(relative.x, relative.y)*Mathf.Rad2Deg;
            transform.Rotate(0,0, -angle);
    }
}
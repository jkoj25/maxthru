using UnityEngine;
using System.Collections;

public class south_to_west : MonoBehaviour {
	
	private Rigidbody2D rb2d;
	private int counter=0;
	private float speed = 25.0f;
	public float constantx;
	public float variabley;
	public float rand1,rand2,rand3;
	
	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();	
		//start x = -0.5, y = -3.2
		//rotation z = 90
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float speed = 0.05f;
		if (transform.position.y <= 0f)
		{
			transform.right = new Vector3(0,speed,0.0f);
			transform.position = transform.position+new Vector3(0,speed,0.0f);
		}
		else if (transform.position.y <= 0.92f) 
		{
			float x = speed/1.41f;
			transform.right = new Vector3(-x,x,0.0f);
			transform.position = transform.position+new Vector3(-x,x,0.0f);
		}
		else// if (transform.position.x >= -6.6f)
		{
			transform.right = new Vector3(-speed,0.0f,0.0f);
			transform.position = transform.position+new Vector3(-speed,0.0f,0.0f);
		}
		/*else
		{
			float donothing = 0;
		}*/
	}
}

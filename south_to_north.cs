using UnityEngine;
using System.Collections;

public class south_to_north : MonoBehaviour {
	
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
		//start x = 0.2, y = -3.2
		//rotation z = 90
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float speed = 0.05f;
		if (transform.position.y <= 3.2f)
		{
			transform.right = new Vector3(0f,speed,0.0f);
			transform.position = transform.position+new Vector3(0f,speed,0.0f);
		}
		else
		{
			float donothing = 0;
		}
	}
}

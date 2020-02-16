using UnityEngine;
using System.Collections;

public class west_to_east : MonoBehaviour {
	
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
		//start x = -6.6, y = -0.77
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float speed = 0.05f;
		if (transform.position.x <= 6.6f)
		{
			transform.right = new Vector3(speed,0f,0.0f);
			transform.position = transform.position+new Vector3(speed,0f,0.0f);
		}
		else
		{
			float donothing = 0;
		}
	}
}

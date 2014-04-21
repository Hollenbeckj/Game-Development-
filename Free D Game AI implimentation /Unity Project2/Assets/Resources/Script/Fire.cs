using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public Rigidbody lazerBlast;
	
	public float force = 20;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown("space"))
		{
			print("up arrow key is held down");
				object blast = Instantiate(lazerBlast,transform.position,transform.rotation) as Rigidbody;
					//rigidbody.AddForce(0,0,200);
						//blast = transform.TransformDirection(Vector3.forward * force);
							 //transform.Translate(0, 0, Time.deltaTime);
								//blast = transform.TransformDirection(new Vector3(0,0,force));
		}

				
		

		
	}
}

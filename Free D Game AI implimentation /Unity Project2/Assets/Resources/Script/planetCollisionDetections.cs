using UnityEngine;
using System.Collections;

public class planetCollisionDetections : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Planet")
		{
			Destroy(col.gameObject);
			print("planetcollide");
			
		}
}
}

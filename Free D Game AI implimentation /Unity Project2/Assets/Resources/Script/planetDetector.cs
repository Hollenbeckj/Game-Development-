using UnityEngine;
using System.Collections;

public class planetDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider coll) {
		if(coll.gameObject.name == "planetA" || coll.gameObject.name == "planetB" || coll.gameObject.name == "planetC" || coll.gameObject.name == "planetD")
		{
			//object.position.y + 5;
			print("Moving");
		}
	}
}

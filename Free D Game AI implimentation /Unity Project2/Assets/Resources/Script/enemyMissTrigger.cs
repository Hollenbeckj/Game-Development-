using UnityEngine;
using System.Collections;
//public GameObject health;

public class enemyMissTrigger : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//health = UIHealthBar.GetComponent(mCurrentHealth);
	}
	
	void OnTriggerEnter(Collider col) {
		if(col.gameObject.name == "deathStar(Clone)")
		{
			Destroy(col.gameObject);
			print("theDeathStarMissed");
			
		}
	}
}

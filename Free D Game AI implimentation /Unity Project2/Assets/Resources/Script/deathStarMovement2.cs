using UnityEngine;

using System.Collections;



public class deathStarMovement2 : MonoBehaviour 
	
{
	
	public string searchTag;
	
	private GameObject closetMissle;
	
	private Transform target;
	
	
	
	void Start()
		
	{
		
		closetMissle = FindClosestEnemy();
		
		
		
		if(closetMissle)
			
			target = closetMissle.transform;
		
	}   
	
	
	
	void Update()
		
	{   
		
		transform.LookAt(target);
		//constraint.target = target;
		
		transform.Translate(Vector3.forward * 200.0f * Time.deltaTime);
		
	}
	
	
	
	GameObject FindClosestEnemy()
		
	{
		
		GameObject[] gos;
		
		gos = GameObject.FindGameObjectsWithTag(searchTag);
		
		
		
		GameObject closest = null;
		
		float distance = Mathf.Infinity;
		
		
		
		Vector3 position = transform.position;

		
		
		foreach(GameObject go in gos)
			
		{
			
			Vector3 diff = go.transform.position - position;
			
			float curDistance = diff.sqrMagnitude;
			
			
			
			if(curDistance < distance)
				
			{
				
				closest = go;
				
				distance = curDistance;
				
			}
			
		}
		
		
		
		return closest;
		
	}
	
	
	
}
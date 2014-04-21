using UnityEngine;
using System.Collections;


public class numberGenerator : MonoBehaviour
{
	public int randNum;
	public int timer;
	public int spawnPoint1PosX = 0;
	public int spawnPoint1PosY = 0;
	public int spawnPoint1PosZ = 530;
	public int deathStarCloneZPOS = 530;
	public int warningTimer = 100;
	public bool spawnCondition;
	public bool runRandomGen;
	public bool plannetSpawned;
	public bool enemyAhead;
	public Transform[] spawns;
	private GameObject spawnPoint1;
	private GameObject spawnPoint2;
	private GameObject spawnPoint3;
	public GameObject deathStar;
	public Texture2D warning;


	void Start()
	{
		timer = 500;
		spawnCondition = false;
	}

	void Update ()
	{
		timer--;
		//print(timer);

		if(timer == 0)
		{
			generateNum();
		}
	
		
			if(spawnCondition)
			{
			//float xMin = (Screen.width);
			//float yMin = (Screen.height);
			int deathStarCloneZPOS = 830;
			Object deathStarClone = Instantiate(deathStar,transform.position = new Vector3(0,0,deathStarCloneZPOS),transform.rotation);
			//planetSpawned = true;
			//GUI.DrawTexture(new Rect(0,0,xMin,yMin), warning);
			spawnCondition = false;
			if(deathStarClone != null)
			{
				enemyAhead = true;
			}
			//print("deathstar is operational");
			}




}

	 public void OnGui(){
		if(enemyAhead)
		{
			float xMin = (Screen.width);
			float yMin = (Screen.height);
			warningTimer--;
			//warning.enabled = true;
			GUI.DrawTexture(new Rect(0,0,xMin,yMin), warning);
			print("ENEMYINCOMING");
		}

		if(warningTimer == 0)
		{
			enemyAhead = false;
		}
	}


void generateNum ()
{


		int[] array = {5, 6, 7, 8, 9, 10, 20, 21, 22, 23, 24};
		
		int randNum = Random.Range(0, array.Length);


		//print("RANDUM" + randNum);

		if(randNum == 2 || randNum == 8 || randNum == 3 || randNum == 0)
		{
			spawnCondition = true;

		}

		timer = 500;


			
}
}
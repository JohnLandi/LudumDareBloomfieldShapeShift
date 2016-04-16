//randomly creates an object at a random spawn point
using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] Objects;
	public GameObject[] ObjectsTwo;
	public GameObject[] EnemyType;
	public GameObject[] FoodType;


	public void Spawner()
	{
		//We can change the max variable to 100 if you want uneven randoms, like 60% enemy, %20Food, %20empty.
		//By changing max variable to 100, we can then say if(random >= 0 && < 20) food, etc
			//random variable 0 to max array length
		int randomObject = Random.Range (0, Objects.Length);
		int randomObjectTwo = Random.Range (0, Objects.Length);
		int randomSpawnPoint = Random.Range (0, spawnPoints.Length);
		int randomSpawnPointTwo = Random.Range (0, spawnPoints.Length);

		//Food and Enemies will appear specifically by their position of Sky, Earth, or Water
		if(randomSpawnPoint == 0){
			Objects[0] = EnemyType[0];
			Objects[1] = FoodType[0];
		}
		if(randomSpawnPoint == 1){
			Objects[0] = EnemyType[1];
			Objects[1] = FoodType[1];
		}
		if(randomSpawnPoint == 2){
			Objects[0] = EnemyType[2];
			Objects[1] = FoodType[2];
		}
		if(randomSpawnPointTwo == 0){
			ObjectsTwo[0] = EnemyType[0];
			ObjectsTwo[1] = FoodType[0];
		}
		if(randomSpawnPointTwo == 1){
			ObjectsTwo[0] = EnemyType[1];
			ObjectsTwo[1] = FoodType[1];
		}
		if(randomSpawnPointTwo == 2){
			ObjectsTwo[0] = EnemyType[2];
			ObjectsTwo[1] = FoodType[2];
		}

		//creates a random game object from Objects array at the random position located in the spawnPoints array
		Instantiate (Objects[randomObject], spawnPoints[randomSpawnPoint].position, spawnPoints[randomSpawnPoint].rotation);

		//Prevents two objects from spawning in the same spot
		if (randomSpawnPointTwo != randomSpawnPoint)
		{
			//spawns second object
			Instantiate (ObjectsTwo[randomObjectTwo], spawnPoints[randomSpawnPointTwo].position, spawnPoints[randomSpawnPointTwo].rotation);
		}
	}
}

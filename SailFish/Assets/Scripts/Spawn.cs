//randomly creates an object at a random spawn point
using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] Objects;


	public void Spawner()
	{
		//We can change the max variable to 100 if you want uneven randoms, like 60% enemy, %20Food, %20empty.
		//By changing max variable to 100, we can then say if(random >= 0 && < 20) food, etc
			//random variable 0 to max array length
		int randomObject = Random.Range (0, Objects.Length);
		int randomObjectTwo = Random.Range (0, Objects.Length);
		int randomSpawnPoint = Random.Range (0, spawnPoints.Length);
		int randomSpawnPointTwo = Random.Range (0, spawnPoints.Length);



		//creates a random game object from Objects array at the random position located in the spawnPoints array
		Instantiate (Objects[randomObject], spawnPoints[randomSpawnPoint].position, spawnPoints[randomSpawnPoint].rotation);

		//Prevents two objects from spawning in the same spot
		if (randomSpawnPointTwo != randomSpawnPoint)
		{
			//spawns second object
			Instantiate (Objects[randomObjectTwo], spawnPoints[randomSpawnPointTwo].position, spawnPoints[randomSpawnPointTwo].rotation);
		}
	}
}

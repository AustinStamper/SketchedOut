using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour  {

    public Transform enemy1;
	public Transform enemy2;
	public Transform enemy3;
	public Transform enemy4;

    public Transform spawnPoint1;
	public Transform spawnPoint2;
	public Transform spawnPoint3;
	public Transform spawnPoint4;
	public Transform spawnPoint5;
	public Transform spawnPoint6;

	public int totalScore = 0;
	public int totalHealth = 100;

	public static int addedScore;
	public static int addedDamage;

	public Text scoreText;
	public Text healthText;

	private Random rnd = new Random();

    public float timeBetweenWaves = 5f;

    private float countdown = 2f;

	private int waveNumber = 0;
	private int spawnLocation;


	void Update ()
    {
		AddScoreChez ();
		AddScoreCubert ();
		AddDamage ();

		if (countdown <= 0f)
        {
			StartCoroutine(SpawnWave());	
			countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;


    }

	IEnumerator SpawnWave()
	{
		waveNumber++;

		for (int i = 0; i < waveNumber; i++) {
			SpawnEnemy1 ();
			yield return new WaitForSeconds (1f);
		}
		if (waveNumber > 3) {
			
			for (int i = 4; i < waveNumber; i++) {
				SpawnEnemy2();
				yield return new WaitForSeconds (1f);
			}
		}
	}
    void SpawnEnemy1()
	{
		spawnLocation = Random.Range (0, 6);
		switch (spawnLocation) {
		case 0:
			Instantiate (enemy1, spawnPoint1.position, spawnPoint1.rotation);
			break;
		case 1:
			Instantiate (enemy1, spawnPoint2.position, spawnPoint2.rotation);
			break;
		case 2:
			Instantiate (enemy1, spawnPoint3.position, spawnPoint3.rotation);
			break;
		case 3:
			Instantiate (enemy1, spawnPoint4.position, spawnPoint4.rotation);
			break;
		case 4:
			Instantiate (enemy1, spawnPoint5.position, spawnPoint5.rotation);
			break;
		default:
			Instantiate (enemy1, spawnPoint6.position, spawnPoint6.rotation);
			break;
		}
	}
		void SpawnEnemy2()
		{
		{
			spawnLocation = Random.Range (0, 6);
			switch (spawnLocation) {
			case 0:
				Instantiate (enemy2, spawnPoint1.position, spawnPoint1.rotation);
				break;
			case 1:
				Instantiate (enemy2, spawnPoint2.position, spawnPoint2.rotation);
				break;
			case 2:
				Instantiate (enemy2, spawnPoint3.position, spawnPoint3.rotation);
				break;
			case 3:
				Instantiate (enemy2, spawnPoint4.position, spawnPoint4.rotation);
				break;
			case 4:
				Instantiate (enemy2, spawnPoint5.position, spawnPoint5.rotation);
				break;
			default:
				Instantiate (enemy2, spawnPoint6.position, spawnPoint6.rotation);
				break;
			}
		}
		}
	void AddScoreCubert(){
		addedScore = DeathofCubert.newScore;
		totalScore += addedScore;
		scoreText.text = "Score: " + totalScore;
		DeathofCubert.newScore = 0;
	}
	void AddScoreChez(){
		addedScore = DeathofChez.newScore;
		totalScore += addedScore;
		scoreText.text = "Score: " + totalScore;
		DeathofChez.newScore = 0;
	}

	void AddDamage(){
		addedDamage = DeathforPlayer.damage;
		totalHealth -= addedDamage;
		healthText.text = "Health: " + totalHealth;
		DeathforPlayer.damage = 0;
	}

}

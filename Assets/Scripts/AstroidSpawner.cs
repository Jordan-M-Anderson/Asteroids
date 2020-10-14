using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{
    [SerializeField]
    public int numOfAstroids;

    public int currentNumOfAstroids;
    private Vector2 pos;

    [SerializeField]
    public GameObject[] AsteroidPrefabs;

    // Update is called once per frame
    void Update()
    {
        if (currentNumOfAstroids != numOfAstroids && currentNumOfAstroids <= 4) {

            spawnAsteroid();

        }
    }


    private void spawnAsteroid() {

        currentNumOfAstroids++;
        pos = new Vector2(Random.Range(10, 11), Random.Range(-5, 4));
        Instantiate(AsteroidPrefabs[Random.Range(0, AsteroidPrefabs.Length)], pos, Quaternion.identity);

    }
}

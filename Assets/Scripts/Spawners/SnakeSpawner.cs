using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject snakePrefab;
    [SerializeField] private float snakeInterval = 5f;
    [SerializeField] private int maxSnakes = 1;


    private List<GameObject> spawnedTurtles = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(spawnTurtle(snakeInterval, snakePrefab));
    }

    // Timer om Targets te spawnen
    private IEnumerator spawnTurtle(float interval, GameObject turtle)
    {
        while (true) {
            yield return new WaitForSeconds(interval);

            spawnedTurtles.RemoveAll(item => item == null);
            if (spawnedTurtles.Count < maxSnakes) {
                GameObject newTurtle = Instantiate(turtle, new Vector3(Random.Range(-10f, 10f), Random.Range(-6, -1f), 0), Quaternion.identity);
                spawnedTurtles.Add(newTurtle);
            }
        }
    }
}

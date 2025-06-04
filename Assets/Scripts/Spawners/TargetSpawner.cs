using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private GameObject turtlePrefab;
    [SerializeField] private float turtleInterval = 5f;
    [SerializeField] private int maxTurtles = 5;

    public List<GameObject> spawnedTurtles = new List<GameObject>();
    

    private void Start()
    {
        StartCoroutine(spawnTurtle(turtleInterval, turtlePrefab));
    }

    // Timer om Targets te spawnen
    private IEnumerator spawnTurtle(float interval, GameObject turtle)
    {
        while (true) {
            yield return new WaitForSeconds(interval);

            if (Points.instance != null && Points.instance.LevelDone) { 
            yield break;
            }

            spawnedTurtles.RemoveAll(item => item == null);
            if (spawnedTurtles.Count < maxTurtles)
            {
                GameObject newTurtle = Instantiate(turtle, new Vector3(Random.Range(-9f, 9f), Random.Range(-5, -1f), 0), Quaternion.identity);
                spawnedTurtles.Add(newTurtle); 
            }            
        }
    }
}

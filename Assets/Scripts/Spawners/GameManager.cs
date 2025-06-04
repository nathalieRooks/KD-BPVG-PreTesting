using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject mjolnir;
    public GameObject[] spawnPoints;
    public float timer;
    public float timerB;
    public float timeBetween;
    public float timeBetweenMjolnir;

    private void Update()
    {
        timer += Time.deltaTime;
        timerB += Time.deltaTime;

        if(timer > timeBetween)
        {
            timer = 0;
            int randNum = Random.Range(0, 3);
            int randNumMjol = Random.Range(0, 3);
            Instantiate(spawnObject , spawnPoints[randNum].transform.position, Quaternion.identity);
        }

        if (timerB > timeBetweenMjolnir)
        {
            timerB = 0;
            int randNumMjol = Random.Range(0, 3);
            Instantiate(mjolnir, spawnPoints[randNumMjol].transform.position, Quaternion.identity);
        }
    }
}

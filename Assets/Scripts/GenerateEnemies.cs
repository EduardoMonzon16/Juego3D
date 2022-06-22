using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject Enemy;
    public float xPos;
    public float zPos;
    public int enemyCount;
    public int startwait;
    public bool stop;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 5 | !stop)
        {       
            xPos = Random.Range(-4.3f, 7.172f);
            zPos = Random.Range(5.677f, 8.709f);
            Instantiate(Enemy, new Vector3(xPos, 0.617f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(startwait);
            enemyCount += 5;
        }
    }
}

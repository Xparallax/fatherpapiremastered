using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;
    // [SerializeField]
    // private GameObject BigEnemyPrefab;

    [SerializeField]
    private float EnemyInterval = 3.5f;
    // [SerializeField]
    // private float BigEnemyInterval = 10f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(EnemyInterval, EnemyPrefab));
        // StartCoroutine(spawnEnemy(BigEnemyInterval, BigEnemyPrefab));
    }

   private IEnumerator spawnEnemy(float interval, GameObject enemy)
   {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
            newEnemy.transform.SetParent(transform);
        }
   }
}

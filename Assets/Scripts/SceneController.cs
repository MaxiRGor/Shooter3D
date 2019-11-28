using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int number;
    private GameObject[] _enemies;

    private void Start()
    {
        _enemies = new GameObject[number];
        for(int i = 0; i<number; i++)
        {
            createEnemy(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < number; i++)
        {
            if (_enemies[i] == null)
            {
                createEnemy(i);
            }
        }

    }

    void createEnemy(int i)
    {
        _enemies[i] = Instantiate(enemyPrefab) as GameObject;
        _enemies[i].transform.position = new Vector3(Random.Range(0, 5), 1, Random.Range(0, 5));
        float angle = Random.Range(0, 360);
        _enemies[i].transform.Rotate(0, angle, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefabWalk;
    public GameObject enemyPrefabFly;
    public float spawnRate = 1f;
    
    [SerializeField]
    private float cooldown;
    
    // Start is called before the first frame update
    void Start()
    {
        cooldown = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            GameObject go;
            if (Random.Range(0, 2) < 1)
            {

                go = Instantiate<GameObject>(enemyPrefabWalk, transform.position, Quaternion.identity);
                go.transform.parent = transform;
            }
            else
            {
                go = Instantiate<GameObject>(enemyPrefabFly, transform.position, Quaternion.identity);
                go.transform.position += Vector3.up;
            }
            cooldown = spawnRate;
        }
    }
    
}

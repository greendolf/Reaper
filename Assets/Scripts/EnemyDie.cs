using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDie : MonoBehaviour
{
    // COIN SPAWN FUNC

    public int minimumCount = 3;
    public int maximumCount = 5;
    public GameObject prefab;

    private float rangeOfSpawn;
    public float rangeSpread;
    public void Spawn()
    {
        // Randomly pick the count of prefabs to spawn.
        int count = Random.Range(minimumCount, maximumCount);
        // Spawn them!
        for (int i = 0; i < count; ++i)
        {
            float rangeOfSpawn = Random.Range(-rangeSpread / 2, rangeSpread / 2);
            transform.position = transform.position + new Vector3(rangeOfSpawn, 0, 0);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
    // END OF COIN SPAWN FUNC
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Gold;
    public float height;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newGold = Instantiate(Gold);
            newGold.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newGold, 10);
        }  
        timer += Time.deltaTime;
    }
}

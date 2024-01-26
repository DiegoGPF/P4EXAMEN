using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject EnemyBot;
    [SerializeField] private Transform trans;
    private int enemyCount;
    [SerializeField] private float enemys;
    [SerializeField] private float waitTime;
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCount <= enemys)
        {
            StartCoroutine(EnemyDrop());
            
            
        }
    }

    IEnumerator EnemyDrop()
    {
        
        Instantiate(EnemyBot, new Vector3(trans.position.x, trans.position.y, trans.position.z), Quaternion.identity);
        enemyCount += 1;
        yield return new WaitForSeconds(waitTime);

    }
}

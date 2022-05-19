using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoveAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void NewEnemy(){
        Random random = new Random();
        double enemyX = random.Next(-10, 10);
        double enemyY = random.Next(-10, 10);
        Instantiate(gameObject, new Vector3((float)enemyX, 0, (float)enemyY), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position == new Vector3(0, 0, 0)){
            NewEnemy();
            Destroy(gameObject);
        }
        else
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, GameObject.Find("Main Camera").transform.position, Time.deltaTime);
        }
    }
}

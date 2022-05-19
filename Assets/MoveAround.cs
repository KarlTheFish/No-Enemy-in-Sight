using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoveAround : MonoBehaviour
{
    private bool _isEnemy = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void NewEnemy(){
        Random random = new Random();
        double enemyX = random.Next(-10, 10);
        double enemyY = random.Next(-10, 10);
        /*while ((enemyX >= (double)-5 || enemyX <= (double)5) && (enemyY >= (double)-5 || enemyY <= (double)5)){
            enemyX = random.Next(-10, 10);
            enemyY = random.Next(-10, 10);
        }*/
        Instantiate(gameObject, new Vector3((float)enemyX, 0, (float)enemyY), Quaternion.identity);
        _isEnemy = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isEnemy == false){
            NewEnemy();
            Destroy(gameObject);
            _isEnemy = true;
        }
        else
        {
            Debug.Log(gameObject.transform.position);
        }
    }
}

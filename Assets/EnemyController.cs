using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullets")
        {
            
            Destroy(col.gameObject);
            Destroy(gameObject);
            
        }
    }
}

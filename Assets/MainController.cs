using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainController : MonoBehaviour {
    public Rigidbody2D Aliens;
    private const float ForceMagnitude = 10.0f;
    // Use this for initialization
    void Start () {
        
        for (int i = 0; i < 10; i++) {
            float angle = Random.Range(1.0f, 360.0f);
            float r = Random.Range(10.0f, 20.0f);
            Vector2 rand_position = new Vector2( r * Mathf.Cos(Mathf.Deg2Rad*angle), r * Mathf.Sin(Mathf.Deg2Rad*angle));            
            Rigidbody2D AlienClone = Instantiate(Aliens, rand_position, Quaternion.identity) as Rigidbody2D;
            AlienClone.transform.Rotate(new Vector3(0,0,angle+90),Space.World);
            AlienClone.AddForce(new Vector2(-rand_position.x, -rand_position.y)* ForceMagnitude);
        }
    }
	
	

    

    
}

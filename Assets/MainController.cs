using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {
    public Rigidbody2D Aliens;
    private const float ForceMagnitude = 10.0f;
    // Use this for initialization
    void Start () {
        
        for (int i = 0; i < 10; i++) {
            Vector2 rand_position = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
            
            Rigidbody2D AlienClone = Instantiate(Aliens, rand_position, Quaternion.identity) as Rigidbody2D;
            AlienClone.AddForce(new Vector2(-rand_position.x, -rand_position.y)* ForceMagnitude);
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    
}

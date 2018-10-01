using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainController : MonoBehaviour {
    public Rigidbody2D Aliens;
    private float Timer;
    private const float ForceMagnitude = 5.0f;
    // Use this for initialization
    void CreateEnemy(int number)
    {
        for (int i = 0; i < number; i++)
        {
            float angle = Random.Range(1.0f, 360.0f);
            float r = Random.Range(10.0f, 50.0f);
            Vector2 rand_position = new Vector2(r * Mathf.Cos(Mathf.Deg2Rad * angle), r * Mathf.Sin(Mathf.Deg2Rad * angle));
            Rigidbody2D AlienClone = Instantiate(Aliens, rand_position, Quaternion.identity) as Rigidbody2D;
            AlienClone.transform.Rotate(new Vector3(0, 0, angle + 90), Space.World);
            AlienClone.AddForce(new Vector2(-rand_position.x, -rand_position.y) * ForceMagnitude);

        }
    }
    void Start () {
            CreateEnemy(10);
        }

    void Update(){
            Timer += Time.deltaTime;
            if (Timer>5)
            {
            Timer = 0;
            CreateEnemy(1);
            }
        }
    }
	
	

    

    


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	private Rigidbody2D rb2;
    
    public Rigidbody2D Bullets;
    private Transform trans;
    private float horizontalForce;
    private const float radius = 2f;
    private const float shootForce = 10f;


    // Use this for initialization
    void Start () {
        rb2 = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
       

       

    }

    void Fire()
    {
        
        Rigidbody2D BulletClone = Instantiate(Bullets, trans.position+ trans.up, Quaternion.identity) as Rigidbody2D;
        BulletClone.AddForce(trans.up * shootForce,ForceMode2D.Impulse);
        Destroy(BulletClone.gameObject, 5);
        //BulletClone.velocity = BulletClone.transform.forward * shootForce; //new Vector2(BulletClone.transform.forward.x*shootForce, BulletClone.transform.forward.y*shootForce);

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        
        var x = trans.position.x;
        var y = trans.position.y;
        Vector2 force = new Vector2(0, 0);
        if (x >= 0 && y > 0)
        {
            force = new Vector2(y / radius, (-1) * x / radius)  ;
        }
        else if (x > 0 && y <= 0)
        {
            force = new Vector2(y / radius, (-1) * x / radius) ;
        }
        else if (x <= 0 && y < 0)
        {
            force = new Vector2(y / radius, (-1)*x / radius) ;
        }
        else if(x < 0 && y >= 0) 
        {
            force = new Vector2(y / radius, (-1)*x / radius) ;
        }


        //trans.rotation = Quaternion.Euler(0, 0, 45);
        
        horizontalForce = Input.GetAxis("Horizontal");
        //trans.Rotate(0, 0, 1);
        rb2.AddForce(force* horizontalForce, ForceMode2D.Impulse);
       

        if (Input.GetButtonDown("Jump"))
            {
            Fire();
        }
        

	}
}

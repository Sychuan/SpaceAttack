using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Earth_controller : MonoBehaviour {
    int health = 5;
    public Text health_data;
    public Text Killed_info;
    public static int killed_enemies_number = 0;

    // Use this for initialization
    void Start () {
        health_data.text = "5";    
    }	

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Aliens" & health>=1)
        {

            Destroy(col.gameObject.GetComponent<Collider2D>());
            Destroy(col.gameObject, 2);
            health -= 1;
            health_data.text = health.ToString();
        }
        if (health < 1)
        {
            //StartCoroutine(WaitingCoroutine());
            
        }
    }


    IEnumerator WaitingCoroutine()
    {        
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("EndScene");
    }

    void Update()
    {
        Killed_info.text = killed_enemies_number.ToString();
    }
}



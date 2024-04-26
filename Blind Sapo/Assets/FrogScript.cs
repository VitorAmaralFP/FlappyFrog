using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FrogScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool frogIsAlive = true;
 
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && frogIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        frogIsAlive = false;
    }
}
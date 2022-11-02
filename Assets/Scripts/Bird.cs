using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird : MonoBehaviour
{
    public GameOverManager gameManager;
    Rigidbody2D rb2d;
    public GameObject unfreezeButton;
    public float speed = 80f;
    [SerializeField]
    private float flapForce = 300f;
    bool isDead=false;
    public bool yesDead=false;


    void OnCollisionEnter2D(Collision2D col){
        isDead = true;
        yesDead = true;
        gameManager.GameOver();
        GetComponent<Animator>().SetBool("isDead", true);
    }

    public void UnFreeze(){
        Time.timeScale = 1;
        unfreezeButton.SetActive(false);
    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
        unfreezeButton.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&&!isDead){
            
            rb2d.velocity=Vector2.up*flapForce;
        }
    }
}

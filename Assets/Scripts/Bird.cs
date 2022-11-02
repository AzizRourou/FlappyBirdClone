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
    //int score=0;

    /*void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="Score"){
            score++;
            Debug.Log(score);
        }
    }*/

    void OnCollisionEnter2D(Collision2D col){
        isDead = true;
        yesDead = true;
        gameManager.GameOver();
        GetComponent<Animator>().SetBool("isDead", true);
    }

    

    public void UnFreeze(){
        Time.timeScale = 1;
        unfreezeButton.SetActive(false);
        //rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }

    //void Awake(){
     //   rb2d = GetComponent<Rigidbody2D>();
    //}

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        Time.timeScale = 0;
        unfreezeButton.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        if(Input.GetMouseButtonDown(0)&&!isDead){
            
            rb2d.velocity=Vector2.up*flapForce;
        }
    }
}

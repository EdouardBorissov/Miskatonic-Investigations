using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fireBall : MonoBehaviour {
    public float speed;
    public float xSpeed;
    public float ySpeed;
    private Rigidbody2D rigidBody;
    public int secondsBurn;
    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();

      StartCoroutine(ballBurn(secondsBurn));
    }
	
	// Update is called once per frame
	void Update () {
        fireBallMovement();
    }

    void OnTriggerEnter2D(Collider2D trig)
    {

        if (trig.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }

        if(trig.tag == "monster")
        {
            //todo monster monsterScript =  trig.gameObject.GetComponent<monster>();
            // monsterScript.StartCoroutine("slowdownMonster");
            
        }
    }

    IEnumerator ballBurn(int seconds)
    {

        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    
     }

    

void fireBallMovement()
    {
        rigidBody.velocity = new Vector2(xSpeed,ySpeed) * speed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMonsterButton : MonoBehaviour {
    public GameObject monster;
    public Transform Player;

   
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        float distToPlayer = Vector3.Distance(Player.position, transform.position);
        if (distToPlayer <= 1.5f)
        {
            Debug.Log("Button is in range");
        }
    }

    void OnMouseDown()
    {
        float distToPlayer = Vector3.Distance(Player.position,transform.position);
    if(distToPlayer <= 1.5f)
    {
            killMonster();
    }      
        
    }

    
 

    public void killMonster()
    {
        Destroy(monster.gameObject);
    }
}

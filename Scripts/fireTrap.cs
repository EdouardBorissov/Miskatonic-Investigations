using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireTrap : MonoBehaviour {
    public GameObject fireBall;
    public GameObject otherFireTrap;
    int fireTrapState = 0;
    public float secondsWait;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void doFireTrap()
    {

    if(gameObject.tag == "fireTrapVertical")
    {
          
            Debug.Log("FireTrap Function Was Called");
            for (int i = 0; i <5; i++)
            {
                StartCoroutine(oneSecondWait(secondsWait));
                //Instantiate(fireBall, transform.position, transform.rotation);
               
            }
    }
    else if(gameObject.tag == "fireTrapHorizontal")
    {
           
            Debug.Log("FireTrap Function Was Called");
            for (int i = 0; i < 5; i++)
            {

                StartCoroutine(oneSecondWait(secondsWait));
               // Instantiate(fireBall, transform.position, transform.rotation);
                
            }
        }

       

    }



    IEnumerator oneSecondWait(float secondsWait)
    {
        yield return new WaitForSeconds(secondsWait);
        Instantiate(fireBall, transform.position, transform.rotation);
        Debug.Log(secondsWait + " second(s) were waited");
    }
}

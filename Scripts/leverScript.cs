using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverScript : MonoBehaviour {
    public Transform Player;
    public GameObject someObject;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        float distToPlayer = Vector3.Distance(Player.position, transform.position);
        if (distToPlayer <= 1.5f)
        {
            Debug.Log("Lever is in range");
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Lever was Clicked");
        float distToPlayer = Vector3.Distance(Player.position, transform.position);
        if (distToPlayer <= 1.5f)
        {

            Debug.Log("Lever was Clicked AND PLAYER WAS CLOSE ENOUGH");

            if (someObject.tag == "doorHorizontal" || someObject.tag == "doorVertical")
        {
                Debug.Log("door tag worked");
                door someObjectsDoor = someObject.GetComponent<door>();
                someObjectsDoor.moveDoor();
                Debug.Log("Door was Opened");
        }
            if(someObject.tag == "bridge")
        {
                bridge someObjectsBridge = someObject.GetComponent<bridge>();
                someObjectsBridge.moveBridge();
                Debug.Log("Bridge was Extended");
            }

             if(someObject.tag == "fireTrapHorizontal" || someObject.tag == "fireTrapVertical")
            {
                Debug.Log("FireTrap was Successfully Detected by Lever");
                fireTrap someObjectsFireTrap = someObject.GetComponent<fireTrap>();
                someObjectsFireTrap.doFireTrap();
                Debug.Log("Fire Trap was Enabled/Disabled");

            }


        }

    }

}

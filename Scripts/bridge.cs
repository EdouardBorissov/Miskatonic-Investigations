using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge : MonoBehaviour {
    private int bridgeState = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void moveBridge()
    {
        if(gameObject.tag == "bridgeHorizonal")
        {
            transform.Translate(1,0,0);
        }
        else if(gameObject.tag == "bridgeVertical")
        {
            transform.Translate(0, 1, 0);
        }
    }
}

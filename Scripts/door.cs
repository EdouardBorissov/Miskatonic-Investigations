using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
    int doorState = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
    if(doorState == 0)
    {
            Debug.Log("The Door is Closed");
    }
    else if (doorState==1)
    {
            Debug.Log("The Door is Open");

        }
    }

   public void moveDoor()
    {
        if (doorState == 0)
        {
            if (gameObject.tag == "doorVertical")
            {
                transform.Translate(3, 0, 0);
                Debug.Log("Door was opened");
                doorState++;
            }
            else if (gameObject.tag == "doorHorizontal")
            {
                transform.Translate(3, 0, 0);
                Debug.Log("Door was opened");
                doorState++;
            }
        }
        else if(doorState == 1)
        {
            if (gameObject.tag == "doorVertical")
            {
                transform.Translate(-3, 0, 0);
                Debug.Log("Door was closed");
                doorState--;
            }
            else if (gameObject.tag == "doorHorizontal")
            {
                transform.Translate(-3, 0, 0);
                Debug.Log("Door was closed");
                doorState--;
            }
        }
    }
}

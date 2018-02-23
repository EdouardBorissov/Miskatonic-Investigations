using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private float speed;
    private Rigidbody2D _rigidBody;

	// Use this for initialization
	void Start () {
        _rigidBody = gameObject.GetComponent<Rigidbody2D>();
	}
    void playermovement()
    {
        _rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;

    }
    // Update is called once per frame
    void Update () {
        playermovement();
	}
}

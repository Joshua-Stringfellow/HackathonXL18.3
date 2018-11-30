using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

    //private Animator animator;
    private Transform elevatorLocation;
    private List<Vector3> exitPath;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;

    // Use this for initialization
    void Start () {
        //animator = GetComponent<Animator>;
        elevatorLocation = GameObject.FindGameObjectWithTag("Elevator").transform;
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
        FindPath();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FindPath()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

    //private Animator animator;
    private Transform elevator;
    private Transform player;
    private Rigidbody2D rb2D;
    private float inverseMoveTime;

    public float moveTime = 0.1f;
    public List<Vector3> exitPath;
    private int pathStep = 0;
    public float minDistanceFromPlayer = 5f;

    // Use this for initialization
    void Start () {
        //animator = GetComponent<Animator>;
        elevator = GameObject.FindGameObjectWithTag("Elevator").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb2D = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1 / moveTime;
    }
	
	// Update is called once per frame
	void Update () {
		/*if (Mathf.Abs(player.position.x - transform.position.x) + Mathf.Abs(player.position.y - transform.position.y) < minDistanceFromPlayer)
        {
            MoveBoss();
        }*/
	}

    private void MoveBoss()
    {
        GameManager.instance.FreezePlayer();
        Vector3 start = transform.position;
        Vector3 end = start + exitPath[pathStep];
        
        StartCoroutine(SmoothMovement(end));

        pathStep++;

        GameManager.instance.UnfreezePlayer();

        if (pathStep >= exitPath.Count)
        {
            gameObject.SetActive(false);
        }
    }

    protected IEnumerator SmoothMovement(Vector3 end)
    {
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;

        while (sqrRemainingDistance > float.Epsilon)
        {
            Vector3 newPosition = Vector3.MoveTowards(rb2D.position, end, inverseMoveTime * Time.deltaTime);
            rb2D.MovePosition(newPosition);
            sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMove : MonoBehaviour {
    public Vector2 speed = new Vector2(1,1);
    public Vector2 direction = new Vector2(0,1);

    private Vector2 movement;

    private void Update()
    {
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);

        if (transform.position.y > (Camera.main.transform.position.y + 10))
        {
            Destroy(gameObject);
        }

    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}

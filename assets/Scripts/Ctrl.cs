using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ctrl : MonoBehaviour
{
    public float speed = 1.5f;

    void Update()
    {
        if (!GameManager.instance.playerCanMove) return;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Elevator")
        {
            ElevatorTransition();
        }
    }

    private void ElevatorTransition()
    {
        GameManager.instance.playerCanMove = false;
        // TODO: Stop clock
        SceneManager.LoadScene("Elevator");
    }
}
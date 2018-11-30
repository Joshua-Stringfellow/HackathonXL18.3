using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ctrl : MonoBehaviour
{
    public float speed = 1.5f;

    void Start()
    {
        GameManager.instance.UnfreezePlayer();
    }

    void Update()
    {
        if (!GameManager.instance.PlayerCanMove()) return;

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
        if (collision.tag == "Obstacle")
        {
            GameManager.instance.points += 2;
        }
    }

    private void ElevatorTransition()
    {
        GameManager.instance.FreezePlayer();
        SceneManager.LoadScene("Elevator");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int points = 0;
    public static GameManager instance = null;
    private bool playerCanMove = true;
    // TODO: add clock implementation

    // SET INITIAL SCORES HERE

	// Use this for initialization
	void Awake () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        InitGame();
	}

    void InitGame()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FreezePlayer()
    {
        playerCanMove = false;
        // TODO: stop the clock
    }

    public void UnfreezePlayer()
    {
        playerCanMove = true;
        // TODO: restart the clock
    }

    public bool PlayerCanMove()
    {
        return playerCanMove;
    }
}

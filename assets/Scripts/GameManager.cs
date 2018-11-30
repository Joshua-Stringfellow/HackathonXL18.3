using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public int points = 0;
    public bool playerCanMove = true; // Set GameManager.instance.playerCanMove to false from anywhere to disable player movement
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
    public bool PlayerCanMove()
    {

        return playerCanMove;
    }
    public bool UnfreezePlayer()
    {

        return playerCanMove;
    }

    public bool FreezePlayer()
    {
        playerCanMove = false;
        return playerCanMove;
    }

    void InitGame()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
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

    void InitGame()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

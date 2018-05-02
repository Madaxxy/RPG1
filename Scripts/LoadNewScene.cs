using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {
    public string levelToLoad;

    public string exitPoint; // make this back to a string if it doesnt work.

    private PlayerController thePlayer;

    private PlayerStartPoint theSP;


	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        theSP = FindObjectOfType<PlayerStartPoint>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            
            
           SceneManager.LoadScene(levelToLoad);
                
            
            
        }
    }
}

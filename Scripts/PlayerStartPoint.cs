using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

    private PlayerController thePlayer;
    private CameraController theCamera;

    public string startPoint;

    public Vector2 startFace;

    public string pointName;
    private LoadNewScene theLNS;


	// Use this for initialization
	public void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        theLNS = FindObjectOfType<LoadNewScene>();

       if ( thePlayer.startPoint == pointName) 
        {

            thePlayer.transform.position = transform.position;
            thePlayer.lastMove = startFace;

            theCamera = FindObjectOfType<CameraController>();
            theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
        }
	}
	
	// Update is called once per frame
	void Update () {

      
    }
}

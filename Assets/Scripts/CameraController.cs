using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject player;
	
	private Vector3 offset;
	
	void Start () {
		offset = transform.position - player.transform.position; 
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
        //adding a comment to test source control
		transform.position = player.transform.position + offset;
	}

}

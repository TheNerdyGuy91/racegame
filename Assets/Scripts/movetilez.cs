// move the tile forward
using UnityEngine;
using System.Collections;

public class movetilez : MonoBehaviour {

	public int move;
	Vector3 movement; // moving in the z direction

	void Update () 
	{
		int i = 0;
		movement = new Vector3 (0, 0, move);
		if (i < 5) {
			transform.Translate (movement);
			i++;
		} 
		else
		{
			i = 0;
			move *= -1;
		}
	}

}

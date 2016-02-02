using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	// We are not using forces so we can use the update function and not use fixedupdate.
	void Update () {

		// rotate the cube by angles 15 , 30 and 45 along each axis
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}

using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

    Transform cube;
	void Start () {
        cube = GetComponent<Transform>();
	}
	
	void Update () {
        cube.Rotate(0.1f, 0.2f, 0.3f);
	}

}

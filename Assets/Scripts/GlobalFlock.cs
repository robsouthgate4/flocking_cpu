using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlock : MonoBehaviour {

	public GameObject birdPrefab;

    static int numofBirds = 100;
	public static float scale = 5f;
	public static Vector3 goalPos = Vector3.zero;
	public static GameObject[] birds = new GameObject[numofBirds];


	// Use this for initialization
	void Start () {

		for (int i = 0; i < numofBirds; i++) {
			Vector3 pos = new Vector3 (
				Random.Range(-scale, scale),
				Random.Range(-scale, scale),
				Random.Range(-scale, scale)
			);
			birds [i] = Instantiate (birdPrefab, pos, Quaternion.identity); 
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range (0, 10000) < 50) {
			goalPos = new Vector3 (
				Random.Range(-scale, scale),
				Random.Range(-scale, scale),
				Random.Range(-scale, scale)
			);
		}
	}
}

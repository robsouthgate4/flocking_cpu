using UnityEngine;
using System.Collections;

public class lb_Bird : MonoBehaviour {

	Animator anim;
	Flock flock;
	int flyingBoolHash;

	void Start() {
		flock = GetComponent<Flock>();
		flyingBoolHash = Animator.StringToHash("flying");
		anim.SetBool (flyingBoolHash,true);
		Debug.Log("hello");
		//anim.speed = Random.Range (0.2f, 2f);
	}

	void OnEnable(){
		anim = gameObject.GetComponent<Animator>();
	}

	void Update() {
		anim.speed = flock.speed * 1.5f;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {
    private Animator _animator;
    //public Gameobject door = null;
    private bool _isInsiderTrigger = false;
	// Use this for initialization
	void Start () {
        _animator = GameObject.Find("Cube_1").GetComponent<Animator>();

    }

    void onTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("open", true);


        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

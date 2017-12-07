using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _movementOffset = 1f;

    private Vector3 movementVector = Vector3.one;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}

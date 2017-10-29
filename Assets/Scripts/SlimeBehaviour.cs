using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehaviour : MonoBehaviour {
	public float moveSpeed{get; set;}
	public float moveConveyorBell{get; set;}
	public Rigidbody rb;
    public Transform tag;

	void Start () {
		moveSpeed=8.0f;
		moveConveyorBell=1.0f;
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {

        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, tag.position, step);
    }
	
	void OnMouseDown()
	{	
		Destroy(this.gameObject);
	}
}

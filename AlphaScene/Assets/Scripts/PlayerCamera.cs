using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	private Transform target;
	private Vector3 cameraTarget;


	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	

	void Update () {
				transform.LookAt (target);	
		}
}

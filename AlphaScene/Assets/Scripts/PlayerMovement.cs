using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float Walkspeed = 5.0f;
	public float runSpeed = 10.0f;
	public float rotationSpeed = 450.0f;

	private Quaternion targetRotation;
	private CharacterController controller;
	private Camera cam;

	
	void Start () {
		controller = GetComponent<CharacterController> ();
		cam = GameObject.Find("PlayerCamera").camera;
		
	}
	void Update(){
		MouseController ();

	}
	void MouseController(){
		Vector3 mousePos = Input.mousePosition;
		mousePos = cam.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, cam.transform.position.y - transform.position.y));
		targetRotation = Quaternion.LookRotation (mousePos - new Vector3(transform.position.x,0,transform.position.z));
		transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle (transform.eulerAngles.y, targetRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);
		
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
		Vector3 motion = input;
		motion *= (Mathf.Abs (input.x) == 1 && Mathf.Abs (input.z) == 1) ? .7f : 1;
		motion *= (Input.GetButton ("Run")) ? runSpeed : Walkspeed;
		motion += Vector3.up * -8;
		controller.Move (motion * Time.deltaTime);
		}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

	public NavMeshAgent agent;
	public Camera cam;
	void Start () {
		if (cam == null)
			cam = FindObjectOfType<Camera> ();
	}
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			var ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				agent.SetDestination (hit.point);
			}
		}
	}
}
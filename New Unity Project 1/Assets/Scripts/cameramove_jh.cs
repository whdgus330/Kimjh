using UnityEngine;
using System.Collections;

public class cameramove_jh : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			transform.Translate(0, 0, -0.1f);
		}
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			transform.Translate(0, 0, 0.1f);
		}
		if (Input.GetMouseButton(0))
		{
			if (Input.GetAxis("Mouse X") < 0)
			{
				transform.Translate(0.1f, 0, 0);
			}
		}
		if (Input.GetMouseButton(0))
		{
			if (Input.GetAxis("Mouse X") > 0)
			{
				transform.Translate(-0.1f, 0, 0);
			}
		}
		if (Input.GetMouseButton(0))
		{
			if (Input.GetAxis("Mouse Y") < 0)
			{
				transform.Translate(0, 0.1f, 0);
			}
		}
		if (Input.GetMouseButton(0))
		{
			if (Input.GetAxis("Mouse Y") > 0)
			{
				transform.Translate(0, -0.1f, 0);
			}
		}
		if (Input.GetMouseButton(1))
		{
			if (Input.GetAxis("Mouse X") > 0)
			{
				transform.Rotate(0, 0.5f, 0, Space.World);
				transform.Translate(-0.17f, 0, 0);
			}
		}
		if (Input.GetMouseButton(1))
		{
			if (Input.GetAxis("Mouse X") < 0)
			{
				transform.Rotate(0, -0.5f, 0, Space.World);
				transform.Translate(0.17f, 0, 0);
			}
		}

	}
}

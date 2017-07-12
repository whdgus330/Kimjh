using UnityEngine;
using System.Collections;

public class camerazoom_jh : MonoBehaviour {
	public float zoomSize = 5;
	public bool a = true;
	
	// Use this for initialization
	void MoveLimit()
	{
		Vector3 temp;
		temp.x = Mathf.Clamp(transform.position.x, -8.28f, 3.98f);
		temp.y = Mathf.Clamp(transform.position.y, -2.21f, 7.82f);
		temp.z = Mathf.Clamp(transform.position.z, -10f, -10f);
		transform.position = temp;
		Debug.Log("aaaa");
	}

	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () {
		Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

		if (Input.GetMouseButtonUp(0))
		{
			
			if (hit.collider.tag == "a")
			a = false;
		}
		
	}
	void LateUpdate()
	{	
		if (a == false)
		{
			transform.position = new Vector3( GameObject.FindGameObjectWithTag("house").transform.position.x, GameObject.FindGameObjectWithTag("house").transform.position.y, -10);
			zoomSize -= 3;

			GetComponent<Camera>().orthographicSize = zoomSize;
			MoveLimit();
			a = true;
		}
	}


}
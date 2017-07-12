using UnityEngine;
using System.Collections;

public class gold : MonoBehaviour {
	public TextMesh currSco;

	void Awake()
	{
		currSco.text = "" + GameManager.Instance.S_fMoney;
	}
	// Use this for initialization
	void Start () {
		GameManager.Instance.S_fMoney += 20;
	}
	
	// Update is called once per frame
	void Update () {
	currSco.text = "" + GameManager.Instance.S_fMoney;
	}
}

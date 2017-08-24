using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prof_line : MonoBehaviour {

	public GameObject profline;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Remove() {
		GameObject.Destroy(this.gameObject);
	}

	public void Add(Transform parent) {
		Instantiate(profline, parent);
	}
}

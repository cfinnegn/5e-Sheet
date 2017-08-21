using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatPane : MonoBehaviour {

	public Color zero;
	public Color minus;
	public Color plus;

	public Image ModPane;
	public int ModVal;
	public Text ModText;

	public int StatVal;
	public Text StatText;

	// Use this for initialization
	void Start () {
		StatText.text = "" + StatVal;
		Mod_update();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Mod_update() {
		ModVal = (StatVal / 2) - 5;
		ModText.text = (ModVal > 0) ? "+" + ModVal : "" + ModVal;

		if(ModVal < 0) { ModPane.color = minus; }
		else if(ModVal == 0) { ModPane.color = zero; }
		else { ModPane.color = plus; }
	}

	public void stat_up() {
		if(StatVal < 30) { StatVal++; }
		StatText.text = "" + StatVal;
		Mod_update();
	}

	public void stat_down() {
		if(StatVal > 0) { StatVal--; }
		StatText.text = "" + StatVal;
		Mod_update();
	}
}

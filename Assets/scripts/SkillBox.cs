using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class SkillBox : MonoBehaviour {

	StatPane stat;
	public bool proficient = false;
	public Text skill;
	Regex digits = new Regex("[0-9]+");

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void init_stat(StatPane sp) {
		stat = sp;
		update_val();
	}

	public void update_val() {
		string[] splitstring = skill.text.Split(':');
		int bonus = ((proficient) ? stat.ModVal + Character.profbonus : stat.ModVal);
		splitstring[splitstring.Length - 1] = ": " + ((bonus >= 0) ? "+"+ bonus : ""+bonus);
		string joinstring = string.Join("", splitstring);
		skill.text = joinstring;
	}

	public void set_proficient(bool b) {
		proficient = b;
	}

	public void on_stat_change() {
		update_val();
	}

	public void on_level_change() {
		update_val();
	}
}

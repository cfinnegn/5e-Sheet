using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {

	[Header("Main Stats")]
	public StatPane Str;
	public StatPane Dex;
	public StatPane Con;
	public StatPane Int;
	public StatPane Wis;
	public StatPane Cha;

	[Header("Combat Stats")]
	public static int profbonus;
	public Text prof_txt;

	public int AC = 10;
	public Text ACtxt;

	public int HP = 0;
	public Text HPtxt;
	public int maxHP = 0;
	public Text maxHPtxt;

	public int Speed = 30;
	public Text Speedtxt;

	[Header("Level Info")]
	// class level
	public bool multiclass = false;
	public int Class1_lv = 1;
	public Text Class1_lv_txt;
	public int Class2_lv = 0;
	public Text Class2_lv_txt;

	// hit die
	public int hitdie1;
	public Text hdtxt1;
	public int hitdie2;
	public Text hdtxt2;

	[Header("Skills/Saves")]
	public bool yes;
	// Use this for initialization
	void Start() {
		update_prof();
		updateAC(0);
		updateHP(0);
		updateSpeed(0);
	}

	// Update is called once per frame
	void Update() {

	}

	public void levelup(int cl) {
		if(cl == 1 && Class1_lv < 20) {
			Class1_lv++;
			hitdie1++;
			Class1_lv_txt.text = "Level: <b>" + Class1_lv + "</b>";
			hdtxt1.text = "Hit Die: <b>" + hitdie1 + "</b> / <b>" + Class1_lv + "</b>";
		}
		else if(Class2_lv < 20) {
			Class2_lv++;
			hitdie2++;
			Class2_lv_txt.text = "Level: <b>" + Class2_lv + "</b>";
			hdtxt2.text = "Hit Die: <b>" + hitdie2 + "</b> / <b>" + Class2_lv + "</b>";
		}
		update_prof();
	}
	public void leveldown(int cl) {
		if(cl == 1 && Class1_lv > 1) {
			Class1_lv--;
			Class1_lv_txt.text = "Level: <b>" + Class1_lv + "</b>";
			hdtxt1.text = "Hit Die: <b>" + hitdie1 + "</b> / <b>" + Class1_lv + "</b>";
		}
		else if(Class2_lv > 1) {
			Class2_lv--;
			Class2_lv_txt.text = "Level: <b>" + Class2_lv + "</b>";
			hdtxt2.text = "Hit Die: <b>" + hitdie2 + "</b> / <b>" + Class2_lv + "</b>";
		}
		update_prof();
	}

	public void hit_die(int hd) {
		if(hd == 1 && hitdie1 > 0) {
			hitdie1--;
			hdtxt1.text = "Hit Die: <b>" + hitdie1 + "</b> / <b>" + Class1_lv + "</b>";
		}
		else if(hitdie2 > 0) {
			hitdie2--;
			hdtxt2.text = "Hit Die: <b>" + hitdie2 + "</b> / <b>" + Class2_lv + "</b>";
		}
	}

	public void long_rest() {
		hitdie1 = Class1_lv;
		hitdie2 = Class2_lv;
		hdtxt1.text = "Hit Die: <b>" + hitdie1 + "</b> / <b>" + Class1_lv + "</b>";
		hdtxt2.text = "Hit Die: <b>" + hitdie2 + "</b> / <b>" + Class2_lv + "</b>";
	}

	public void update_prof() {
		if(multiclass) { profbonus = ((Class1_lv + Class2_lv - 1) / 4) + 2; }
		else { profbonus = ((Class1_lv - 1) / 4) + 2; }
		prof_txt.text = "" + profbonus;
	}

	public void set_multiclass(bool b) {
		multiclass = b;
	}

	public void updateAC(int i) {
		AC += i;
		ACtxt.text = ""+AC;
	}
	public void updateHP(int i) {
		HP += i;
		HPtxt.text = "" + HP;
	}
	public void updateMaxHP() {
		maxHP = HP;
		maxHPtxt.text = "HP (" + maxHP + ")";
	}
	public void updateSpeed(int i) {
		Speed += i;
		Speedtxt.text = "" + Speed;
	}
}


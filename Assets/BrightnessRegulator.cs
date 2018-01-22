using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour {
    Material myMaterial;
    private float minEmission = 0.3f;
    private float magEmission = 2.0f;
    private int degree = 0;
    private int speed = 10;
    Color defultColor = Color.white;
	void Start () {
        if (tag == "SmallStarTag") { this.defultColor = Color.white; }
        else if (tag == "LargeStarTag"){ this.defultColor = Color.yellow;}
        else if(tag == "SmallCloudTag" || tag == "largeStarTag"){ this.defultColor = Color.blue; }
        this.myMaterial = GetComponent<Renderer>().material;
        myMaterial.SetColor("_EmissionColor", this.defultColor*minEmission);
	}
	
	// Update is called once per frame
	void Update () {
        if (this.degree >= 0) { Color emissionColor = this.defultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
            myMaterial.SetColor("_EmissionColor", emissionColor);
            this.degree -= this.speed;
        }
	}
    private void OnCollisionEnter(Collision other)
    {
        this.degree = 180;
    }
}

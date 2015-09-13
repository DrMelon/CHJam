using UnityEngine;
using System.Collections.Generic;

public class GlassesScript : MonoBehaviour {

    public bool HasGlasses = false;
    public List<Sprite> glassesList;

    // Use this for initialization
    void Start()
    {
        if (Random.Range(0.0f, 100.0f) > 66.0f)
        {
            HasGlasses = true;
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
            HasGlasses = false;
            this.GetComponent<SpriteRenderer>().color = Color.clear;
        }

        SpriteRenderer sprrend = this.GetComponent<SpriteRenderer>();
        sprrend.sprite = glassesList[Random.Range(0, glassesList.Count)];

        if (sprrend.sprite.name.Contains("glasses1"))
        {
            //pos
            this.transform.localPosition = new Vector3(-0.542f, 1.293f, -0.44f);
        }
        if (sprrend.sprite.name.Contains("glasses2"))
        {
            //pos
            this.transform.localPosition = new Vector3(-0.535f, 1.477f, -0.44f);
        }
        if (sprrend.sprite.name.Contains("glasses3"))
        {
            //pos
            this.transform.localPosition = new Vector3(-0.535f, 1.477f, -0.44f);
        }
        if (sprrend.sprite.name.Contains("glasses4"))
        {
            //pos
            this.transform.localPosition = new Vector3(-0.505f, 1.438f, -0.44f);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}

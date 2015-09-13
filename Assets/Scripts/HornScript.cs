using UnityEngine;
using System.Collections.Generic;

public class HornScript : MonoBehaviour {

    public bool HasHorns = false;
    public List<Sprite> hornList;

    // Use this for initialization
    void Start()
    {
        if (Random.Range(0.0f, 100.0f) > 50.0f)
        {
            HasHorns = true;
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
            HasHorns = false;
            this.GetComponent<SpriteRenderer>().color = Color.clear;
        }

        SpriteRenderer sprrend = this.GetComponent<SpriteRenderer>();
        sprrend.sprite = hornList[Random.Range(0, hornList.Count)];

        if (sprrend.sprite.name.Contains("horn1"))
        {
            //pos
            this.transform.localPosition = new Vector3(0.698f, 2.92f, -0.75f);
        }
        if (sprrend.sprite.name.Contains("horn2"))
        {
            //pos
            this.transform.localPosition = new Vector3(0.698f, 2.92f, -0.75f);
        }
        if (sprrend.sprite.name.Contains("horn3"))
        {
            //pos
            this.transform.localPosition = new Vector3(0.698f, 2.92f, -0.75f);
        }
        if (sprrend.sprite.name.Contains("horn4"))
        {
            //pos
            this.transform.localPosition = new Vector3(0.698f, 2.92f, -0.75f);
        }
    }

    // Update is called once per frame
    void Update ()
    {
	
	}
}

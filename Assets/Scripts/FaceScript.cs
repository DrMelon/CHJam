using UnityEngine;
using System.Collections.Generic;

public class FaceScript : MonoBehaviour {

    // List of possible faces
    public List<Sprite> faceList;

	// Use this for initialization
	void Start ()
    {
        // Pick a face.
        SpriteRenderer sprrend = this.GetComponent<SpriteRenderer>();
        sprrend.sprite = faceList[Random.Range(0, faceList.Count)];



        // Depending on chosen face, try to shuffle stuff around to fit.
        if (sprrend.sprite.name == "face6")
        {
            this.transform.localPosition = new Vector3(-0.5f, 1.3f, -0.4f);
        }
        if (sprrend.sprite.name == "face3")
        {
            this.transform.localPosition = new Vector3(-0.5f, 1.19f, -0.4f);
        }
        if (sprrend.sprite.name == "face8")
        {
            this.transform.localPosition = new Vector3(-0.54f, 1.39f, -0.4f);
        }
        if (sprrend.sprite.name == "face1")
        {
            this.transform.localPosition = new Vector3(-0.54f, 1.28f, -0.4f);
        }
        if (sprrend.sprite.name == "face2")
        {
            this.transform.localPosition = new Vector3(-0.54f, 1.26f, -0.4f);
        }
        if (sprrend.sprite.name == "face4")
        {
            this.transform.localPosition = new Vector3(-0.52f, 1.3f, -0.4f);
        }
        if (sprrend.sprite.name == "face5")
        {
            this.transform.localPosition = new Vector3(-0.52f, 1.3f, -0.4f);
        }
        if (sprrend.sprite.name == "face7")
        {
            this.transform.localPosition = new Vector3(-0.54f, 1.28f, -0.4f);
        }
        if (sprrend.sprite.name == "face9")
        {
            this.transform.localPosition = new Vector3(-0.54f, 1.28f, -0.4f);
        }
        if (sprrend.sprite.name == "face10")
        {
            this.transform.localPosition = new Vector3(-0.52f, 1.1f, -0.4f);
        }
        if (sprrend.sprite.name == "face11")
        {
            this.transform.localPosition = new Vector3(-0.52f, 1.1f, -0.4f);
        }
        if (sprrend.sprite.name == "face12")
        {
            this.transform.localPosition = new Vector3(-0.52f, 1.1f, -0.4f);
        }








    }

    // Update is called once per frame
    void Update () {
	
	}
}

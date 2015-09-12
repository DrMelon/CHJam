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
            this.transform.localPosition = new Vector3(-0.5f, 1.3f, 0.0f);
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class BodyPart : MonoBehaviour {

    // The bodypart is used as a paperdolling aid; it will simply load an art asset from a file, sticking it onto a plane.
    // Each part will also have offsets
    public Material bodypartMaterial = null;
    public Vector2 bodypartOffset;

    


	// Use this for initialization
	void Start () {
	
	}

    void InitBody(Vector2 newOffset, Material newMaterial)
    {
        bodypartOffset = newOffset;
        bodypartMaterial = newMaterial;
        ApplyOwnMaterialToBase();
    }


    void ApplyOwnMaterialToBase()
    {
        this.GetComponent<Renderer>().material = bodypartMaterial;
    }

	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

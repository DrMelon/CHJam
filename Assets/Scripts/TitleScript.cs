using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {

    public bool Tweening;
    public bool Flashing;
    public bool Done;

    public GameObject LeftPerson;
    public GameObject RightPerson;
    public GameObject dimmer;

	// Use this for initialization
	void Start ()
    {
        Global.theTitle = this; //set self

	}

    void TweenOn()
    {
        Tweening = true;
        // stop anim of right
        RightPerson.GetComponent<Animator>().Stop();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TweenOn();
        }
	    if(Tweening)
        {
            //move left player to -0.5
            if (LeftPerson.transform.localPosition.x < -0.5f)
            {
                LeftPerson.transform.localPosition = LeftPerson.transform.localPosition + new Vector3(0.1f, 0.0f, 0.0f);
            }

            // move right to 1.0
            if (RightPerson.transform.localPosition.x > 1.0f)
            {
                RightPerson.transform.localPosition = RightPerson.transform.localPosition - new Vector3(0.1f, 0.0f, 0.0f);
            }
            else
            {
                Flashing = true;
            }
        }
        if(Flashing)
        {
            if (dimmer)
            {
                if (dimmer.GetComponent<Renderer>().material.color.a < 1.0f)
                {
                    dimmer.GetComponent<Renderer>().material.color = dimmer.GetComponent<Renderer>().material.color + new Color(0, 0, 0, 0.02f);
                }
                else
                {
                    Done = true;
                }
            }
        }
        if (Done)
        {
            // Advance to new scene
            Application.LoadLevel(1);
        }

	}
}

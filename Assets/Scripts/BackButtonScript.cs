using UnityEngine;
using System.Collections;

public class BackButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);
            print("click");
            print(hitCollider);
            print(Global.theMatchmaker.CurrentlyMatchmaking);
            print(this.GetComponent<Collider2D>());
            if (hitCollider && Global.theMatchmaker.CurrentlyMatchmaking)
            {
                if (hitCollider.GetComponent<Collider2D>() == this.GetComponent<Collider2D>())
                {
                    // Step 2, tell matchmaker what's happened.
                    Global.theMatchmaker.StopMatchmaking();
                    print("AAAGGHH");
                }

            }
        }
    }
}

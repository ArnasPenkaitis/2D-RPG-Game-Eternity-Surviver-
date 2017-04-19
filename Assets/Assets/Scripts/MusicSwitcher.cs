using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour {

    private MusicCTRL theMC;
    public int newTrack;
    public bool switchOnStart;
	// Use this for initialization
	void Start () {
        theMC = FindObjectOfType<MusicCTRL>();
        if(switchOnStart==true)
        {
            theMC.SwitchTrack(newTrack);
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player")
        {
            theMC.SwitchTrack(newTrack);
            gameObject.SetActive(false);
        }
    }
}

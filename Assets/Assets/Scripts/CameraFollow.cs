using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    Camera mycam;
    public BoxCollider2D ribos;
    private Vector3 minRibos;
    private Vector3 maxRibos;
    private float halfHeight;
    private float halfWidth;
	// Use this for initialization
	void Start () {
        minRibos = ribos.bounds.min;
        maxRibos = ribos.bounds.max;
        
        mycam = GetComponent<Camera>();
        mycam.orthographicSize = (Screen.height / 100f) / 4f;
        halfHeight = mycam.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;}

    // Update is called once per frame
    void Update () {

        
            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0, 0, -10);

        if(target.position.x>maxRibos.x||target.position.y>maxRibos.y||target.position.x<minRibos.x||target.position.y<minRibos.y)
        {
            ribos = FindObjectOfType<RibuNustatymas>().GetComponent<BoxCollider2D>();
            minRibos = ribos.bounds.min;
            maxRibos = ribos.bounds.max;
        }


            float clampedX = Mathf.Clamp(transform.position.x, minRibos.x + halfWidth, maxRibos.x - halfWidth);
            float clampedY = Mathf.Clamp(transform.position.y, minRibos.y + halfHeight, maxRibos.y - halfHeight);

            transform.position = new Vector3(clampedX, clampedY, transform.position.z);


        
    }

    public void NustatykRibas(BoxCollider2D naujosRibos)
    {
        ribos = naujosRibos;
        minRibos = ribos.bounds.min;
        maxRibos = ribos.bounds.max;
    }
  
}

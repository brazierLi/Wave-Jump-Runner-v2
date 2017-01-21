using UnityEngine;
using System.Collections;

public class Camer_Controller : MonoBehaviour {

    public float yOffset = 5, zOffset = -10,xOffSEt = 0.6f;
    GameObject Player;
    void Start() {
        Player = GameObject.Find("Player");
    }


	
	// Update is called once per frame
	void Update () {
       GetComponent<Rigidbody2D>().velocity = Player.transform.position - transform.position + new Vector3(Player.GetComponent<Rigidbody2D>().velocity.x*xOffSEt, yOffset, zOffset); ;
    }
}

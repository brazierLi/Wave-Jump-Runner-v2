using UnityEngine;
using System.Collections;

public class MoveCloser : MonoBehaviour {

    Player_Controller Player;

    public string MoveCloserTag = "Damage";
    public float RegularSpeed = 5,dist4OutOfRange = 15,outOfRange = 11, AddSpeed = 5;
    float currentAddSpeed = 0;

    Camera c;
    private void Start()
    {
        c = GameObject.Find("Main Camera").GetComponent<Camera>();
        dist4OutOfRange = -c.ScreenToWorldPoint(new Vector3(0, 0)).x;   
    }


    void FixedUpdate () {
        currentAddSpeed = 0f;
        Player = GameObject.Find("Player").GetComponent<Player_Controller>();
        float dis = c.ScreenToWorldPoint(new Vector3(0, 0)).x - Player.gameObject.transform.position.x;
        dist4OutOfRange = dis > 0 ? dis : -dis;
        if (Player.CurrentHitTag == MoveCloserTag)
        {
            currentAddSpeed += AddSpeed;
        }
        if (Vector3.Distance( GameObject.Find("Player").transform.position, transform.position) > dist4OutOfRange)
        {
            currentAddSpeed += outOfRange;
        }
        else {
            currentAddSpeed += RegularSpeed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(RegularSpeed + currentAddSpeed, 0);
	}
}

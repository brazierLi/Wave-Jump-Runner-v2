using UnityEngine;
using System.Collections;

public class Despawn : MonoBehaviour {

    public byte DecAlpha = 1;
    byte alpha = 150;
    public float FPS = 10;

    void Start() {
        GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, alpha);
        StartCoroutine(FixedUpdate());
    }
	// Update is called once per frame
	IEnumerator FixedUpdate () {
        while (true)
        {
            alpha -= DecAlpha;
            GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, alpha);
            if (alpha <= 5)
            {
                Destroy(gameObject);
            }
            yield return 1000 / FPS;
        }
	}
}

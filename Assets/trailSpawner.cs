using UnityEngine;
using UnityEditor;
using System.Collections;

public class trailSpawner : MonoBehaviour {

    public float SpawnFPS = 4,otherFPS= 80;
    public int Amount = 61;
    public Sprite[] Sprites;
    public GameObject SpiteEmp;
    int frame;
    // Use this for initialization
    void Start() {

        StartCoroutine(Loop());
        StartCoroutine(Loop2());


    }
    IEnumerator Loop() {
        while (true)
        {
            GameObject g = (GameObject)Instantiate(SpiteEmp, transform.position, Quaternion.identity);
            g.GetComponent<SpriteRenderer>().sprite = Sprites[frame % Amount];
            g.transform.localScale *= 0.5f;
            yield return new WaitForSecondsRealtime(1/ SpawnFPS);
        }
    }
    IEnumerator Loop2()
    {
        transform.localScale *= 0.5f;
        while (true)
        {
            GetComponent<SpriteRenderer>().sprite = Sprites[frame % Amount];
            yield return new WaitForSecondsRealtime(1 / otherFPS);
            frame++;
        }
    }
}

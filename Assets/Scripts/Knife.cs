using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody knife;
    private bool onWood;
    private int count;

    private KnifeSpwaner KnifeSpawner;
    void Awake()
    {
        knife = GetComponent<Rigidbody>();
        KnifeSpawner = GameObject.Find("KnifeSpawner").GetComponent<KnifeSpwaner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !onWood)
        {
            knife.velocity = new Vector3(0f, speed, 0f);
        }
        if (count > 10)
        {
            Wood.instance.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Wood")
        {
            count++;
            gameObject.transform.SetParent(target.transform);
            knife.velocity = Vector3.zero;
            onWood = true;
            knife.detectCollisions = false;

            KnifeSpawner.SpawnKnife();
            KnifeSpawner.IncrementScore();
        }
        if (target.tag == "Knife")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }

    }


}

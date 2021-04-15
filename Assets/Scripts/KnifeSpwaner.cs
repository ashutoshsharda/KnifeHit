using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeSpwaner : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject KnifePrefab;

    private Text scoreText;
    private int score;

    void Awake()
    {
        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
    }


    public void SpawnKnife()
    {
        GameObject Go = Instantiate(KnifePrefab, spawnPoint.position, spawnPoint.rotation);
        Go.transform.parent = spawnPoint;
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuShards : MonoBehaviour
{
    private Image shardImg;
    public Sprite[] shards;

    void Start()
    {
        shardImg = GetComponent<Image>();
    }

    public void randomShard()
    {
        //int randomNum = Random.Range(0, shards.Length);
        //shardImg.sprite = shards[randomNum];

        //print(shards[randomNum]);
    }
}

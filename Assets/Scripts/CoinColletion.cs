using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CoinColletion : MonoBehaviour
{
    public GameObject coinPrefab;
    public TMP_Text Score;

    public float coinScore;

    public void OnTriggerEnter(Collider col)
    {
        coinScore = coinScore + 1;
        //col.gameObject.SetActive(false); 
        Destroy(col.gameObject);
        Score.text = coinScore.ToString();
    }


}

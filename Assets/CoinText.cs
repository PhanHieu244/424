using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    public TextMesh textMesh;
    public GameObject a;

    private void OnMouseDown()
    {
        a.SetActive(true);
    }

    private void Update()
    {
        textMesh.text = "Coins: " + PlayerPrefs.GetInt("PlayerMoney", 0).ToString();
    }
}

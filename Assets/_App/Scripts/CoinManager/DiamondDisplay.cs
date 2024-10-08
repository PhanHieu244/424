using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondDisplay : MonoBehaviour
{
   public TextMeshProUGUI diamondTmp;

   void OnValidated()
   {
      diamondTmp = GetComponent<TextMeshProUGUI>();
   }


   private void Update()
   {
      diamondTmp.SetText("Coins: " + PlayerPrefs.GetInt("PlayerMoney", 0).ToString());
   }
}

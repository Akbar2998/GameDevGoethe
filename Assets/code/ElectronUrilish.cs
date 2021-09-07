using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using System;

public class ElectronUrilish : MonoBehaviour
{
    public GameObject Player;
    public int urilish;
    public int urilgan_sonlari;
    public Text Scoreholder;
    void Start()
    {
      
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "uzunlik")
        {
            urilish += 1;
        }
    }
    void Update() {
        urilgan_sonlari = ((urilish - 1) / 2);
        Scoreholder.text = urilgan_sonlari.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hunger_UI : MonoBehaviour
{
    Text hunger_text;
    private void Start()
    {
        hunger_text = GetComponent<Text>();

    }
    private void Update()
    {
        hunger_text.text = PlayerStat.instance.Hunger_UI().ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thirst_UI : MonoBehaviour
{
    Text thirst_text;
    private void Start()
    {
        thirst_text = GetComponent<Text>();

    }
    private void Update()
    {
        thirst_text.text = PlayerStat.instance.Thirst_UI().ToString(); 
    }
}

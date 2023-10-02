using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isPlayer = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogManager.instance.HideDialog();
            isPlayer = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isPlayer) {
            DialogManager.instance.ShowDialog(DialogManager.instance.item_d1); 
        }
    }
}

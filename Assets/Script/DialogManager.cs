using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public static DialogManager instance { get; set; }
    [SerializeField] private GameObject chatbox;
    [SerializeField] public GameObject item_d1;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);

        }
        else { instance = this; }
    }
    
    public void ShowDialog(GameObject chat)
    {
        chatbox.SetActive(true);
        chat.SetActive(true);    

    }
    public void HideDialog()
    {
        chatbox.SetActive(false);

    }
}

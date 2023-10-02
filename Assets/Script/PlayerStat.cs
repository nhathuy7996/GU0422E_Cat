using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class PlayerStat : MonoBehaviour
{
    public static PlayerStat instance {  get; set; }
    [SerializeField] private float hunger;
    [SerializeField] private float thirst;
    float hungertimer;
    float thirsttimer;
    private void Awake()
    {
        if (instance != null&& instance != this)
        
            Destroy(gameObject);
            else 
            instance = this;
        
    }
    private void Start()
    {
        hunger = thirst = 100;

    }
    private void Update()
    {
        hungertimer += Time.deltaTime;
        thirsttimer += Time.deltaTime;
        if (hunger > 100)
        {
            hunger = 100;
        }
        if (thirst > 100)
        {
            thirst = 100;
        }

        if (hungertimer > 5f) 
        {
            Hungry();
        }
        if (thirsttimer > 10f)
        {
            Thirsty();
        }
    }
    public void Hungry()
    {
        hunger = hunger - 5f;
        hungertimer = 0;

    }
    public void Eat (float point)
    {
        hunger = hunger + point;
    }
    public void Thirsty() 
    {
        thirst = thirst - 10f;
        thirsttimer = 0;
    }
    public void Drink(float point)
    {
        thirst = thirst + point;
    }
    public float Hunger_UI()
    {
        return hunger;
    }
    public float Thirst_UI()
    {
        return thirst;
    }
}


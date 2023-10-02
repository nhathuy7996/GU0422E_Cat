using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{

    public static BossTrigger Instant;

    float timer;
    public GameObject boss;
    public GameObject blackLight;
    public float lightcooldown = 0;
    public float nightcooldown = 0;
    public float nighttime;
    public float lighttime;
    public bool bossStart = false;
    bool lights = true;

    private void Awake()
    {
        Instant = this;
    }

    private void Update()
    {
        timer += Time.deltaTime;

       

        if (bossStart)
        {
            if (lights)
            {
                lightcooldown += Time.deltaTime;
                if (lightcooldown > lighttime)
                {
                    blackLight.SetActive(true);
                    lightcooldown = 0;
                    lights = false;
                    lighttime = lighttime - 2f;
                }
            }
            if (!lights)
            {
                nightcooldown += Time.deltaTime;
                if (nightcooldown > nighttime)
                {
                    blackLight.SetActive(false);
                    nightcooldown = 0;
                    lights = true;
                    
                }
            }
            if (lighttime < 2f)
                lighttime = 0.5f;
            

        }
    }
    
}

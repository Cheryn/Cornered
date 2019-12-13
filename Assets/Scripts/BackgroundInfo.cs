using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundInfo : MonoBehaviour
{
    public float offset_coeff = 0.4f;
    public float tether_length = 40.0f;
    public float energy = 100.0f;
    public GameObject player1;
    public GameObject player2;
    public GameObject shield;
    public Text myText;
    public float shield_start;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myText.text = "Energy: " + energy.ToString();

        if (Input.GetKey("."))
        {
            shield_start = Time.time;
            shield.SetActive(true);
            shield.transform.position = player1.transform.position;
            if (Time.time - shield_start > 1){
                energy -= 1;
            }
                
        }
        else if (Input.GetKey("z"))
        {
            shield_start = Time.time;
            shield.SetActive(true);
            shield.transform.position = player2.transform.position;
            if (Time.time - shield_start > 1)
            {
                energy -= 1;
            }
        }
        else { shield.SetActive(false); }


        




    }
}

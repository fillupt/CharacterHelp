using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRandomSuitOnStart : MonoBehaviour
{

    public GameObject[] suits;
    // Start is called before the first frame update
    void Start()
    {
        // get list of suits that are children
        suits = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            suits[i] = transform.GetChild(i).gameObject;
        }
        // randomly pick one and enable it
        int randomIndex = Random.Range(0, suits.Length);
        suits[randomIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Change suits on keypress R
        if (Input.GetKeyDown(KeyCode.R))
        {
            // disable all suits
            foreach (GameObject suit in suits)
            {
                suit.SetActive(false);
            }
            // randomly pick one and enable it
            int randomIndex = Random.Range(0, suits.Length);
            suits[randomIndex].SetActive(true);
        }
    }
}

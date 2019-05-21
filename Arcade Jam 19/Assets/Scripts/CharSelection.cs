using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelection : MonoBehaviour
{
    public GameObject[] playerFields;
    public GameObject[] hintFields;

    private bool player1;
    private bool player2;
    private bool player3;
    private bool player4;

    void Start()
    {
        foreach(GameObject go in playerFields)
        {
            go.SetActive(false);
        }

        foreach (GameObject go in hintFields)
        {
            go.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.A) && player1 == false)
        {
            hintFields[0].SetActive(false);
            playerFields[0].SetActive(true);

            player1 = true;
        }
        if (Input.GetKeyDown(KeyCode.B) && player2 == false)
        {
            hintFields[1].SetActive(false);
            playerFields[1].SetActive(true);

            player2 = true;
        }
        if (Input.GetKeyDown(KeyCode.C) && player3 == false)
        {
            hintFields[2].SetActive(false);
            playerFields[2].SetActive(true);

            player3 = true;
        }
        if (Input.GetKeyDown(KeyCode.D) && player4 == false)
        {
            hintFields[3].SetActive(false);
            playerFields[3].SetActive(true);

            player4 = true;
        }
    }
}

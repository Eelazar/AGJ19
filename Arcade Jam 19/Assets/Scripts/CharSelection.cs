using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelection : MonoBehaviour
{
    public GameObject[] playerFields;
    public GameObject[] hintFields;

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
        if (Input.GetKeyDown(KeyCode.A) && Static.player1 == false)
        {
            hintFields[0].SetActive(false);
            playerFields[0].SetActive(true);

            Static.player1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && Static.player1 == true)
        {
            hintFields[0].SetActive(true);
            playerFields[0].SetActive(false);

            Static.player1 = false;
        }

        if (Input.GetKeyDown(KeyCode.B) && Static.player2 == false)
        {
            hintFields[1].SetActive(false);
            playerFields[1].SetActive(true);

            Static.player2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.B) && Static.player2 == true)
        {
            hintFields[1].SetActive(true);
            playerFields[1].SetActive(false);

            Static.player2 = false;
        }

        if (Input.GetKeyDown(KeyCode.C) && Static.player3 == false)
        {
            hintFields[2].SetActive(false);
            playerFields[2].SetActive(true);

            Static.player3 = true;
        }
        else if (Input.GetKeyDown(KeyCode.C) && Static.player3 == true)
        {
            hintFields[2].SetActive(true);
            playerFields[2].SetActive(false);

            Static.player3 = false;
        }

        if (Input.GetKeyDown(KeyCode.D) && Static.player4 == false)
        {
            hintFields[3].SetActive(false);
            playerFields[3].SetActive(true);

            Static.player4 = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && Static.player4 == true)
        {
            hintFields[3].SetActive(true);
            playerFields[3].SetActive(false);

            Static.player4 = false;
        }
    }
}

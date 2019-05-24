using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharSelection : MonoBehaviour
{
    public GameObject[] playerFields;
    public GameObject[] hintFields;

    public string[] levels;

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

        Static.player1 = false;
        Static.player2 = false;
        Static.player3 = false;
        Static.player4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(levels[Random.Range(0, levels.Length - 1)]);
        }

        if (Input.GetKeyDown(KeyCode.G) && Static.player1 == false)
        {
            hintFields[0].SetActive(false);
            playerFields[0].SetActive(true);

            Static.player1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.G) && Static.player1 == true)
        {
            hintFields[0].SetActive(true);
            playerFields[0].SetActive(false);

            Static.player1 = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && Static.player2 == false)
        {
            hintFields[1].SetActive(false);
            playerFields[1].SetActive(true);

            Static.player2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && Static.player2 == true)
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

        if (Input.GetKeyDown(KeyCode.Keypad1) && Static.player4 == false)
        {
            hintFields[3].SetActive(false);
            playerFields[3].SetActive(true);

            Static.player4 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1) && Static.player4 == true)
        {
            hintFields[3].SetActive(true);
            playerFields[3].SetActive(false);

            Static.player4 = false;
        }
    }
}

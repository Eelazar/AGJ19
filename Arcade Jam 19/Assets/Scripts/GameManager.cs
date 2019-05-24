using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    public Transform[] spawnPositions;

    private List<GameObject> players;

    void Start()
    {
        players = new List<GameObject>();

        Initialize();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("CharSelection");
        }
    }

    void CheckPlayerStatus()
    {
        int alive = 0;

        foreach(GameObject p in players)
        {
            //if(p.alive == true)
            //{
            //    alive++;
            //}
        }

        if(alive < 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void Initialize()
    {
        if (Static.player1)
        {
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefabs[0], spawnPositions[0].position, playerPrefabs[0].transform.rotation);

            players.Add(p);
        }
        if (Static.player2)
        {
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefabs[1], spawnPositions[1].position, playerPrefabs[1].transform.rotation);

            players.Add(p);
        }
        if (Static.player3)
        {
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefabs[2], spawnPositions[2].position, playerPrefabs[2].transform.rotation);

            players.Add(p);
        }
        if (Static.player4)
        {
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefabs[3], spawnPositions[3].position, playerPrefabs[3].transform.rotation);

            players.Add(p);
        }
    }
}

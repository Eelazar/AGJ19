using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform[] spawnPositions;

    private List<GameObject> players;

    void Start()
    {
        players = new List<GameObject>();

        Initialize();
    }

    void Update()
    {
        
    }

    void CheckPlayerStatus()
    {
        int alive = 0;

        foreach(GameObject p in players)
        {
            if(p.alive == true)
            {
                alive++;
            }
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
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefab, spawnPositions[0].position, playerPrefab.transform.rotation);

            p.playerID = 1;

            players.Add(p);
        }
        if (Static.player2)
        {
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefab, spawnPositions[1].position, playerPrefab.transform.rotation);

            p.playerID = 2;

            players.Add(p);
        }
        if (Static.player3)
        {
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefab, spawnPositions[2].position, playerPrefab.transform.rotation);

            p.playerID = 3;

            players.Add(p);
        }
        if (Static.player4)
        {
            GameObject p = GameObject.Instantiate<GameObject>(playerPrefab, spawnPositions[3].position, playerPrefab.transform.rotation);

            p.playerID = 4;

            players.Add(p);
        }
    }
}

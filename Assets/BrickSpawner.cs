using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public int rows;
    public int columns;
    public GameObject brickPrefab;
    public float offset = 0.1f;

    private List<GameObject> bricks = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ResetLevel()
    {
        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab.transform.localScale.x + offset),
                    -j * (brickPrefab.transform.localScale.y + offset));
                GameObject brick = Instantiate(brickPrefab, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }

}

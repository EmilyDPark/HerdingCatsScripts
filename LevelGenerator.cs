using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject cat;

    public int numberOfCats;

    public GameObject terrain;

    private BoxCollider2D col;

    private List<Vector2> usedPoints;

    // Start is called before the first frame update
    void Start()
    {
        usedPoints = new List<Vector2>();
        col = terrain.GetComponent<BoxCollider2D>();
        GenerateObjects();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateObject(GameObject go, int amount)
    {
        if (go == null) return;

        for (int i = 0; i < amount; i++)
        {
            GameObject tmp = Instantiate(go);
            Vector2 randomPoint = GetRandomPoint();
            usedPoints.Add(randomPoint);
            tmp.gameObject.transform.position = new Vector2(randomPoint.x, randomPoint.y);
            tmp.gameObject.transform.Rotate(0.0f, 0.0f, Random.Range(0.0f, 360.0f));
        }
    }

    void GenerateObjects()
    {
        GenerateObject(cat, numberOfCats);
    }

    Vector2 GetRandomPoint()
    {
        int xRandom = 0;
        int yRandom = 0;

        xRandom = (int)Random.Range(col.bounds.min.x, col.bounds.max.x);
        yRandom = (int)Random.Range(col.bounds.min.y, col.bounds.max.y);

        Vector2 tmpVector = new Vector2(xRandom, yRandom);

        if (usedPoints.Contains(tmpVector))
        {
            return GetRandomPoint();
        }

        return tmpVector;
    }
}

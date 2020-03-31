using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatGenerator : MonoBehaviour
{
    #region Cat Variables

    //public GameObject cat;
    //public int numberOfCats;
    public GameObject sky;
    public int numberOfSky;
    public GameObject everest;
    public int numberOfEverest;
    public GameObject cat1;
    public int numberOfCat1;
    public GameObject cat2;
    public int numberOfCat2;
    public GameObject cat3;
    public int numberOfCat3;
    public GameObject cat4;
    public int numberOfCat4;
    public GameObject cat6;
    public int numberOfCat6;
    public GameObject cat7;
    public int numberOfCat7;
    public GameObject cat8;
    public int numberOfCat8;
    public GameObject cat9;
    public int numberOfCat9;
    public GameObject cat10;
    public int numberOfCat10;
    public GameObject cat11;
    public int numberOfCat11;
    public GameObject cat12;
    public int numberOfCat12;
    public GameObject cat13;
    public int numberOfCat13;
    public GameObject cat14;
    public int numberOfCat14;
    public GameObject cat15;
    public int numberOfCat15;
    public GameObject cat16;
    public int numberOfCat16;
    public GameObject cat17;
    public int numberOfCat17;
    public GameObject cat18;
    public int numberOfCat18;
    public GameObject cat19;
    public int numberOfCat19;
    public GameObject cat20;
    public int numberOfCat20;
    public GameObject cat21;
    public int numberOfCat21;

    #endregion

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
        //GenerateObject(cat, numberOfCats);
        GenerateObject(sky, numberOfSky);
        GenerateObject(everest, numberOfEverest);
        GenerateObject(cat1, numberOfCat1);
        GenerateObject(cat2, numberOfCat2);
        GenerateObject(cat3, numberOfCat3);
        GenerateObject(cat4, numberOfCat4);
        GenerateObject(cat6, numberOfCat6);
        GenerateObject(cat7, numberOfCat7);
        GenerateObject(cat8, numberOfCat8);
        GenerateObject(cat9, numberOfCat9);
        GenerateObject(cat10, numberOfCat10);
        GenerateObject(cat11, numberOfCat11);
        GenerateObject(cat12, numberOfCat12);
        GenerateObject(cat13, numberOfCat13);
        GenerateObject(cat14, numberOfCat14);
        GenerateObject(cat15, numberOfCat15);
        GenerateObject(cat16, numberOfCat16);
        GenerateObject(cat17, numberOfCat17);
        GenerateObject(cat18, numberOfCat18);
        GenerateObject(cat19, numberOfCat19);
        GenerateObject(cat20, numberOfCat20);
        GenerateObject(cat21, numberOfCat21);
    }

    Vector2 GetRandomPoint()
    {
        int xRandom = 0;
        int yRandom = 0;

        xRandom = (int)Random.Range(col.bounds.min.x + 0.5f, col.bounds.max.x - 0.5f);
        yRandom = (int)Random.Range(col.bounds.min.y + 0.5f, col.bounds.max.y - 0.5f);

        Vector2 tmpVector = new Vector2(xRandom, yRandom);

        if (usedPoints.Contains(tmpVector))
        {
            return GetRandomPoint();
        }

        return tmpVector;
    }
}

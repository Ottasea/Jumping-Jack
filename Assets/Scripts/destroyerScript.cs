using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerScript : MonoBehaviour
{
    public GameObject player;
    public GameObject greenLeaf;
    public GameObject brownLeaf;
    public GameObject stripedLeaf;
    public GameObject eggLeaf;
    public GameObject yellowLeaf;
    public GameObject stripedClone;
    public float leafDistance = 8f;
    public float minY = 0.2f;
    public float maxY = 0.5f;
    public float minX;
    public float maxX;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("gLeaf"))

        {
            if (Random.Range(1, 10) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(stripedLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
            }
            else if (Random.Range(1, 7) == 2)
            {
                Destroy(collision.gameObject);
                Instantiate(brownLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
            }

            else if (Random.Range(1, 7) == 3)
            {
                Destroy(collision.gameObject);
                Instantiate(eggLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
            }

            else if (Random.Range(1, 40) == 4)
            {
                Destroy(collision.gameObject);
                Instantiate(yellowLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
            }

            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY)));
            }
        }
        else if (collision.gameObject.name.StartsWith("sLeaf"))
        {
            if (Random.Range(1, 10) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(greenLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
            }
        }
        else if (collision.gameObject.name.StartsWith("bLeaf"))
        {
            if (Random.Range(1, 7) == 2)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY)));
            }

            else
            {
                Destroy(collision.gameObject);

                Instantiate(greenLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
            }
        }

        else if (collision.gameObject.name.StartsWith("eggLeaf"))
        {
            if (Random.Range(1, 7) == 3)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY)));
            }

            else
            {
                Destroy(collision.gameObject);

                Instantiate(greenLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
            }
        }

        else if (collision.gameObject.name.StartsWith("yLeaf"))
        {
                Destroy(collision.gameObject);

                Instantiate(greenLeaf, new Vector2(Random.Range(minX, maxX), transform.position.y + (leafDistance + Random.Range(minY, maxY))), Quaternion.identity);
        }

        else if (collision.gameObject.name.StartsWith("stripedClone"))
        {
            Destroy(collision.gameObject);
        }
    }
}

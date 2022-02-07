using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer cent01;
    [SerializeField]
    SpriteRenderer cent02;
    [SerializeField]
    SpriteRenderer cent05;
    [SerializeField]
    SpriteRenderer cent10;
    [SerializeField]
    SpriteRenderer cent20;
    [SerializeField]
    SpriteRenderer cent50;
    [SerializeField]
    SpriteRenderer euro1;
    [SerializeField]
    SpriteRenderer euro2;

    GameObject[] cent01Object;
    GameObject[] cent02Object;
    GameObject[] cent05Object;
    GameObject[] cent10Object;
    GameObject[] cent20Object;
    GameObject[] cent50Object;
    GameObject[] euro1Object;
    GameObject[] euro2Object;

    public int totalCoins;

    public double currentTotal = 0;
    public int total = 0;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(total != 1000)
        {
            CoinGenerator();
        }
    }


    private void OnMouseDown()
    {
        if (gameObject.CompareTag("cent01"))
        {
            gameManager.CurrentAmountPerRound(0.01);
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("cent02"))
        {
            gameManager.CurrentAmountPerRound(0.02);
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("cent05"))
        {
            gameManager.CurrentAmountPerRound(0.05);
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("cent10"))
        {
            gameManager.CurrentAmountPerRound(0.1);
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("cent20"))
        {
            gameManager.CurrentAmountPerRound(0.2);
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("cent50"))
        {
            gameManager.CurrentAmountPerRound(0.5);
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("euro1"))
        {
            gameManager.CurrentAmountPerRound(1);
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("euro2"))
        {
            gameManager.CurrentAmountPerRound(2);
            Destroy(gameObject);
        }
    }

    public void CoinGenerator()
    {
        if (!gameManager.isGameActive) return;
        while (total < 1000)
        {
            if (total == 0) totalCoins = 0;
            int rand = Random.Range(0, 8);
            switch (rand)
            {
                case 0:
                    if (total > 999) return;
                    else
                    {
                        total += 1;
                        if (totalCoins <= 6)
                        {
                            Instantiate(cent01).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(cent01).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(cent01).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
                case 1:
                    if (total > 998) return;
                    else
                    {
                        total += 2;
                        if (totalCoins <= 6)
                        {
                            Instantiate(cent02).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(cent02).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(cent02).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
                case 2:
                    if (total > 995) return;
                    else
                    {
                        total += 5;
                        if (totalCoins <= 6)
                        {
                            Instantiate(cent05).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(cent05).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(cent05).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
                case 3:
                    if (total > 990) return;
                    else
                    {
                        total += 10;
                        if (totalCoins <= 6)
                        {
                            Instantiate(cent10).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(cent10).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(cent10).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
                case 4:
                    if (total > 980) return;
                    else
                    {
                        total += 20;
                        if (totalCoins <= 6)
                        {
                            Instantiate(cent20).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(cent20).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(cent20).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
                case 5:
                    if (total > 950) return;
                    else
                    {
                        total += 50;
                        if (totalCoins <= 6)
                        {
                            Instantiate(cent50).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(cent50).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(cent50).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
                case 6:
                    if (total > 900) return;
                    else
                    {
                        total += 100;
                        if (totalCoins <= 6)
                        {
                            Instantiate(euro1).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(euro1).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(euro1).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
                case 7:
                    if (total > 800) return;
                    else
                    {
                        total += 200;
                        if (totalCoins <= 6)
                        {
                            Instantiate(euro2).transform.position = new Vector2(-3 + totalCoins, -1);
                            this.totalCoins++;
                        }
                        else if (totalCoins > 6 && totalCoins <= 13)
                        {
                            Instantiate(euro2).transform.position = new Vector2(-10 + totalCoins, -2);
                            this.totalCoins++;
                        }
                        else
                        {
                            Instantiate(euro2).transform.position = new Vector2(-16 + totalCoins, -3);
                            this.totalCoins++;
                        }
                    }
                    break;
            }
            totalCoins++;
            if (this.totalCoins > 20)
            {
                cent01Object = GameObject.FindGameObjectsWithTag("cent01");
                cent02Object = GameObject.FindGameObjectsWithTag("cent02");
                cent05Object = GameObject.FindGameObjectsWithTag("cent05");
                cent10Object = GameObject.FindGameObjectsWithTag("cent10");
                cent20Object = GameObject.FindGameObjectsWithTag("cent20");
                cent50Object = GameObject.FindGameObjectsWithTag("cent50");
                euro1Object = GameObject.FindGameObjectsWithTag("euro1");
                euro2Object = GameObject.FindGameObjectsWithTag("euro2");
                foreach (GameObject cents01 in cent01Object)
                {
                    Destroy(cents01);
                }
                foreach (GameObject cents02 in cent02Object)
                {
                    Destroy(cents02);
                }
                foreach (GameObject cents05 in cent05Object)
                {
                    Destroy(cents05);
                }
                foreach (GameObject cents10 in cent10Object)
                {
                    Destroy(cents10);
                }
                foreach (GameObject cents20 in cent20Object)
                {
                    Destroy(cents20);
                }
                foreach (GameObject cents50 in cent50Object)
                {
                    Destroy(cents50);
                }
                foreach (GameObject euros1 in euro1Object)
                {
                    Destroy(euros1);
                }
                foreach (GameObject euros2 in euro2Object)
                {
                    Destroy(euros2);
                }
                total = 0;
            }
        }
    }
}

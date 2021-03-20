using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;

    [Header("Prefabs")]
    public GameObject newsPrefab;
    public GameObject congressPrefab;
    public GameObject sponsorPrefab;

    [Header("Parent Transforms")]
    public Transform newsPanel;
    public Transform congressPanel;
    public Transform sponsorPanel;

    [Header("Descriptions")]
    public GameObject description;

    void Start()
    {
        instance = this;
    }

    public void Add(CardText data, int type)
    {
        GameObject card;
        
        switch (type)
        {
            case 1:
                card = Instantiate(newsPrefab, newsPanel);
                break;

            case 2:
                card = Instantiate(congressPrefab, congressPanel);
                break;

            case 3:
                card = Instantiate(sponsorPrefab, sponsorPanel);
                break;

            default:
                card = Instantiate(newsPrefab, newsPanel);
                break;
        }
        Card properties = card.GetComponent<Card>();
        properties.SetData(data);
    }

    public void OpenDescription(Card cardToOpen)
    {
        description.SetActive(true);
        description.GetComponent<Descriptions>().Open(cardToOpen);
    }
}

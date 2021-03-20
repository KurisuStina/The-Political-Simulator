using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Descriptions : MonoBehaviour
{
    private Card card;

    public TextMeshProUGUI text;

    public GameObject newsOptions;
    public GameObject congressOptions;
    public GameObject sponsorOptions;

    public void Open(Card cardToOpen)
    {
        card = cardToOpen;
        text.text = card.text.text;
        if (card.acted)
        {
            newsOptions.SetActive(false);
            congressOptions.SetActive(false);
            sponsorOptions.SetActive(false);
        }
        else
        {
            if(card is NewsCard)
            {
                newsOptions.SetActive(true);
                congressOptions.SetActive(false);
                sponsorOptions.SetActive(false);
            }
            else if(card is CongressCard)
            {
                newsOptions.SetActive(false);
                congressOptions.SetActive(true);
                sponsorOptions.SetActive(false);
            }
            else if (card is SponsorCard)
            {
                newsOptions.SetActive(false);
                congressOptions.SetActive(false);
                sponsorOptions.SetActive(true);
            }
        }
    }

    public void Back()
    {
        gameObject.SetActive(false);
    }

    public void Remove()
    {
        gameObject.SetActive(false);
        Destroy(card.gameObject);
    }

    public void Accept()
    {
        card.Accept();
    }
    public void Decline()
    {
        card.Decline();
    }
}

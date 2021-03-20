using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class CardText
{
    public string text;

    public bool p_popular;
    public bool c_popular;
}

public class Card : MonoBehaviour
{
    public TextMeshProUGUI text;

    public bool acted = false;

    protected CardText data;


    public void SetData(CardText cardData)
    {
        data = cardData;
        text.text = cardData.text;
    }

    public void OpenDescription()
    {
        CardManager.instance.OpenDescription(this);
    }

    public virtual void Accept()
    {
        Debug.Log("Accepted");
    }

    public virtual void Decline()
    {
        Debug.Log("Declined");
    }
}

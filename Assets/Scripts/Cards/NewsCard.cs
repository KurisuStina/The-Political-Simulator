using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewsCard : Card
{
    [SerializeField] private Image notification;
    public bool read;

    private int value = 2;
    private int f_value = 10000000;

    void Start()
    {
        read = false;
    }

    public void Read()
    {
        read = true;
        notification.enabled = false;
    }

    public override void Accept()
    {
        if (data.p_popular && data.c_popular)
        {
            GameManager.approvalRating += value;
            GameManager.funds += f_value;
        }
        else if (!data.p_popular && data.c_popular)
        {
            GameManager.approvalRating -= value;
            GameManager.funds += f_value;
        }
        else if (data.p_popular && !data.c_popular)
        {
            GameManager.approvalRating += value;
            GameManager.funds -= f_value;
        }
        else
        {
            GameManager.approvalRating -= value;
            GameManager.funds -= f_value;
        }
    }

    public override void Decline()
    {
        if (data.p_popular && data.c_popular)
        {
            GameManager.approvalRating -= value;
            GameManager.funds -= f_value;
        }
        else if (!data.p_popular && data.c_popular)
        {
            GameManager.approvalRating += value;
            GameManager.funds -= f_value;
        }
        else if (data.p_popular && !data.c_popular)
        {
            GameManager.approvalRating -= value;
            GameManager.funds += f_value;
        }
        else
        {
            GameManager.approvalRating += value;
            GameManager.funds += f_value;
        }
    }
}

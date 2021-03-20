using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongressCard : Card
{
    private int value = 5;
    private int f_value = 10000000;

    public override void Accept()
    {
        if (data.p_popular && data.c_popular)
        {
            GameManager.approvalRating += value;
            GameManager.funds += value;
        }
        else if (!data.p_popular && data.c_popular)
        {
            GameManager.approvalRating -= value;
            GameManager.funds += value;
        }
        else if (data.p_popular && !data.c_popular)
        {
            GameManager.approvalRating += value;
            GameManager.funds -= value;
        }
        else
        {
            GameManager.approvalRating -= value;
            GameManager.funds -= value;
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

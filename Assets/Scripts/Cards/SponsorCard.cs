using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SponsorCard : Card
{
    private int value = 1;
    private int f_value = 10000000;

    public override void Accept()
    {
        GameManager.approvalRating -= value;
        GameManager.funds += f_value;
    }

    public override void Decline()
    {
        GameManager.approvalRating += value;
        GameManager.funds -= f_value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public const float timeVariation = 0.4f;

    [Header("Stats")]
    public TextMeshProUGUI ar_text;
    public TextMeshProUGUI f_text;
    public static int approvalRating = 50;
    public static int funds = 50000000;

    [Header("News")]
    public List<CardText> news;
    public float baseNewsInterval = 15f;
    private float newsTimer;

    [Header("Congress")]
    public List<CardText> votes;
    public float baseCongressInterval = 60f;
    private float voteTimer;


    [Header("Sponsorships")]
    public List<CardText> corporations;
    public float baseSponsorInterval = 30f;
    private float sponsorTimer;

    void Update()
    {
        #region Timer
        newsTimer += Time.deltaTime;
        voteTimer += Time.deltaTime;
        sponsorTimer += Time.deltaTime;
        float randPercent = Random.Range(0, timeVariation);

        float n_interval = baseNewsInterval * randPercent + baseNewsInterval;
        float v_interval = baseCongressInterval * randPercent + baseCongressInterval;
        float s_interval = baseSponsorInterval * randPercent + baseSponsorInterval;

        if(newsTimer >= n_interval)
        {
            CreateCard(1);
            newsTimer = 0;
        }

        if(voteTimer >= v_interval)
        {
            CreateCard(2);
            voteTimer = 0;
        }

        if(sponsorTimer >= s_interval)
        {
            CreateCard(3);
            sponsorTimer = 0;
        }
        #endregion

        ar_text.text = "Approval Rating: " + approvalRating + "%";
        f_text.text = "Funds: " + funds + "$";
    }
    
    /*Type
     * 1 = News
     * 2 = Vote
     * 3 = Sponsor
     */
    void CreateCard(int type)
    {
        switch (type)
        {
            case 1:
                CardManager.instance.Add(news[Random.Range(0, news.Count)], type);
                break;

            case 2:
                CardManager.instance.Add(votes[Random.Range(0, votes.Count)], type);
                break;

            case 3:
                CardManager.instance.Add(corporations[Random.Range(0, corporations.Count)], type);
                break;
        }
    }
}

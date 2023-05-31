using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System;

public class ShopManagerScript : MonoBehaviour
{
    public static ShopManagerScript instance;

    int goldAmount;

    int tokenAmount;

    public TextMeshProUGUI goldAmountText;

    public TextMeshProUGUI tokenAmountText;

    int randomNumber;

    public int AdPlusGold = 400;
    private bool rewardPlayer;

    public GameObject PlusGoldPanel;
    public GameObject AdWaitPanel;


    private string appID = "ca-app-pub-9096690948482816~5942791663";

    private RewardedAd rewardedAd;
    private string rewardedAdID = "ca-app-pub-9096690948482816/9784821993";

    public GameObject GoldPanel8000;
    public GameObject GoldPanel24000;
    public GameObject GoldPanel60000;
    public GameObject GoldPanel150000;


    void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        tokenAmount = PlayerPrefs.GetInt("TokenAmount");

        this.rewardedAd = new RewardedAd(rewardedAdID);
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

    }

    void Update()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        tokenAmount = PlayerPrefs.GetInt("TokenAmount");

        goldAmountText.text = goldAmount.ToString();
        tokenAmountText.text = tokenAmount.ToString();

        if (rewardPlayer == true)
        {
            PlusGoldPanel.SetActive(true);
        }
        else
        {
            PlusGoldPanel.SetActive(false);
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AdToGold()
    {
        SoundManagerScript.PlaySound("buttonclick");
    }

    public void CloseAdWait()
    {
        AdWaitPanel.SetActive(false);
    }

    public void to8000()
    {
        IAP_Manager_Script.Instance.Buy8000Gold();
    }

    public void to24000()
    {
        IAP_Manager_Script.Instance.Buy24000Gold();
    }

    public void to60000()
    {
        IAP_Manager_Script.Instance.Buy60000Gold();
    }

    public void to150000()
    {
        IAP_Manager_Script.Instance.Buy150000Gold();
    }

    public void ReceivedReward()
    {
        goldAmount += AdPlusGold;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        rewardPlayer = false;
    }

    public void RequestRewardedAd()
    {
        AdRequest request = new AdRequest.Builder().Build();

        rewardedAd.LoadAd(request);
    }

    public void ShowRewardedAd()
    {
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
        }
        else
        {
            AdWaitPanel.SetActive(true);
            Debug.Log("Rewarded ad not loaded");

        }
    }

/*
    public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
    {
        Debug.Log("Rewarded Video Loaded Success");
    }

    public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.Log("Rewarded Video Loaded Fail");
    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        rewardPlayer = true;
        Debug.Log("Rewarded Video Rewarded Success");
    }

    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
    {
        Debug.Log("Rewarded Video Closed");
        RequestRewardedAd();
    }
*/


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: ");
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
        RequestRewardedAd();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        rewardPlayer = true;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
    }

    public void show8000GoldPanel()
    {
        GoldPanel8000.SetActive(true);
    }

    public void show24000GoldPanel()
    {
        GoldPanel24000.SetActive(true);
    }

    public void show60000GoldPanel()
    {
        GoldPanel60000.SetActive(true);
    }

    public void show150000GoldPanel()
    {
        GoldPanel150000.SetActive(true);
    }


    public void close8000GoldPanel()
    {
        goldAmount += 8000;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        GoldPanel8000.SetActive(false);
    }

    public void close24000GoldPanel()
    {
        goldAmount += 24000;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        GoldPanel24000.SetActive(false);
    }

    public void close60000GoldPanel()
    {
        goldAmount += 60000;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        GoldPanel60000.SetActive(false);
    }

    public void close150000GoldPanel()
    {
        goldAmount += 150000;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        GoldPanel150000.SetActive(false);
    }

    public void temp80000GoldPanel()
    {
        goldAmount += 80000;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
    }
}

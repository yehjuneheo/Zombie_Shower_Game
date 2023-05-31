using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;


public class AdManagerScript : MonoBehaviour
{
    public static AdManagerScript instance;

    private string appID = "ca-app-pub-9096690948482816~5942791663";

    private InterstitialAd fullScreenAd;
    private string fullScreenAdID = "ca-app-pub-9096690948482816/4629709991";



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

    private void Start()
    {
        RequestFullScreenAd();
    }

    public void RequestFullScreenAd()
    {
        fullScreenAd = new InterstitialAd(fullScreenAdID);

        AdRequest request = new AdRequest.Builder().Build();

        fullScreenAd.LoadAd(request);
    }

    public void ShowFullScreenAd()
    {
        if (fullScreenAd.IsLoaded())
        {
            fullScreenAd.Show();
            RequestFullScreenAd();
        }
        else
        {
            Debug.Log("Full Screen ad not loaded");
            RequestFullScreenAd();
        }
    }
}
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;
using TMPro;

public class IAP_Manager_Script : MonoBehaviour, IStoreListener
{
    public static IAP_Manager_Script Instance {set; get;}

    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;

    public static string product8000gold = "8000gold";
    public static string product24000gold = "24000gold";
    public static string product60000gold = "60000gold";
    public static string product150000gold = "150000gold";


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (m_StoreController == null)
        {
            InitializePurchasing();
        }
    }

    public void InitializePurchasing()
    {
        if (IsInitialized())
        {
            return;
        }

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        builder.AddProduct(product8000gold, ProductType.Consumable);
        builder.AddProduct(product24000gold, ProductType.Consumable);
        builder.AddProduct(product60000gold, ProductType.Consumable);
        builder.AddProduct(product150000gold, ProductType.Consumable);

        UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }


    public void Buy8000Gold()
    {
        BuyProductID(product8000gold);
    }

    public void Buy24000Gold()
    {
        BuyProductID(product24000gold);
    }

    public void Buy60000Gold()
    {
        BuyProductID(product60000gold);
    }

    public void Buy150000Gold()
    {
        BuyProductID(product150000gold);
    }


    private void BuyProductID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase)
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        else
        {
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    { 
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }


    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        if (String.Equals(args.purchasedProduct.definition.id, product8000gold, StringComparison.Ordinal))
        {
            ShopManagerScript.instance.show8000GoldPanel();
        }

        else if (String.Equals(args.purchasedProduct.definition.id, product24000gold, StringComparison.Ordinal))
        {
            ShopManagerScript.instance.show24000GoldPanel();
        }

        else if (String.Equals(args.purchasedProduct.definition.id, product60000gold, StringComparison.Ordinal))
        {
            ShopManagerScript.instance.show60000GoldPanel();
        }

        else if (String.Equals(args.purchasedProduct.definition.id, product150000gold, StringComparison.Ordinal))
        {
            ShopManagerScript.instance.show150000GoldPanel();
        }

        else
        {
            Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
        }

        return PurchaseProcessingResult.Complete;
    }


    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }

}
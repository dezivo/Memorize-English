using UnityEngine.Monetization;
using UnityEngine;
using System.Collections;

public class UnityAdsPlacement : MonoBehaviour
{

    public string placementId = "LevelComplete";

    public void ShowAd()
    {
        StartCoroutine(ShowAdWhenReady());
    }

    private IEnumerator ShowAdWhenReady()
    {
        while (!Monetization.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.25f);
        }

        ShowAdPlacementContent ad = null;
        ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;

        if (ad != null)
        {
            ad.Show();
        }
    }

    public void Start()
    {
        if (GameObject.FindObjectOfType<UnityAds>().TriggerAdsCount >= 4)
        {
            ShowAd(); //Show Ads at Count in 4
            GameObject.FindObjectOfType<UnityAds>().TriggerAdsCount = 0;
        }
    }

}

using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdBanner : MonoBehaviour
{
    private readonly string playStoreID = "3525540";
    private readonly string placementId = "bannerAds";

    bool testMode = false;

    IEnumerator Start()
    {
        Advertisement.Initialize(playStoreID,testMode);

        while (!Advertisement.IsReady(placementId))
            yield return null;
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);

        Advertisement.Banner.Show(placementId);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewObserver : MonoBehaviour
{
    private HeroOverview heroOverview;
    private DataNav dataNav;
    private GameObject overView;
    void Start()
    {
 overView = GameObject.Find("OverviewManager");
 heroOverview = overView.GetComponent<HeroOverview>();
 dataNav = overView.GetComponent<DataNav>();
 dataNav.OnNext += heroOverview.ReadHeroData;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

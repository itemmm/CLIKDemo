using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Tabtale.TTPlugins;
using UnityEngine;

public class ScensTest : MonoBehaviour
{

    private void Awake()
    {
        TTPCore.Setup();
    }

    private void Start()
    {
        //TTPAnalytics.LogEvent(AnalyticsTargets.ANALYTICS_TARGET_FIREBASE, "test_event", null, false);
    }
}

// Usage example of Google Universal Analytics.
//
// Copyright 2013 Jetro Lauha (Strobotnik Ltd)
// http://strobotnik.com
// http://jet.ro
//
// $Revision: 1036 $
//
// File version history:
// 2013-09-01, 1.1.1 - Initial version
// 2013-09-25, 1.1.3 - Unity 3.5 support.
// 2013-12-17, 1.2.0 - Added warning for missing Analytics object and check
//                     for Analytics.gua.analyticsDisabled in custom Quit hit.
// 2014-05-12, 1.4.0 - Updated for method renames. (see GoogleUniversalAnalytics.cs)
//                     Refined showing of network status and added showing
//                     count of remaining entries in offline hit cache.
// 2016-01-29, 1.6.2 - Moved user opt-out to main screen and social, exception and
//                     error hit examples from here to secondary screen.
//                     Use Analytics.getActiveSceneName() which uses Unity 5.3+
//                     SceneManager when available.

using UnityEngine;
using System.Collections;

public class AnalyticsExampleMainScreen : MonoBehaviour
{
    void OnGUI()
    {
        if (Analytics.Instance == null)
        {
            GUILayout.BeginVertical();
            GUILayout.Label(" ERROR! No Analytics object in scene!");
            GUILayout.Label(" Add Analytics script to an active game object.");
            GUILayout.EndVertical();
            return;
        }

        GUILayout.BeginHorizontal();
        GUILayout.Label("v");
        GUILayout.Label(Analytics.Instance.appVersion);

        GUILayout.BeginVertical();
        GUILayout.Label("- Google Universal Analytics for Unity");
        GUILayout.Label(" Current scene: " + Analytics.getActiveSceneName() + "\n");

        // Possibility to switch between scenes demonstrates the
        // automatic screen events sent by Analytics.OnLevelWasLoaded().
        //
        // For this test you need to add both AnalyticsExample and
        // AnalyticsExampleSecondaryScene scenes to the project
        // using File->Build Settings.
        //
        GUILayout.Label("Scene switch sends automatic screen view events:");
        if (GUILayout.Button("Go to Secondary Scene\n(Social, error, exception hit examples)"))
        {
#if UNITY_5_3 || UNITY_5_4 || UNITY_5_5 || UNITY_5_6 || UNITY_5_7 || UNITY_5_8 || UNITY_5_9
            UnityEngine.SceneManagement.SceneManager.LoadScene("AnalyticsExampleSecondaryScene");
#else
            Application.LoadLevel("AnalyticsExampleSecondaryScene");
#endif
        }

        GUILayout.Label("Buttons to send imaginary screen switch events:");
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("\"Menuscreen A\""))
            Analytics.changeScreen("AnalyticsExample - Menuscreen A");
        if (GUILayout.Button("\"Menuscreen B\""))
            Analytics.changeScreen("AnalyticsExample - Menuscreen B");
        GUILayout.EndHorizontal();

        GUILayout.Label(" ");
        GUILayout.Label("--- Example for User Consent: ---");

        // Apps should have user consent for collecting and sending analytics data.
        // See https://www.google.com/about/company/user-consent-policy.html
        GUILayout.Label(" This app sends anonymous usage statistics over internet.");
        bool disableAnalyticsByUserOptOut = Analytics.gua.analyticsDisabled;
        bool newValue = GUILayout.Toggle(disableAnalyticsByUserOptOut, "Opt-out from anonymous statistics.");
        if (disableAnalyticsByUserOptOut != newValue)
            Analytics.setPlayerPref_disableAnalyticsByUserOptOut(newValue);

        GUILayout.Label(disableAnalyticsByUserOptOut ? "  :-(" : " ");

        GUILayout.Label("---");

        GUILayout.Label("Remaining entries in offline hit cache:");
        #if UNITY_WEBPLAYER || UNITY_WEBGL
        GUILayout.Label("(not applicable with web builds)");
        #else
        if (Analytics.gua != null)
            GUILayout.Label(Analytics.gua.remainingEntriesInOfflineCache.ToString());
        #endif


        if (GUILayout.Button("Quit"))
        {
            // End session with custom built hit:
            if (!Analytics.gua.analyticsDisabled)
            {
                Analytics.gua.beginHit(GoogleUniversalAnalytics.HitType.Screenview);
                Analytics.gua.addScreenName("AnalyticsExample - Quit");
                Analytics.gua.addSessionControl(false); // end current session
                Analytics.gua.sendHit();
            }
            #if UNITY_3_5
            gameObject.active = false;
            #else
            gameObject.SetActive(false);
            #endif
            Application.Quit();
        }

        GUILayout.Label("Verified internet access: " + Analytics.gua.internetReachable);

        string networkReachability = "Unity NetworkReachability: none";
        if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
            networkReachability = "Unity NetworkReachability: via carrier data network";
        else if (Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
            networkReachability = "Unity NetworkReachability: via local area network";
        GUILayout.Label(networkReachability);

        GUILayout.EndVertical();
        GUILayout.EndHorizontal();
    }

    void Update()
    {
        float t = Time.fixedTime;
        Camera.main.backgroundColor = new Color(
            Mathf.Sin(t * 0.39f) * 0.2f + 0.25f,
            Mathf.Sin(t * 0.23f) * 0.2f + 0.25f,
            Mathf.Sin(t * 0.55f) * 0.2f + 0.25f);
    }
}

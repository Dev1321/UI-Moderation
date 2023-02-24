using UnityEngine;
using Firebase.Analytics;

public class FirebaseManager : MonoBehaviour
{
    public static FirebaseManager instance;
    private Firebase.FirebaseApp app;
   
    private void Awake()
    {
        instance = this;
    }
    //Start is called before the first frame update
    void Start()
    { 
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                app = Firebase.FirebaseApp.DefaultInstance;
                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                   "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }

    public void LogEvent(string name)
    {
        Debug.Log(name +" Event is called");
        FirebaseAnalytics.LogEvent(name);
    }
}
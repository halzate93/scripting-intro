using System;
using UnityEngine;

namespace Assets.SimpleAndroidNotifications
{
    public class NotificationExample : MonoBehaviour
    {
        public void OnGUI ()
        {
            if (GUILayout.Button("Simple 5 sec", GUILayout.Height(Screen.height * 0.2f)))
            {
                NotificationManager.Send(TimeSpan.FromSeconds(5), "Simple notification", "Customize icon and color", new Color(1, 0.3f, 0.15f));
            }

            if (GUILayout.Button("Normal 5 sec", GUILayout.Height(Screen.height * 0.2f)))
            {
                NotificationManager.SendWithAppIcon(TimeSpan.FromSeconds(5), "Notification", "Notification with app icon", new Color(0, 0.6f, 1), "notification_icon_message");
            }

            if (GUILayout.Button("Cancel all", GUILayout.Height(Screen.height * 0.2f)))
            {
                NotificationManager.CancelAll();
            }
        }
    }
}
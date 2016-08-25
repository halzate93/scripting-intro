Simple Android Notifications for Unity provides you simple way to create local notifications for your game and apps.
Plugin suports Android 4.0.3 and later and is compatible with Unity 5. You can play demo scene to check notifications on your device.

Features:
- create local notifications
- customize color, icon, sound, vibration, flashing
- demo scene
- suports Android 4.0.3+ (API level 15+)
- compatible with Unity 5
- nothing extra

Setup & test guide:
- create new empty project
- import package (Assets/Import Package/Custom Package)
- set Minimum API Mevel 15 (Player Settings/Android/Other Settings)
- open and add SimpleAndroidNotifications/DemoScene.scene to Scenes In Build (Build Settings)
- build project to android device
- test notifications and enjoy!

Use NotificationManager to send notifications:
- NotificationManager.Send(TimeSpan delay, string title, string message, Color color, string smallIcon)
- NotificationManager.SendWithAppIcon(TimeSpan delay, string title, string message, Color color, string smallIcon)
- NotificationManager.SendCustom(NotificationParams notificationParams)

List of build-in small icons (use them when calling NotificationManager.SendCustom):
- notification_icon_bell (default)
- notification_icon_clock
- notification_icon_heart
- notification_icon_message
- notification_icon_nut
- notification_icon_star
- notification_icon_warning

To add custom notification icons you'll need to modify .aar file
- find plugin .aar file
- change extension from .aar to .zip
- open .zip in any archive program
- find /res folder
- provide all icon sizes and put files to each /drawable folder
- change extension from .zip to to .aar

Recommended size for small icons:
- 24x24 for drawable-mdpi
- 36x36 for drawable-hdpi
- 48x48 for drawable-xhdpi
- 72x72 for drawable-xxhdpi
- 96x96 for drawable-xxxhdpi
- 96x96 for drawable

Recommended size for large icons (notification background):
- 48x48 for drawable-mdpi
- 72x72 for drawable-hdpi
- 96x96 for drawable-xhdpi
- 144x144 for drawable-xxhdpi
- 192x192 for drawable-xxxhdpi
- 192x192 for drawable

If you have any problems with merging manifests, simply edit AndroidManifest.xml inside .aar plugin.
You can even remove activity "UnityPlayerNativeActivity" from plugin manifest if it's declared somewhere else.
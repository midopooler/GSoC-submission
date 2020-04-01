# GSoC-submission
Download the prototype at https://drive.google.com/file/d/1OGt0c_ONte-t7USL3q5-ytKlDNteMbxU/view?usp=sharing

Watch the demonstration video at https://www.youtube.com/watch?v=qxOBKhha4wY&feature=youtu.be (SOUND ON)

The Gitlab Merge Request is here. https://gitlab.com/aossie/monumento/-/merge_requests/7

##Instructions to use the App
1. Open the app
2. Dont sign in/up. Click continue without signing in.
3. Bypass disclaimer
4. Go straight to the scan scene. Tap the Camera button.
5. As you can't go out for testing (corona outbreak) it on any monument, Try scanning it through another screen or printouts.
6. Currently only Taj Mahal is supported for the demonstration. Try scanning any photo/video of Taj using this app. 
7. Preferred Image to test the App:- https://drive.google.com/open?id=16_Rt-ZY4YIqqVqS-bk1a56stx8sJZ7t-
8. You will now see the name of the monument, some fancy particle effects, and some couple of buttons.
9. These buttons aren't normal buttons, these are AR buttons, Just try hovering over the button, between the camera and the object/photo/video.
10. If you hover above only the button part, that button will now get triggered. And you can then trigger anthing using them.
11. As of now the right button, redirects to the wikipedia page, and the left one takes to another scene. 
12. In the other scene, you can detect the plane nearby and can augment the 3D model of the monument on the tap.
13. You can pinch to zoom, twist to rotate, and drag to translate the object.
14. Also, you can also capture the pictures and record the videos and save to your gallery from inside the app.

##Some parts of the app are hard coded as of now. (for demonstration purpose)
1. Login-Signup. 
   One can enter details but that's not currently integrated with the firebase. So, I've added a continue to login feature there.
2. More page And the account page are currently hard coded.

##Limitations 
For demonstration, I've used some libraries of ARcore also, so because of that the plane detection feature might not work in all phones. 
The compatibility list is given as per the link. https://developers.google.com/ar/discover/supported-devices

